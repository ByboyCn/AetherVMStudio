namespace AetherVMStudio.Core;

/// <summary>
/// 内置演示引擎:纯 C# 的极简 ARM64/x86_64 解释器。
/// 用于在接入真正的 AetherVM(C++)之前,让整个 UI 流程可运行、可验证。
/// 接入真实引擎时,实现 <see cref="IEmulationEngine"/> 替换即可。
/// </summary>
public sealed class DemoEngine : IEmulationEngine
{
    public string Name => "DemoEngine (内置演示)";

    private GuestArch _arch = GuestArch.Arm64;
    private byte[] _code = Array.Empty<byte>();
    private readonly Dictionary<string, ulong> _registers = new();
    private readonly List<MemoryRegion> _regions = new();
    private EventConfig _events;
    private int _traceId;
    private int _insnCount;

    public bool IsFinished { get; private set; }
    public event Action<TraceRecord>? OnTrace;
    public event Action? OnStateChanged;

    public IReadOnlyDictionary<string, ulong> ReadRegisters() => _registers;

    public void Load(GuestArch arch, byte[] code, Dictionary<string, ulong> initialRegisters, EventConfig events)
    {
        _arch = arch;
        _code = code;
        _events = events;
        Reset();
        foreach (var (k, v) in initialRegisters) _registers[k] = v;
        OnStateChanged?.Invoke();
    }

    public void Reset()
    {
        _registers.Clear();
        foreach (var name in _arch.GprNames()) _registers[name] = 0;
        _registers[_arch.PcName()] = _arch.DefaultPc();
        _registers[_arch.SpName()] = _arch.DefaultSp();
        _registers[_arch.FlagsName()] = 0;

        var codePad = new byte[Math.Max(_code.Length, 0x1000)];
        Array.Copy(_code, codePad, _code.Length);
        _regions.Clear();
        _regions.Add(new MemoryRegion { Name = "code", Base = _arch.CodeBase(), Data = codePad });
        _regions.Add(new MemoryRegion { Name = "stack", Base = 0x00007FFF_F0000000, Data = new byte[0x100000] });

        IsFinished = false;
        _insnCount = 0;
        OnStateChanged?.Invoke();
    }

    public void Run(int maxInstructions = 10_000)
    {
        if (_code.Length == 0) throw new EngineException("没有加载任何代码,请粘贴 hex 或输入 .bin 文件路径");
        for (var i = 0; i < maxInstructions && !IsFinished; i++) Step();
    }

    public void Step()
    {
        if (IsFinished) return;
        if (_code.Length == 0) throw new EngineException("没有加载任何代码");

        var pc = _registers.GetValueOrDefault(_arch.PcName());
        var offset = checked((int)(pc - _arch.CodeBase()));
        if (offset < 0 || offset >= _code.Length)
        {
            Fail($"PC 越界: 0x{pc:X16}");
            return;
        }

        _insnCount++;
        var nextPc = pc;
        string desc;
        if (_arch == GuestArch.Arm64) desc = StepArm64(pc, offset, ref nextPc);
        else desc = StepX86(pc, offset, ref nextPc);

        Emit(TraceKind.Insn, pc, desc);
        _registers[_arch.PcName()] = nextPc;
        OnStateChanged?.Invoke();
    }

    private string StepArm64(ulong pc, int offset, ref ulong nextPc)
    {
        uint word = BitConverter.ToUInt32(_code, offset);
        nextPc = pc + 4;

        if (word == 0xD503201F) return "nop";

        // mov xd, xm : (word & 0xFFE0FFE0) == 0xAA0003E0
        if ((word & 0xFFE0FFE0) == 0xAA0003E0)
        {
            var rd = word & 0x1F;
            var rm = (word >> 16) & 0x1F;
            _registers[$"x{rd}"] = _registers.GetValueOrDefault($"x{rm}");
            return $"mov x{rd}, x{rm}";
        }

        // movz xd, #imm{, lsl #shift}
        if ((word & 0xFF000000) == 0xD2800000)
        {
            var rd = word & 0x1F;
            var imm = (word >> 5) & 0xFFFF;
            var shift = (int)((word >> 21) & 0x3) * 16;
            _registers[$"x{rd}"] = imm << shift;
            return $"movz x{rd}, #0x{imm:x}<<{shift}";
        }

        // add xd, xn, #imm12
        if ((word & 0xFF000000) == 0x91000000)
        {
            var rd = word & 0x1F;
            var rn = (word >> 5) & 0x1F;
            var imm = (word >> 10) & 0xFFF;
            _registers[$"x{rd}"] = _registers.GetValueOrDefault($"x{rn}") + imm;
            return $"add x{rd}, x{rn}, #{imm}";
        }

        if (word == 0xD65F03C0) // ret
        {
            IsFinished = true;
            Emit(TraceKind.Event, pc, $"RET — 仿真结束,共执行 {_insnCount} 条指令");
            return "ret";
        }

        var unknown = $".word 0x{word:x} (演示引擎未实现该指令)";
        Emit(TraceKind.Error, pc, unknown);
        IsFinished = true;
        return unknown;
    }

    private string StepX86(ulong pc, int offset, ref ulong nextPc)
    {
        var b = _code[offset];
        nextPc = pc + 1;

        switch (b)
        {
            case 0x90: return "nop";
            case 0xC3:
                IsFinished = true;
                Emit(TraceKind.Event, pc, $"RET — 仿真结束,共执行 {_insnCount} 条指令");
                return "ret";
            case >= 0xB8 and <= 0xBF: // mov r32, imm32
            {
                var names = new[] { "eax", "ecx", "edx", "ebx", "esp", "ebp", "esi", "edi" };
                if (offset + 5 > _code.Length)
                {
                    Fail("指令被截断");
                    return "?";
                }
                var imm = BitConverter.ToUInt32(_code, offset + 1);
                _registers[names[b - 0xB8]] = imm;
                nextPc = pc + 5;
                return $"mov {names[b - 0xB8]}, 0x{imm:x}";
            }
            default:
            {
                var unknown = $".byte 0x{b:x} (演示引擎未实现该指令)";
                Emit(TraceKind.Error, pc, unknown);
                IsFinished = true;
                return unknown;
            }
        }
    }

    public byte[]? ReadMemory(ulong address, int size)
    {
        var region = RegionAt(address);
        if (region is null || address + (ulong)size > region.End) return null;
        var offset = (int)(address - region.Base);
        var result = new byte[size];
        Array.Copy(region.Data, offset, result, 0, size);
        return result;
    }

    public void WriteMemory(ulong address, byte[] data)
    {
        var region = RegionAt(address);
        if (region is null) return;
        var offset = (int)(address - region.Base);
        Array.Copy(data, 0, region.Data, offset, data.Length);
        OnStateChanged?.Invoke();
    }

    public void WriteRegister(string name, ulong value)
    {
        _registers[name] = value;
        OnStateChanged?.Invoke();
    }

    private MemoryRegion? RegionAt(ulong address) =>
        _regions.FirstOrDefault(r => address >= r.Base && address < r.End);

    private void Emit(TraceKind kind, ulong address, string text) =>
        OnTrace?.Invoke(new TraceRecord(_traceId++, kind, address, text, DateTime.Now));

    private void Fail(string msg)
    {
        Emit(TraceKind.Error, _registers.GetValueOrDefault(_arch.PcName()), msg);
        IsFinished = true;
        OnStateChanged?.Invoke();
    }
}
