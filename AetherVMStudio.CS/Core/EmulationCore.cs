using System.Text;

namespace AetherVMStudio.Core;

// ============ 客户架构 ============

public enum GuestArch
{
    Arm64,
    X86_64,
}

public static class ArchExtensions
{
    public static string DisplayName(this GuestArch arch) => arch switch
    {
        GuestArch.Arm64 => "ARM64 (AArch64)",
        _ => "x86_64",
    };

    public static string[] GprNames(this GuestArch arch) => arch switch
    {
        GuestArch.Arm64 => Enumerable.Range(0, 31).Select(i => $"x{i}").ToArray(),
        _ => new[] { "rax", "rbx", "rcx", "rdx", "rsi", "rdi", "rbp", "rsp",
                     "r8", "r9", "r10", "r11", "r12", "r13", "r14", "r15" },
    };

    public static string PcName(this GuestArch arch) => arch == GuestArch.Arm64 ? "pc" : "rip";
    public static string SpName(this GuestArch arch) => arch == GuestArch.Arm64 ? "sp" : "rsp";
    public static string FlagsName(this GuestArch arch) => arch == GuestArch.Arm64 ? "nzcv" : "rflags";
    public static ulong DefaultSp(this GuestArch arch) => 0x00007FFF_FFFF0000;
    public static ulong DefaultPc(this GuestArch arch) => 0x00000000_00100000;
    public static ulong CodeBase(this GuestArch arch) => 0x00000000_00100000;
}

// ============ 事件配置(对应 AetherVM 64 位 EventConfig bitfield) ============

[Flags]
public enum EventConfig : ulong
{
    Lift = 1UL << 0,
    Memory = 1UL << 1,
    Insn = 1UL << 2,
    Block = 1UL << 3,
    Func = 1UL << 4,
    Syscall = 1UL << 5,
    Trap = 1UL << 6,
    Bridge = 1UL << 7,
    Debug = 1UL << 8,
}

public static class EventConfigNames
{
    public static readonly (EventConfig Flag, string Name)[] All =
    {
        (EventConfig.Lift, "lift (指令提升)"),
        (EventConfig.Memory, "memory (内存访问)"),
        (EventConfig.Insn, "insn (每条指令)"),
        (EventConfig.Block, "block (基本块)"),
        (EventConfig.Func, "func (函数)"),
        (EventConfig.Syscall, "syscall (系统调用)"),
        (EventConfig.Trap, "trap (异常/陷阱)"),
        (EventConfig.Bridge, "bridge (宿主桥接)"),
        (EventConfig.Debug, "debug (调试)"),
    };
}

// ============ Trace 记录 ============

public enum TraceKind { Insn, Memory, Syscall, Block, Event, Error }

public record TraceRecord(int Id, TraceKind Kind, ulong Address, string Text, DateTime Timestamp)
{
    public string AddressHex => $"0x{Address:X16}";
    public string KindTag => Kind switch
    {
        TraceKind.Insn => "INSN",
        TraceKind.Memory => "MEM",
        TraceKind.Syscall => "SYSCALL",
        TraceKind.Block => "BLOCK",
        TraceKind.Event => "EVENT",
        _ => "ERROR",
    };
}

// ============ 内存区域 ============

public sealed class MemoryRegion
{
    public required string Name { get; init; }
    public required ulong Base { get; init; }
    public required byte[] Data { get; init; }
    public ulong End => Base + (ulong)Data.Length;
}

// ============ 引擎协议 ============

public interface IEmulationEngine
{
    string Name { get; }
    bool IsFinished { get; }
    event Action<TraceRecord>? OnTrace;
    event Action? OnStateChanged;

    void Load(GuestArch arch, byte[] code, Dictionary<string, ulong> initialRegisters, EventConfig events);
    void Run(int maxInstructions = 10_000);
    void Step();
    void Reset();
    IReadOnlyDictionary<string, ulong> ReadRegisters();
    byte[]? ReadMemory(ulong address, int size);
    void WriteMemory(ulong address, byte[] data);
    void WriteRegister(string name, ulong value);
}

public class EngineException : Exception
{
    public EngineException(string message) : base(message) { }
}
