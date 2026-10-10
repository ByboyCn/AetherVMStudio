# ChartPointerEvent

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

封装传给图表交互控制器的原始指针事件及命中信息。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Button` | 获取参与事件的鼠标按键。 |
| `CancelReason` | 获取 Cancel 事件的来源；非 Cancel 事件固定为 `None`。 |
| `CapturePointer` | 获取或设置是否请求引擎捕获当前指针。 |
| `DeviceType` | 获取宿主报告的指针设备类型。 |
| `Handled` | 获取或设置事件是否已由控制器处理。 |
| `HitElement` | 获取命中的场景图元；未命中时为 `null`。 |
| `HitResult` | 获取完整命中结果；未命中时为 `null`。 |
| `IsClick` | 获取本次释放是否与同一指针先前按下的同一命中身份形成真实点击。<br />仅 `Up` 可能为 `true`；控制器可据此<br />排队点击 action，而无需在共享 Registry 实例中保存按压状态。 |
| `IsInsideViewport` | 获取事件坐标是否位于当前视口内。 |
| `IsViewportClick` | 获取本次释放是否与同一指针先前按下的同一视口目标形成控制器点击。与<br />`IsClick` 不同，按下和释放都位于视口且都未命中图元时也可为真，供 axis Tooltip<br />等图表级控制器处理空白绘图区；公开图元 Click 事件仍只使用 `IsClick`。 |
| `Modifiers` | 获取事件发生时的键盘修饰键。 |
| `PointerId` | 获取宿主提供的指针标识。 |
| `ReleasePointer` | 获取或设置是否请求引擎释放当前指针捕获。 |
| `SuppressClick` | 获取或设置是否把当前物理按压序列标记为不应产生后续 Click。控制器可在 Move 或 Up 阶段<br />设置此值；引擎会跨重建保留标记，并在物理 Up、真实 Cancel 或下一次 Down 时清除，避免后续<br />控制器和公开图元 Click 把拖动误判为点击。 |
| `TerminatesHover` | 获取当前 Leave/Cancel 是否拥有并终止图表的全局 hover 投影。多指针场景中，非 hover<br />所有者仍会收到完整控制器生命周期，但不得据此隐藏由另一指针拥有的 Tooltip。 |
| `Type` | 获取事件类型。 |
| `WheelDelta` | 获取滚轮增量；非滚轮事件为零。 |
| `X` | 获取相对于图表视口的横坐标。 |
| `Y` | 获取相对于图表视口的纵坐标。 |
