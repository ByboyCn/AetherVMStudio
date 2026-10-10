// AetherVMBridge.cpp — 把 AetherVM(C++)封装成 C ABI 动态库,供 AetherVMStudio (C#) P/Invoke。
//
// AetherVM 以 git 子模块形式位于 ../AetherVM,先用 ICPP 构建:
//   cd native/AetherVM && icpp build.cc
//   产物在 native/AetherVM/build-Release/install
// 然后:
//   cmake -S native -B native/build -DCMAKE_BUILD_TYPE=Release
//   cmake --build native/build --config Release
//
// 标有 [ADAPT] 的地方以你构建的 AetherVM 版本头文件为准。

#include <cstdint>
#include <cstring>
#include <span>
#include <string>
#include <vector>

#include "aether/AetherVM.h"
#include "aether/Register.h"

using TraceCb = void (*)(int kind, uint64_t addr, const char *text, void *user);

#if defined(_WIN32)
#define BRIDGE_API extern "C" __declspec(dllexport)
#else
#define BRIDGE_API extern "C" __attribute__((visibility("default")))
#endif

static constexpr uint64_t kCodeBase = 0x100000;

struct BridgeEngine
{
    aether::Machine machine;
    aether::BinaryEngine engine{&machine};
    TraceCb traceCb = nullptr;
    void *traceUser = nullptr;
    std::vector<uint8_t> code;
    bool finished = false;

    void emit(int kind, uint64_t addr, const std::string &text)
    {
        if (traceCb)
            traceCb(kind, addr, text.c_str(), traceUser);
    }
};

BRIDGE_API void *aevm_create(int arch)
{
    // [ADAPT] 如 BinaryEngine 需要按架构初始化(0=ARM64, 1=x86_64),在此处理
    (void)arch;
    return new (std::nothrow) BridgeEngine();
}

BRIDGE_API void aevm_destroy(void *e)
{
    delete static_cast<BridgeEngine *>(e);
}

static aether::Register regByName(const std::string &n, bool &ok)
{
    ok = true;
    if (n.rfind("x", 0) == 0)
    {
        int idx = std::stoi(n.substr(1));
        if (idx >= 0 && idx <= 30)
            return static_cast<aether::Register>(static_cast<int>(aether::Register::X0) + idx);
    }
    if (n == "pc" || n == "rip")
        return aether::Register::PC; // README: RIP = PC 别名
    if (n == "sp" || n == "rsp")
        return aether::Register::SP;
    // [ADAPT] x86_64 其余别名(rax/rbx/...)按需补充
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
    b->machine.setRegister(reg, aether::RegisterValue{value}); // [ADAPT] RegisterValue 构造形式
}

BRIDGE_API uint64_t aevm_get_reg(void *e, const char *name)
{
    auto *b = static_cast<BridgeEngine *>(e);
    bool ok = false;
    auto reg = regByName(name, ok);
    if (!ok)
        return 0;
    return b->machine.getRegister(reg).u64; // [ADAPT] RegisterValue 字段名
}

BRIDGE_API void aevm_load_code(void *e, const uint8_t *code, size_t len)
{
    auto *b = static_cast<BridgeEngine *>(e);
    b->code.assign(code, code + len);
    b->finished = false;
    b->machine.setRegister(aether::Register::PC, aether::RegisterValue{kCodeBase});
}

BRIDGE_API void aevm_run(void *e, int maxInsns)
{
    auto *b = static_cast<BridgeEngine *>(e);
    try
    {
        // [ADAPT] maxInsns 暂未使用;AetherVM 的事件回调里可通过 EventResult::Terminate 截断
        (void)maxInsns;
        b->engine.registerCallback([b](const aether::Event &ev) -> aether::EventResult {
            if (b->traceCb)
            {
                // [ADAPT] 从 Event variant 中取类型/地址/描述
                b->traceCb(4 /*Event*/, 0, "event", b->traceUser);
            }
            return aether::EventResult::Continue;
        });
        b->engine.execute(std::span<const uint8_t>(b->code));
        b->finished = true;
    }
    catch (const std::exception &ex)
    {
        b->emit(5 /*Error*/, kCodeBase, ex.what());
        b->finished = true;
    }
}

BRIDGE_API void aevm_step(void *e)
{
    // [ADAPT] AetherVM 无显式单步 API 时,以 1 条指令粒度执行
    aevm_run(e, 1);
}

BRIDGE_API void aevm_reset(void *e)
{
    auto *b = static_cast<BridgeEngine *>(e);
    b->finished = false;
    b->machine.setRegister(aether::Register::PC, aether::RegisterValue{kCodeBase});
}

BRIDGE_API int aevm_is_finished(void *e)
{
    return static_cast<BridgeEngine *>(e)->finished ? 1 : 0;
}

BRIDGE_API int aevm_read_mem(void *e, uint64_t addr, uint8_t *out, size_t len)
{
    auto *b = static_cast<BridgeEngine *>(e);
    // [ADAPT] 优先走 engine.readMemory;此处简化为 code 区直读
    uint64_t off = addr - kCodeBase;
    if (off + len > b->code.size())
        return -1;
    memcpy(out, b->code.data() + off, len);
    return 0;
}

BRIDGE_API void aevm_write_mem(void *e, uint64_t addr, const uint8_t *data, size_t len)
{
    auto *b = static_cast<BridgeEngine *>(e);
    uint64_t off = addr - kCodeBase;
    if (off + len <= b->code.size())
        memcpy(b->code.data() + off, data, len);
}

BRIDGE_API void aevm_set_trace_cb(void *e, TraceCb cb, void *user)
{
    auto *b = static_cast<BridgeEngine *>(e);
    b->traceCb = cb;
    b->traceUser = user;
}
