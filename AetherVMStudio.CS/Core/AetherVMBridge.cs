using System.Runtime.InteropServices;

namespace AetherVMStudio.Core;

/// <summary>
/// AetherVM(C++)桥接层。
///
/// 在 Mac 上用 ICPP 编译好 AetherVM 后,把引擎封装成 C ABI 动态库
/// (libaevm_bridge.dylib / aevm_bridge.dll / libaevm_bridge.so),
/// 下面的 P/Invoke 即可跨平台接入。实现完把 <see cref="IsAvailable"/> 改为 true,
/// UI 会自动切换到真实引擎。
///
/// C++ 侧参考:
/// <code>
/// extern "C" {
///     void*   aevm_create(int arch);                       // BinaryEngine + Machine
///     void    aevm_set_reg(void* e, const char* name, uint64_t v);
///     uint64_t aevm_get_reg(void* e, const char* name);
///     void    aevm_execute(void* e, const uint8_t* code, size_t len);
///     void    aevm_step(void* e);
///     void    aevm_reset(void* e);
///     int     aevm_read_mem(void* e, uint64_t addr, uint8_t* out, size_t len);
///     void    aevm_write_mem(void* e, uint64_t addr, const uint8_t* data, size_t len);
///     int     aevm_is_finished(void* e);
///     void    aevm_set_trace_cb(void* e, void (*cb)(int kind, uint64_t addr, const char* text, void* user), void* user);
///     void    aevm_destroy(void* e);
/// }
/// </code>
/// </summary>
public sealed class AetherVMBridge : IEmulationEngine
{
    public string Name => "AetherVM (C++)";

    // 编译好桥接库后改为 true
    public bool IsAvailable { get; set; }

    public bool IsFinished { get; private set; }
    public event Action<TraceRecord>? OnTrace;
    public event Action? OnStateChanged;

    // ---- P/Invoke 声明(接入时取消注释并加载库) ----
    // private const string Lib = "aevm_bridge";
    //
    // [DllImport(Lib)] private static extern IntPtr aevm_create(int arch);
    // [DllImport(Lib)] private static extern void aevm_destroy(IntPtr engine);
    // [DllImport(Lib)] private static extern void aevm_set_reg(IntPtr engine, string name, ulong value);
    // [DllImport(Lib)] private static extern ulong aevm_get_reg(IntPtr engine, string name);
    // [DllImport(Lib)] private static extern void aevm_execute(IntPtr engine, byte[] code, UIntPtr len);
    // [DllImport(Lib)] private static extern void aevm_step(IntPtr engine);
    // [DllImport(Lib)] private static extern void aevm_reset(IntPtr engine);
    // [DllImport(Lib)] private static extern int aevm_read_mem(IntPtr engine, ulong addr, byte[] outBuf, UIntPtr len);
    // [DllImport(Lib)] private static extern void aevm_write_mem(IntPtr engine, ulong addr, byte[] data, UIntPtr len);
    // [DllImport(Lib)] private static extern int aevm_is_finished(IntPtr engine);
    //
    // [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    // private delegate void TraceCallback(int kind, ulong addr, string text, IntPtr user);
    // [DllImport(Lib)] private static extern void aevm_set_trace_cb(IntPtr engine, TraceCallback cb, IntPtr user);

    private IntPtr _engine = IntPtr.Zero;
    private GuestArch _arch = GuestArch.Arm64;

    public void Load(GuestArch arch, byte[] code, Dictionary<string, ulong> initialRegisters, EventConfig events)
    {
        if (!IsAvailable) throw new EngineException("AetherVM 桥接库未加载");
        _arch = arch;
        // _engine = aevm_create(arch == GuestArch.Arm64 ? 0 : 1);
        // foreach (var (k, v) in initialRegisters) aevm_set_reg(_engine, k, v);
        // aevm_execute(_engine, code, (UIntPtr)code.Length);
        OnStateChanged?.Invoke();
    }

    public void Run(int maxInstructions = 10_000)
    {
        if (!IsAvailable) throw new EngineException("AetherVM 桥接库未加载");
        // for (var i = 0; i < maxInstructions && aevm_is_finished(_engine) == 0; i++) aevm_step(_engine);
    }

    public void Step()
    {
        if (!IsAvailable) throw new EngineException("AetherVM 桥接库未加载");
        // aevm_step(_engine);
        OnStateChanged?.Invoke();
    }

    public void Reset()
    {
        // aevm_reset(_engine);
        OnStateChanged?.Invoke();
    }

    public IReadOnlyDictionary<string, ulong> ReadRegisters()
    {
        var result = new Dictionary<string, ulong>();
        // if (IsAvailable) { ... 逐个 aevm_get_reg ... }
        return result;
    }

    public byte[]? ReadMemory(ulong address, int size)
    {
        // var buf = new byte[size];
        // return aevm_read_mem(_engine, address, buf, (UIntPtr)size) == 0 ? buf : null;
        return null;
    }

    public void WriteMemory(ulong address, byte[] data)
    {
        // aevm_write_mem(_engine, address, data, (UIntPtr)data.Length);
    }

    public void WriteRegister(string name, ulong value)
    {
        // aevm_set_reg(_engine, name, value);
        OnStateChanged?.Invoke();
    }
}
