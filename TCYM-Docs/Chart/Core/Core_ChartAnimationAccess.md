# ChartAnimationAccess

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

向处理器和持久视图公开的 owner 作用域动画 API。该门面不提供全局推进或清空操作；
仅能在引擎执行所属回调，或动画时钟恢复同一 owner 的回调期间添加动画。

## 方法

### `Add(Int32,Action{Single},Int32,String,Action)`

为当前回调 owner 添加补间动画。

| 参数 | 说明 |
| --- | --- |
| `duration` | 动画持续时间（毫秒）。 |
| `update` | 接收缓动进度的逐帧回调。 |
| `delay` | 开始前的延迟（毫秒）。 |
| `easing` | 缓动函数名称。 |
| `completed` | 正常完成时调用的可选回调。 |

**返回：** 可用于查询或取消动画的补间对象。
