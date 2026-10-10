using System.Text;

namespace AetherVMStudio.Core;

/// <summary>视图模型:解析输入、驱动引擎、聚合状态,通过事件通知 UI 刷新。</summary>
public sealed class EmulationViewModel
{
    public GuestArch Arch { get; set; } = GuestArch.Arm64;
    public string CodeText { get; set; } = "1f 20 03 d5\n28 00 80 52\n09 01 80 52\n08 01 09 0b\nc0 03 5f d6";
    public string InitialRegisterText { get; set; } = "x0 = 0x1\nx1 = 0x2";
    public string FilePathText { get; set; } = "";
    public EventConfig Events { get; set; } = EventConfig.Insn | EventConfig.Syscall | EventConfig.Trap;

    public DemoEngine Demo { get; } = new();
    public AetherVMBridge Aether { get; } = new();
    public IEmulationEngine Active => Aether.IsAvailable ? Aether : Demo;

    public List<TraceRecord> Trace { get; } = new();

    public event Action<string>? StatusChanged;
    public event Action? StateChanged;

    public string StatusMessage { get; private set; } = "就绪 — 粘贴 hex 代码或输入 .bin 文件路径";

    public EmulationViewModel()
    {
        Demo.OnTrace += rec =>
        {
            Trace.Add(rec);
            StateChanged?.Invoke();
        };
        Demo.OnStateChanged += () => StateChanged?.Invoke();
    }

    // ============ 输入解析 ============

    public byte[]? ParseCodeText()
    {
        var cleaned = CodeText.Replace("0x", "").Replace(",", " ").Replace("\r", " ");
        var tokens = cleaned.Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        var bytes = new List<byte>();
        foreach (var t in tokens)
        {
            if (!byte.TryParse(t, System.Globalization.NumberStyles.HexNumber, null, out var b)) return null;
            bytes.Add(b);
        }
        return bytes.Count == 0 ? null : bytes.ToArray();
    }

    public Dictionary<string, ulong> ParseInitialRegisters()
    {
        var result = new Dictionary<string, ulong>(StringComparer.OrdinalIgnoreCase);
        foreach (var rawLine in InitialRegisterText.Split('\n'))
        {
            var line = rawLine.Replace("=", " ").Trim();
            var parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 2 &&
                ulong.TryParse(parts[1].Replace("0x", ""), System.Globalization.NumberStyles.HexNumber, null, out var v))
            {
                result[parts[0].ToLowerInvariant()] = v;
            }
        }
        return result;
    }

    // ============ 引擎操作 ============

    public void Load()
    {
        var code = ParseCodeText();
        if (code is null)
        {
            SetStatus("❌ 无法解析代码:请输入十六进制字节(如 1f 20 03 d5),或输入 .bin 文件路径后点「加载文件」");
            return;
        }
        Trace.Clear();
        try
        {
            Active.Load(Arch, code, ParseInitialRegisters(), Events);
            SetStatus($"✅ 已加载 {code.Length} 字节 {Arch.DisplayName()} 代码 (引擎: {Active.Name})");
        }
        catch (Exception ex)
        {
            SetStatus($"❌ 加载失败: {ex.Message}");
        }
        StateChanged?.Invoke();
    }

    public void LoadFile(string path)
    {
        try
        {
            var data = File.ReadAllBytes(path);
            CodeText = string.Join(" ", data.Select(b => b.ToString("x2")));
            Arch = GuessArch(data, path);
            SetStatus($"📄 已加载 {Path.GetFileName(path)} ({data.Length} 字节)");
            Load();
        }
        catch (Exception ex)
        {
            SetStatus($"❌ 读取文件失败: {ex.Message}");
        }
    }

    public static GuestArch GuessArch(byte[] data, string path)
    {
        if (data.Length >= 4)
        {
            var magic = BitConverter.ToUInt32(data, 0);
            if (magic == 0xFEEDFACF || magic == 0xCFFAEDFE) return GuestArch.Arm64; // Mach-O 64
        }
        if (Path.GetFileName(path).ToLowerInvariant().Contains("x86")) return GuestArch.X86_64;
        return GuestArch.Arm64;
    }

    public void Run()
    {
        Load();
        try
        {
            Active.Run();
            SetStatus(Active.IsFinished ? "🏁 仿真结束" : "⏸ 已执行 10000 条指令(未结束)");
        }
        catch (Exception ex)
        {
            SetStatus($"❌ 运行错误: {ex.Message}");
        }
        StateChanged?.Invoke();
    }

    public void Step()
    {
        try
        {
            Active.Step();
            SetStatus($"单步完成 (共 {Trace.Count} 条记录)");
        }
        catch (Exception ex)
        {
            SetStatus($"❌ {ex.Message}");
        }
        StateChanged?.Invoke();
    }

    public void Reset()
    {
        try { Active.Reset(); } catch { /* 引擎未加载时忽略 */ }
        Trace.Clear();
        SetStatus("已重置");
        StateChanged?.Invoke();
    }

    private void SetStatus(string msg)
    {
        StatusMessage = msg;
        StatusChanged?.Invoke(msg);
    }

    // ============ 视图格式化 ============

    public string FormatRegisters()
    {
        var sb = new StringBuilder();
        var regs = Active.ReadRegisters();
        foreach (var name in Arch.GprNames())
        {
            if (regs.TryGetValue(name, out var v))
                sb.AppendLine($"{name,-6} 0x{v:X16}");
        }
        foreach (var special in new[] { Arch.PcName(), Arch.SpName(), Arch.FlagsName() })
        {
            if (regs.TryGetValue(special, out var v))
                sb.AppendLine($"{special,-6} 0x{v:X16}");
        }
        return sb.ToString();
    }

    public string FormatTrace()
    {
        var sb = new StringBuilder();
        foreach (var rec in Trace.TakeLast(500))
            sb.AppendLine($"[{rec.KindTag,-7}] {rec.AddressHex}  {rec.Text}");
        return sb.ToString();
    }

    public static string FormatHexDump(byte[] data, ulong baseAddress)
    {
        var sb = new StringBuilder();
        for (var offset = 0; offset < data.Length; offset += 16)
        {
            var count = Math.Min(16, data.Length - offset);
            var hex = new StringBuilder();
            var ascii = new StringBuilder();
            for (var i = 0; i < count; i++)
            {
                var b = data[offset + i];
                hex.Append(b.ToString("x2"));
                if (i == 7) hex.Append(' ');
                hex.Append(' ');
                ascii.Append(b is >= 0x20 and < 0x7F ? (char)b : '.');
            }
            sb.AppendLine($"{baseAddress + (ulong)offset:X16}  {hex} {ascii}");
        }
        return sb.ToString();
    }
}
