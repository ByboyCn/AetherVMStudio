# ChartEngine

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

图表内核，负责配置合并、处理管线、候选场景提交、绘制、命中测试、事件与 action。

## 说明

实例具有创建线程亲和性；公开操作除状态查询外都应在创建它的 UI 线程执行。

## 构造函数

### `ChartEngine(TCYM.UI.Chart.Core.ChartRegistry,TCYM.UI.Chart.Model.ChartTheme,TCYM.UI.Chart.Core.IChartMonotonicClock)`

使用指定 Registry、Theme 与共享单调时钟创建图表引擎。

| 参数 | 说明 |
| --- | --- |
| `registry` | 共享扩展注册表；为空时创建已装配内置模块的私有默认注册表。 |
| `theme` | 初始主题；引擎会立即克隆，之后不保留调用方对象。 |
| `monotonicClock` | 动画器与逐帧调度器共享的单调时钟；不能为 `null`。 |

### `ChartEngine(TCYM.UI.Chart.Core.ChartRegistry,TCYM.UI.Chart.Model.ChartTheme)`

创建图表引擎并绑定当前线程。

| 参数 | 说明 |
| --- | --- |
| `registry` | 共享扩展注册表；为空时创建已装配内置模块的私有默认注册表。 |
| `theme` | 初始主题；引擎会立即克隆，之后不保留调用方对象。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Diagnostics` | 获取最近一次构建及运行时回调产生的诊断集合。 |
| `EnableLargeBatchRasterCache` | 获取或设置是否对高密度纯色矩形批次启用纹理缓存；默认关闭。 |
| `IsDisposed` | 获取引擎是否已经释放，供 UI 宿主安全处理外部持有的引擎引用。 |
| `NeedsAnotherFrame` | 获取是否存在注册表变化、脏阶段、动画或逐帧任务，因而需要宿主请求下一帧。 |
| `Registry` | 获取此引擎使用的扩展注册表。 |
| `Version` | 获取成功完成的构建版本；失败或回滚的候选不会增加版本。 |

## 事件

| 名称 | 说明 |
| --- | --- |
| `ChartEvent` | 在图元命中产生鼠标、点击或全局离开事件时触发。 |
| `Finished` | 在一次非静默构建及其动画、逐帧工作全部稳定后触发。 |
| `Invalidated` | 引擎状态变化并需要宿主请求新帧时触发。 |
| `SemanticEvent` | 在非静默 action 处理器创建模块语义事件时触发。 |

## 方法

### `AppendData(Int32,TCYM.UI.Chart.Data.ChartDataTable)`

向指定系列的内联列布局表格追加逻辑数据项，对应 ECharts appendData 的基础语义。

| 参数 | 说明 |
| --- | --- |
| `seriesIndex` | 规范配置中的系列索引。 |
| `data` | 要追加的列布局表格行。 |

**说明：** 数据集绑定、行布局或非表格拓扑不支持此兼容入口。

### `CheckAccess`

检查当前线程是否为创建引擎的线程。

**返回：** 具有线程访问权时为 `true`。

### `Clear`

清空规范配置和当前交互状态，并安排完整重建。

### `ContainPixel(String,SkiaSharp.SKPoint)`

判断像素点是否位于指定坐标系内。

| 参数 | 说明 |
| --- | --- |
| `coordinateSystemId` | 已发布坐标系标识。 |
| `point` | 图表本地像素坐标。 |

**返回：** 坐标系存在且包含该点时为 `true`。

### `ContainSeries(TCYM.UI.Chart.Series.ChartSeriesContainQuery,SkiaSharp.SKPoint)`

判断内容区局部像素是否位于任一满足全部选择条件、且已发布包含能力的系列区域内。

| 参数 | 说明 |
| --- | --- |
| `query` | 至少包含一个 index、ID、name 或 type 条件的系列查询。 |
| `point` | 图表内容区局部像素坐标。 |

**返回：** 任一匹配系列包含该点时为 `true`；否则为假。

**说明：** 该查询只消费系列模块发布的不可变 provider，不执行场景命中，也不会伪造数据项事件。

### `ConvertFromPixel(String,SkiaSharp.SKPoint)`

把当前图表内容区像素坐标转换为数据坐标。

| 参数 | 说明 |
| --- | --- |
| `coordinateSystemId` | 已发布坐标系标识。 |
| `point` | 图表本地像素坐标。 |

**返回：** 坐标系解释后的数据值。

### `ConvertToPixel(String,TCYM.UI.Chart.CoordinateSystems.ChartCoordinateValue)`

把数据坐标转换为当前图表内容区像素坐标。

| 参数 | 说明 |
| --- | --- |
| `coordinateSystemId` | 已发布坐标系标识。 |
| `value` | 数据坐标值。 |

**返回：** 图表本地像素坐标。

### `CreateWithClock(TCYM.UI.Chart.Core.ChartRegistry,TCYM.UI.Chart.Core.IChartMonotonicClock)`

使用指定 Registry 与单调时钟创建图表引擎。

| 参数 | 说明 |
| --- | --- |
| `registry` | 共享扩展注册表；为空时创建已装配内置模块的私有默认注册表。 |
| `monotonicClock` | 可控或平台单调时钟；不能为 `null`。 |

**返回：** 绑定调用线程和指定运行时依赖的新引擎。

**说明：** 命名工厂保留可控时钟能力，同时避免与兼容构造
`new ChartEngine(registry, null)` 形成源码重载歧义。

### `CreateWithClock(TCYM.UI.Chart.Core.IChartMonotonicClock)`

使用指定单调时钟创建默认 Registry 和 Theme 的图表引擎。

| 参数 | 说明 |
| --- | --- |
| `monotonicClock` | 可控或平台单调时钟；不能为 `null`。 |

**返回：** 绑定调用线程、默认 Registry 与默认 Theme 的新引擎。

**说明：** 时钟入口使用命名工厂而不是单参数构造函数，避免与兼容构造
`new ChartEngine(null)` 形成无法消解的空引用重载。

### `DispatchAction(TCYM.UI.Chart.Core.ChartAction)`

把 action 分派给同类型处理器，并按返回标志使管线失效。

| 参数 | 说明 |
| --- | --- |
| `action` | 要执行的 action。 |

**说明：** 未注册或处理失败会写入诊断而不会抛出扩展异常；`Silent` 只抑制语义事件。

### `Dispose`

取消 owner 绑定运行时工作，释放视图、场景、制品和调度服务。

**说明：** 可在所属线程重复调用；首次调用后其他引擎操作将抛出已释放异常。

### `DoubleClick(Single,Single,TCYM.UI.Events.UIMouseButton,TCYM.UI.Events.UIKeyModifiers,Int64,TCYM.UI.Events.UIPointerDeviceType)`

处理双击并分派控制器及命中图元事件。

| 参数 | 说明 |
| --- | --- |
| `x` | 图表本地横坐标。 |
| `y` | 图表本地纵坐标。 |
| `button` | 触发双击的鼠标按键。 |
| `modifiers` | 键盘修饰键。 |
| `pointerId` | 宿主提供的指针标识。 |
| `deviceType` | 宿主报告的指针设备类型。 |

**返回：** 控制器或图元处理了事件，或当前位置命中图元时为 `true`。

### `DoubleClick(Single,Single,TCYM.UI.Events.UIMouseButton,TCYM.UI.Events.UIKeyModifiers,Int64)`

处理双击并分派控制器及命中图元事件。

| 参数 | 说明 |
| --- | --- |
| `x` | 图表本地横坐标。 |
| `y` | 图表本地纵坐标。 |
| `button` | 触发双击的鼠标按键。 |
| `modifiers` | 键盘修饰键。 |
| `pointerId` | 宿主提供的指针标识。 |

**返回：** 控制器或图元处理了事件，或当前位置命中图元时为 `true`。

**说明：** 保留 M1.6 之前的精确元数据签名，供已编译调用方继续绑定。

### `GetOption`

获取规范用户配置的独立副本。

**返回：** 不包含处理器临时修改、可由调用方安全修改的配置副本。

**说明：** 标签中的 `SKTypeface` 遵循借用契约并与引擎共享；不得通过返回副本释放该字体，
且须保证它在引擎仍可能渲染时保持有效。

### `GetTheme`

获取规范主题的独立副本。

**返回：** 可由调用方安全修改的主题副本。

**说明：** `SKTypeface` 遵循借用契约并与引擎共享；不得通过返回副本释放该字体，
且须保证它在引擎仍可能渲染时保持有效。

### `PointerCancel(Single,Single,Int64,TCYM.UI.Events.UIPointerDeviceType)`

取消当前指针或拖动状态，供 TouchCancel、窗口失焦和捕获丢失使用。

| 参数 | 说明 |
| --- | --- |
| `x` | 取消时的图表本地横坐标。 |
| `y` | 取消时的图表本地纵坐标。 |
| `pointerId` | 被取消的指针标识。 |
| `deviceType` | 宿主报告的指针设备类型。 |

**返回：** 曾存在交互状态，或控制器/事件处理器处理了取消时为 `true`。

### `PointerCancel(Single,Single,Int64)`

取消当前指针或拖动状态，供 TouchCancel、窗口失焦和捕获丢失使用。

| 参数 | 说明 |
| --- | --- |
| `x` | 取消时的图表本地横坐标。 |
| `y` | 取消时的图表本地纵坐标。 |
| `pointerId` | 被取消的指针标识。 |

**返回：** 曾存在交互状态，或控制器/事件处理器处理了取消时为 `true`。

**说明：** 保留 M1.6 之前的精确元数据签名，供已编译调用方继续绑定。

### `PointerDown(Single,Single,TCYM.UI.Events.UIMouseButton,TCYM.UI.Events.UIKeyModifiers,Int64,TCYM.UI.Events.UIPointerDeviceType)`

处理指针按下并记录用于点击判定的命中目标。

| 参数 | 说明 |
| --- | --- |
| `x` | 图表本地横坐标。 |
| `y` | 图表本地纵坐标。 |
| `button` | 按下的鼠标按键。 |
| `modifiers` | 键盘修饰键。 |
| `pointerId` | 宿主提供的指针标识。 |
| `deviceType` | 宿主报告的指针设备类型。 |

**返回：** 控制器或图元处理了事件，或按下位置命中图元时为 `true`。

### `PointerDown(Single,Single,TCYM.UI.Events.UIMouseButton,TCYM.UI.Events.UIKeyModifiers,Int64)`

处理指针按下并记录用于点击判定的命中目标。

| 参数 | 说明 |
| --- | --- |
| `x` | 图表本地横坐标。 |
| `y` | 图表本地纵坐标。 |
| `button` | 按下的鼠标按键。 |
| `modifiers` | 键盘修饰键。 |
| `pointerId` | 宿主提供的指针标识。 |

**返回：** 控制器或图元处理了事件，或按下位置命中图元时为 `true`。

**说明：** 保留 M1.6 之前的精确元数据签名，供已编译调用方继续绑定。

### `PointerLeave(Single,Single,Int64,TCYM.UI.Events.UIPointerDeviceType)`

处理指针离开视口，清除 hover 并派发 mouseout 与 globalout。

| 参数 | 说明 |
| --- | --- |
| `x` | 最后已知的图表本地横坐标。 |
| `y` | 最后已知的图表本地纵坐标。 |
| `pointerId` | 宿主提供的指针标识。 |
| `deviceType` | 宿主报告的指针设备类型。 |

### `PointerLeave(Single,Single,Int64)`

处理指针离开视口，清除 hover 并派发 mouseout 与 globalout。

| 参数 | 说明 |
| --- | --- |
| `x` | 最后已知的图表本地横坐标。 |
| `y` | 最后已知的图表本地纵坐标。 |
| `pointerId` | 宿主提供的指针标识。 |

**说明：** 保留 M1.6 之前的精确元数据签名，供已编译调用方继续绑定。

### `PointerMove(Single,Single,TCYM.UI.Events.UIKeyModifiers,Int64,TCYM.UI.Events.UIPointerDeviceType)`

处理指针移动，更新 hover 状态并分派控制器及图元事件。

| 参数 | 说明 |
| --- | --- |
| `x` | 图表本地横坐标。 |
| `y` | 图表本地纵坐标。 |
| `modifiers` | 键盘修饰键。 |
| `pointerId` | 宿主提供的指针标识。 |
| `deviceType` | 宿主报告的指针设备类型。 |

**返回：** 命中、hover 状态或事件处理结果表明宿主应继续处理该输入时为 `true`。

### `PointerMove(Single,Single,TCYM.UI.Events.UIKeyModifiers,Int64)`

处理指针移动，更新 hover 状态并分派控制器及图元事件。

| 参数 | 说明 |
| --- | --- |
| `x` | 图表本地横坐标。 |
| `y` | 图表本地纵坐标。 |
| `modifiers` | 键盘修饰键。 |
| `pointerId` | 宿主提供的指针标识。 |

**返回：** 命中、hover 状态或事件处理结果表明宿主应继续处理该输入时为 `true`。

**说明：** 保留 M1.6 之前的精确元数据签名，供已编译调用方继续绑定。

### `PointerUp(Single,Single,TCYM.UI.Events.UIMouseButton,TCYM.UI.Events.UIKeyModifiers,Int64,TCYM.UI.Events.UIPointerDeviceType)`

处理指针释放，必要时生成点击事件并释放该指针的捕获状态。

| 参数 | 说明 |
| --- | --- |
| `x` | 图表本地横坐标。 |
| `y` | 图表本地纵坐标。 |
| `button` | 释放的鼠标按键。 |
| `modifiers` | 键盘修饰键。 |
| `pointerId` | 宿主提供的指针标识。 |
| `deviceType` | 宿主报告的指针设备类型。 |

**返回：** 控制器或图元处理了事件，释放位置命中图元，或形成点击时为 `true`。

### `PointerUp(Single,Single,TCYM.UI.Events.UIMouseButton,TCYM.UI.Events.UIKeyModifiers,Int64)`

处理指针释放，必要时生成点击事件并释放该指针的捕获状态。

| 参数 | 说明 |
| --- | --- |
| `x` | 图表本地横坐标。 |
| `y` | 图表本地纵坐标。 |
| `button` | 释放的鼠标按键。 |
| `modifiers` | 键盘修饰键。 |
| `pointerId` | 宿主提供的指针标识。 |

**返回：** 控制器或图元处理了事件，释放位置命中图元，或形成点击时为 `true`。

**说明：** 保留 M1.6 之前的精确元数据签名，供已编译调用方继续绑定。

### `PointerWheel(Single,Single,Int32,TCYM.UI.Events.UIKeyModifiers,Int64,TCYM.UI.Events.UIPointerDeviceType)`

处理滚轮输入并分派控制器及命中图元事件。

| 参数 | 说明 |
| --- | --- |
| `x` | 图表本地横坐标。 |
| `y` | 图表本地纵坐标。 |
| `delta` | 宿主滚轮增量。 |
| `modifiers` | 键盘修饰键。 |
| `pointerId` | 宿主提供的指针标识。 |
| `deviceType` | 宿主报告的指针设备类型。 |

**返回：** 控制器或图元处理了事件，或当前位置命中图元时为 `true`。

### `PointerWheel(Single,Single,Int32,TCYM.UI.Events.UIKeyModifiers,Int64)`

处理滚轮输入并分派控制器及命中图元事件。

| 参数 | 说明 |
| --- | --- |
| `x` | 图表本地横坐标。 |
| `y` | 图表本地纵坐标。 |
| `delta` | 宿主滚轮增量。 |
| `modifiers` | 键盘修饰键。 |
| `pointerId` | 宿主提供的指针标识。 |

**返回：** 控制器或图元处理了事件，或当前位置命中图元时为 `true`。

**说明：** 保留 M1.6 之前的精确元数据签名，供已编译调用方继续绑定。

### `Prepare`

立即构建所有待处理的规范化、数据、布局、视觉与场景阶段，但不绘制画布，也不推进动画。

**说明：** 适合在页面预加载或即将显示前把首次构建成本移出交互帧。线程亲和性和重入限制与坐标查询一致。

### `Render(SkiaSharp.SKCanvas)`

确保最新状态已构建，推进一帧动画和逐帧任务，并绘制完整场景。

| 参数 | 说明 |
| --- | --- |
| `canvas` | 目标 Skia 画布。 |

**说明：** 当构建与全部运行时工作稳定后，非静默更新会在方法结束前触发 `Finished`。

### `Resize(Single,Single)`

更新图表内容区尺寸并使布局失效。

| 参数 | 说明 |
| --- | --- |
| `width` | 宽度；非有限值和负值按零处理。 |
| `height` | 高度；非有限值和负值按零处理。 |

### `SetImageResolver(TCYM.UI.Chart.Rendering.Symbols.IChartImageResolver)`

替换此 Engine 借用的 `image://` 图片解析器，并安排现有视图重建。

| 参数 | 说明 |
| --- | --- |
| `imageResolver` | 新解析器；为 `null` 时禁用图片解析。其生命周期始终由调用方管理，<br />Engine 在替换或释放时都不会释放它。 |

### `SetOption(TCYM.UI.Chart.Model.ChartOption,TCYM.UI.Chart.Model.ChartSetOptionOptions)`

按 ECharts 风格合并或替换规范配置，并使相应管线阶段失效。

| 参数 | 说明 |
| --- | --- |
| `option` | 要提交的配置；引擎不会保留该对象。 |
| `options` | 合并、替换、静默和延迟构建选项。 |

**说明：** 除非启用延迟更新，否则此方法会立即尝试构建；失败候选保持最后一次成功状态。

### `SetTheme(TCYM.UI.Chart.Model.ChartTheme)`

替换规范主题并使布局及后续阶段失效。

| 参数 | 说明 |
| --- | --- |
| `theme` | 新主题；引擎会保存其副本。 |

### `VerifyAccess`

验证当前线程具有引擎访问权。
