# UIDispatcher

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

UI 线程调度器。 <para> 记录 UI（主事件循环）线程，并提供线程安全的动作投递队列， 使得任意后台线程对 UI 元素的修改（如 AddClass / RemoveClass / 设置 ClassName） 能够自动切回 UI 线程串行执行，避免跨线程并发修改 UI 树导致的崩溃或数据竞争。 </para>

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `HasUIThread` | `bool` | 是否已经确定了 UI 线程（主循环已启动）。 未确定时，调用方应直接同步执行以保持设计时 / 单元测试等场景的原有行为。 |
| `IsOnUIThread` | `bool` | 当前调用是否运行在 UI 线程上。未确定 UI 线程时返回 false。 |

## 方法

### SetUIThread()

```csharp
void SetUIThread()
```

将当前线程标记为 UI 线程，并安装用于恢复异步 continuation 的 UI <see cref="SynchronizationContext"/>。主事件循环应优先使用 <see cref="EnterUIThread"/>。

### EnterUIThread()

```csharp
IDisposable EnterUIThread()
```

将当前线程临时设为 UI 线程，并在返回的作用域释放时恢复此前的线程标识与 <see cref="SynchronizationContext"/>。主事件循环应优先使用此入口。

**返回：** 在释放时排空待处理工作并恢复原线程上下文的作用域。

### Invoke(Action)

```csharp
void Invoke(Action action)
```

在 UI 线程执行动作：若当前已在 UI 线程（或尚未确定 UI 线程）则同步执行， 否则投递到 UI 线程队列异步执行。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `action` | `Action` | 要在 UI 线程执行的动作。 |

### InvokeAsync(Action)

```csharp
Task InvokeAsync(Action action)
```

在 UI 线程执行动作，并返回表示动作完成的任务。 已在 UI 线程或主循环尚未建立时会直接执行，避免把 UI 线程自身排队后造成死锁。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `action` | `Action` | 要在 UI 线程执行的同步动作。 |

**返回：** 动作执行完成、取消或失败后结束的任务。

### InvokeAsync(Func<Task>)

```csharp
Task InvokeAsync(Func<Task> action)
```

在 UI 线程开始并完整等待异步动作。动作中的 await 默认通过 UI SynchronizationContext 回到 UI 线程，而主事件循环本身不会被同步阻塞。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `action` | `Func<Task>` | 要在 UI 线程开始执行并等待完成的异步动作。 |

**返回：** 异步动作执行完成、取消或失败后结束的任务。

### InvokeAsync(Func<T>)

```csharp
Task<T> InvokeAsync(Func<T> action)
```

在 UI 线程执行同步函数并异步返回结果。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `action` | `Func<T>` | 要在 UI 线程执行的同步函数。 |

**返回：** 包含函数返回值，或表示取消、失败的任务。

### InvokeAsync(Func<Task<T>>)

```csharp
Task<T> InvokeAsync(Func<Task<T>> action)
```

在 UI 线程开始并完整等待异步函数，然后返回其结果。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `action` | `Func<Task<T>>` | 要在 UI 线程开始执行的异步函数。 |

**返回：** 包含异步函数返值，或表示取消、失败的任务。

### Post(Action)

```csharp
void Post(Action action)
```

UI 线程存在时将动作投递到调度队列，并唤醒主事件循环以尽快执行。 主循环尚未建立或已完成退出交接时，动作会在当前调用线程立即执行。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `action` | `Action` | 要在 UI 线程执行的动作。 |

### Drain()

```csharp
void Drain()
```

执行队列中所有待处理动作。仅应由 UI 线程的主事件循环调用。
