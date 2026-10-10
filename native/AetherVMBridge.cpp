// AetherVMBridge.cpp — 把 AetherVM(C++ v0.2.0)封装成 C ABI 动态库,供 AetherVMStudio (C#) P/Invoke。
//
// AetherVM 运行库与头文件直接来自 icpp 官方预编译包(内含 include/aevm 与 AetherVM 动态库):
//   cmake -S native -B native/build -DCMAKE_BUILD_TYPE=Release -DAETHERVM_ROOT=<icpp 解包目录>
//   cmake --build native/build --config Release
// 产物:aevm_bridge.dll / libaevm_bridge.dylib / libaevm_bridge.so
//
// 引擎模式:BinaryEngine(nullptr) + execute(raw opcodes) —— 官方 opcode 直接执行模式。

#include <cstdint>
#include <cstring>
#include <memory>
#include <span>
#include <string>
#include <vector>

#include <aevm/AetherVM.h>
#include <aevm/Register.h>
#include <AetherArch.h> // aether::MachineARM64 / MachineX86(AetherBinary)

using TraceCb = void (*)(int kind, uint64_t addr, const char *text, void *user);

#if defined(_WIN32)
#define BRIDGE_API extern "C" __declspec(dllexport)
#else
#define BRIDGE_API extern "C" __attribute__((visibility("default")))
#endif

static constexpr uint64_t kCodeBase = 0x100000;

// Trace kind 常量,与 C# TraceKind 对齐:0=INSN 1=MEM 2=SYSCALL 3=BLOCK 4=EVENT 5=ERROR

struct BridgeEngine
{
    std::unique_ptr<aether::Machine> machine;
    aether::BinaryEngine engine;
    TraceCb traceCb = nullptr;
    void *traceUser = nullptr;
    std::vector<uint8_t> code;
    bool finished = false;

    explicit BridgeEngine(int arch)
        : machine(arch == 1 ? static_cast<aether::Machine *>(new aether::MachineX86())
                            : static_cast<aether::Machine *>(new aether::MachineARM64()))
        , engine(machine.get())
    {
    }

    void emit(int kind, uint64_t addr, const std::string &text)
    {
        if (traceCb)
            traceCb(kind, addr, text.c_str(), traceUser);
    }
};

BRIDGE_API void *aevm_create(int arch)
{
    return new (std::nothrow) BridgeEngine(arch);
}

BRIDGE_API void aevm_destroy(void *e)
{
    delete static_cast<BridgeEngine *>(e);
}

static aether::Register regByName(const std::string &n, bool &ok)
{
    ok = true;
    if (n == "pc" || n == "rip")
        return aether::Register::PC;
    if (n == "sp" || n == "rsp")
        return aether::Register::SP; // SP = X31 别名
    if (n == "fp" || n == "rbp")
        return aether::Register::FP; // FP = X29 别名
    if (n == "nzcv" || n == "rflags")
        return aether::Register::NZCV;
    if (n.rfind("x", 0) == 0)
    {
        try
        {
            int idx = std::stoi(n.substr(1));
            if (idx >= 0 && idx <= 30)
                return static_cast<aether::Register>(static_cast<int>(aether::Register::X0) + idx);
        }
        catch (...) {}
    }
    // x86_64 别名(独立枚举槽位,见 Register.h)
    static const std::vector<std::pair<const char *, aether::Register>> kX86 = {
        {"rax", aether::Register::RAX}, {"rbx", aether::Register::RBX},
        {"rcx", aether::Register::RCX}, {"rdx", aether::Register::RDX},
        {"rsi", aether::Register::RSI}, {"rdi", aether::Register::RDI},
        {"r8", aether::Register::R8},   {"r9", aether::Register::R9},
        {"r10", aether::Register::R10}, {"r11", aether::Register::R11},
        {"r12", aether::Register::R12}, {"r13", aether::Register::R13},
        {"r14", aether::Register::R14}, {"r15", aether::Register::R15},
    };
    for (auto &[name, reg] : kX86)
        if (n == name)
            return reg;
    ok = false;
    return aether::Register::X0;
}

BRIDGE_API void aevm_set_reg(void *e, const char *name, uint64_t value)
{
    auto *b = static_cast<BridgeEngine *>(e);
    bool ok = false;
    auto reg = regByName(name, ok);
    if (!ok)
        return;
    aether::RegisterValue v{};
    v.u8 = value;
    b->engine.setRegister(reg, v);
}

BRIDGE_API uint64_t aevm_get_reg(void *e, const char *name)
{
    auto *b = static_cast<BridgeEngine *>(e);
    bool ok = false;
    auto reg = regByName(name, ok);
    if (!ok)
        return 0;
    auto *v = b->engine.getRegister(reg, /*cvtpc=*/false);
    return v ? v->u8 : 0;
}

BRIDGE_API void aevm_load_code(void *e, const uint8_t *code, size_t len)
{
    auto *b = static_cast<BridgeEngine *>(e);
    b->code.assign(code, code + len);
    b->finished = false;
    aether::RegisterValue pc{};
    pc.u8 = kCodeBase;
    b->engine.setRegister(aether::Register::PC, pc);
    b->engine.prefetch(b->code); // 预取提升,加速后续执行
}

BRIDGE_API void aevm_run(void *e, int maxInsns)
{
    auto *b = static_cast<BridgeEngine *>(e);
    // [ADAPT] maxInsns 暂未使用;可通过事件回调返回 Terminate 实现截断
    (void)maxInsns;
    try
    {
        bool ok = b->engine.execute(std::span<const uint8_t>(b->code));
        if (!ok)
            b->emit(5 /*ERROR*/, kCodeBase, "execute failed (未实现的指令或执行错误)");
    }
    catch (const std::exception &ex)
    {
        b->emit(5 /*ERROR*/, kCodeBase, ex.what());
    }
    b->finished = true;
}

BRIDGE_API void aevm_step(void *e)
{
    // [ADAPT] v0.2.0 无显式单步 API;这里等同整体执行
    aevm_run(e, 1);
}

BRIDGE_API void aevm_reset(void *e)
{
    auto *b = static_cast<BridgeEngine *>(e);
    b->finished = false;
    aether::RegisterValue pc{};
    pc.u8 = kCodeBase;
    b->engine.setRegister(aether::Register::PC, pc);
}

BRIDGE_API int aevm_is_finished(void *e)
{
    return static_cast<BridgeEngine *>(e)->finished ? 1 : 0;
}

BRIDGE_API int aevm_read_mem(void *e, uint64_t addr, uint8_t *out, size_t len)
{
    auto *b = static_cast<BridgeEngine *>(e);
    auto data = b->engine.readMemory(addr, len);
    if (data.empty())
        return -1;
    memcpy(out, data.data(), data.size());
    return 0;
}

BRIDGE_API void aevm_write_mem(void *e, uint64_t addr, const uint8_t *data, size_t len)
{
    auto *b = static_cast<BridgeEngine *>(e);
    b->engine.writeMemory(addr, std::span<const uint8_t>(data, len));
}

BRIDGE_API void aevm_set_trace_cb(void *e, TraceCb cb, void *user)
{
    auto *b = static_cast<BridgeEngine *>(e);
    b->traceCb = cb;
    b->traceUser = user;
    // 注册事件回调,把 AetherVM 事件转发为 trace 记录
    b->engine.registerCallback([b](aether::Event &ev) -> aether::EventResult {
        if (b->traceCb)
        {
            // [ADAPT] Event 为 variant;此处仅转发类型占位
            b->traceCb(4 /*EVENT*/, 0, "aether event", b->traceUser);
        }
        return aether::EventResult::Continue;
    });
}
