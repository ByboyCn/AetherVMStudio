using System.Runtime.InteropServices;

namespace AetherVMStudio.Core;

/// <summary>
/// AetherVM(C++)桥接层。
///
/// 运行时在以下位置探测原生库 aevm_bridge(libname 随平台为
/// aevm_bridge.dll / libaevm_bridge.dylib / libaevm_bridge.so):
///   1. 环境变量 AEVM_BRIDGE_LIB 指定的路径
///   2. 应用程序目录(Windows);.app/Contents/MacOS(macOS 随包);应用目录(Linux)
/// 找不到则保持 IsAvailable=false,UI 自动回退到 DemoEngine。
///
/// C ABI 约定(实现见 native/AetherVMBridge.cpp):
/// <code>
/// extern "C" {
///     void*    aevm_create(int arch);            // 0=ARM64, 1=x86_64
///     void     aevm_destroy(void* e);
///     void     aevm_set_reg(void* e, const char* name, uint64_t v);
///     uint64_t aevm_get_reg(void* e, const char* name);
///     void     aevm_load_code(void* e, const uint8_t* code, size_t len);
///     void     aevm_run(void* e, int max_insns);
///     void     aevm_step(void* e);
///     void     aevm_reset(void* e);
///     int      aevm_is_finished(void* e);
///     int      aevm_read_mem(void* e, uint64_t addr, uint8_t* out, size_t len);
///     void     aevm_write_mem(void* e, uint64_t addr, const uint8_t* data, size_t len);
///     void     aevm_set_trace_cb(void* e, void (*cb)(int kind, uint64_t addr, const char* text, void* user), void* user);
/// }
/// </code>
/// </summary>
public sealed class AetherVMBridge : IEmulationEngine
{
    private const string Lib = "aevm_bridge";

    public string Name => "AetherVM (C++)";

    public bool IsAvailable { get; private set; }

    public bool IsFinished { get; private set; }
    public event Action<TraceRecord>? OnTrace;
    public event Action? OnStateChanged;

    // ---- P/Invoke ----

    [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
    private static extern IntPtr aevm_create(int arch);

    [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
    private static extern void aevm_destroy(IntPtr engine);

    [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
    private static extern void aevm_set_reg(IntPtr engine, string name, ulong value);

    [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
    private static extern ulong aevm_get_reg(IntPtr engine, string name);

    [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
    private static extern void aevm_load_code(IntPtr engine, byte[] code, UIntPtr len);

    [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
    private static extern void aevm_run(IntPtr engine, int maxInsns);

    [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
    private static extern void aevm_step(IntPtr engine);

    [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
    private static extern void aevm_reset(IntPtr engine);

    [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
    private static extern int aevm_is_finished(IntPtr engine);

    [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
    private static extern int aevm_read_mem(IntPtr engine, ulong addr, byte[] buf, UIntPtr len);

    [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
    private static extern void aevm_write_mem(IntPtr engine, ulong addr, byte[] data, UIntPtr len);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void TraceCallback(int kind, ulong addr, string text, IntPtr user);

    [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
    private static extern void aevm_set_trace_cb(IntPtr engine, TraceCallback cb, IntPtr user);

    // ---- 状态 ----

    private IntPtr _engine = IntPtr.Zero;
    private GuestArch _arch = GuestArch.Arm64;
    private byte[] _code = Array.Empty<byte>();
    private EventConfig _events;
    private int _traceId;
    private TraceCallback? _traceCb; // 防 GC 回收

    private static readonly TraceCallback TraceHandler = (kind, addr, text, _) =>
    {
        OnNativeTrace?.Invoke((TraceKind)kind, addr, text);
    };

    // 原生回调线程可能不是 UI 线程;经静态事件中转(简化:直接触发实例事件)
    private static event Action<TraceKind, ulong, string>? OnNativeTrace;

    public AetherVMBridge()
    {
        IsAvailable = TryLoadLibrary();
    }

    private static bool TryLoadLibrary()
    {
        try
        {
            // 显式探测,失败时不抛异常
            var env = Environment.GetEnvironmentVariable("AEVM_BRIDGE_LIB");
            if (!string.IsNullOrEmpty(env) && File.Exists(env))
                return NativeLibrary.TryLoad(env, out _);

            var dir = AppContext.BaseDirectory;
            var names = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                ? new[] { "aevm_bridge.dll" }
                : RuntimeInformation.IsOSPlatform(OSPlatform.OSX)
                    ? new[] { "libaevm_bridge.dylib" }
                    : new[] { "libaevm_bridge.so" };

            foreach (var n in names)
            {
                var path = Path.Combine(dir, n);
                if (File.Exists(path) && NativeLibrary.TryLoad(path, out _))
                    return true;
            }
            // 也允许已在进程搜索路径中
            return NativeLibrary.TryLoad(Lib, out _);
        }
        catch
        {
            return false;
        }
    }

    private void EnsureEngine()
    {
        if (_engine != IntPtr.Zero) return;
        _engine = aevm_create(_arch == GuestArch.Arm64 ? 0 : 1);
        _traceCb = TraceHandler;
        OnNativeTrace += (kind, addr, text) =>
        {
            OnTrace?.Invoke(new TraceRecord(_traceId++, kind, addr, text, DateTime.Now));
        };
        aevm_set_trace_cb(_engine, _traceCb, IntPtr.Zero);
    }

    public IReadOnlyDictionary<string, ulong> ReadRegisters()
    {
        var result = new Dictionary<string, ulong>();
        if (!IsAvailable || _engine == IntPtr.Zero) return result;
        foreach (var name in _arch.GprNames()) result[name] = aevm_get_reg(_engine, name);
        result[_arch.PcName()] = aevm_get_reg(_engine, _arch.PcName());
        result[_arch.SpName()] = aevm_get_reg(_engine, _arch.SpName());
        return result;
    }

    public void Load(GuestArch arch, byte[] code, Dictionary<string, ulong> initialRegisters, EventConfig events)
    {
        if (!IsAvailable) throw new EngineException("AetherVM 原生库未找到(aevm_bridge)");
        _arch = arch;
        _code = code;
        _events = events;
        _traceId = 0;
        EnsureEngine();
        aevm_reset(_engine);
        foreach (var (k, v) in initialRegisters) aevm_set_reg(_engine, k, v);
        aevm_load_code(_engine, code, (UIntPtr)code.Length);
        IsFinished = false;
        OnStateChanged?.Invoke();
    }

    public void Run(int maxInstructions = 10_000)
    {
        if (!IsAvailable || _engine == IntPtr.Zero) throw new EngineException("引擎未加载");
        aevm_run(_engine, maxInstructions);
        IsFinished = aevm_is_finished(_engine) != 0;
        OnStateChanged?.Invoke();
    }

    public void Step()
    {
        if (!IsAvailable || _engine == IntPtr.Zero) throw new EngineException("引擎未加载");
        aevm_step(_engine);
        IsFinished = aevm_is_finished(_engine) != 0;
        OnStateChanged?.Invoke();
    }

    public void Reset()
    {
        if (!IsAvailable || _engine == IntPtr.Zero) return;
        aevm_reset(_engine);
        IsFinished = false;
        OnStateChanged?.Invoke();
    }

    public byte[]? ReadMemory(ulong address, int size)
    {
        if (!IsAvailable || _engine == IntPtr.Zero) return null;
        var buf = new byte[size];
        return aevm_read_mem(_engine, address, buf, (UIntPtr)size) == 0 ? buf : null;
    }

    public void WriteMemory(ulong address, byte[] data)
    {
        if (!IsAvailable || _engine == IntPtr.Zero) return;
        aevm_write_mem(_engine, address, data, (UIntPtr)data.Length);
        OnStateChanged?.Invoke();
    }

    public void WriteRegister(string name, ulong value)
    {
        if (!IsAvailable || _engine == IntPtr.Zero) return;
        aevm_set_reg(_engine, name, value);
        OnStateChanged?.Invoke();
    }
}
