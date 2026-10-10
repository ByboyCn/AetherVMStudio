# UIChart

> **类型**：class　**命名空间**：`TCYM.UI.Chart`　**Chart 版本**：`0.1.1.25`

## 概述

在 `UIElement` 场景树中承载轻量图表内核的控件。

## 说明

控件可像普通 `UIElement` 一样加入父元素并继续承载用户子元素；图表自身的标签、图例和提示框
由内部轻量场景树绘制，不会为每个图元创建 UI 元素。

`UIChart` 拥有其 `Engine`、原生绘制资源以及注册表订阅。
普通移除子元素会保留控件以便再次挂载；永久移除时应调用 `RemoveChildAndDispose`
或显式调用 `Dispose`。

## 构造函数

### `UIChart`

使用独立的默认注册表和默认主题初始化图表控件。

### `UIChart(TCYM.UI.Chart.Core.ChartRegistry,TCYM.UI.Chart.Model.ChartTheme)`

使用指定注册表和主题初始化图表控件。

| 参数 | 说明 |
| --- | --- |
| `registry` | 组件、系列、坐标系及处理器的注册表；其生命周期由调用方管理。 |
| `theme` | 初始主题；为 `null` 时使用默认主题。内核会保留主题快照。 |

**说明：** 控件及其内核必须从创建它们的 UI 线程访问。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Diagnostics` | 获取最近一次构建及后续清理过程使用的实时诊断集合。 |
| `Engine` | 获取此控件拥有的图表内核。可用于高级查询和注册，但其生命周期由 `UIChart` 管理；<br />调用方不应单独释放它。 |
| `Registry` | 获取内核正在使用的注册表。 |

## 事件

| 名称 | 说明 |
| --- | --- |
| `ChartEvent` | 当指针交互命中图表元素并产生底层图表事件时发生。 |
| `Finished` | 当当前构建、动画和调度帧均已完成时发生。 |
| `SemanticEvent` | 当图例、数据缩放或选择等 action 产生高层语义结果时发生。 |

## 方法

### `AppendData(Int32,TCYM.UI.Chart.Data.ChartDataTable)`

向指定系列追加按行组织的数据，并从规范化阶段重新派生有效模型后构建图表。

| 参数 | 说明 |
| --- | --- |
| `seriesIndex` | 目标系列在当前选项中的从零开始索引。 |
| `data` | 要追加的数据表；当前契约要求列布局。 |

### `Clear`

清空当前选项、交互命中和场景内容，并请求重新绘制空图表。

### `ContainPixel(String,SkiaSharp.SKPoint)`

判断内容区宿主局部布局像素点是否位于指定坐标系内。

| 参数 | 说明 |
| --- | --- |
| `coordinateSystemId` | 构建上下文中的坐标系标识符。 |
| `point` | 以内容区左上角为原点、已应用布局 DPI 的宿主坐标。 |

**返回：** 坐标系存在且包含该点时为 `true`；否则为 `false`。

### `ContainSeries(TCYM.UI.Chart.Series.ChartSeriesContainQuery,SkiaSharp.SKPoint)`

判断内容区局部像素是否位于任一满足查询条件、且已发布包含能力的系列区域内。

| 参数 | 说明 |
| --- | --- |
| `query` | 至少包含一个 index、ID、name 或 type 条件的系列查询。 |
| `point` | 以内容区左上角为原点、已应用布局 DPI 的宿主坐标。 |

**返回：** 任一匹配系列包含该点时为 `true`；否则为假。

**说明：** 系列包含查询独立于数据项精确命中，不会产生 Click 或 hover 事件。

### `ConvertFromPixel(String,SkiaSharp.SKPoint)`

把图表内容区的宿主局部布局像素坐标转换为数据坐标。

| 参数 | 说明 |
| --- | --- |
| `coordinateSystemId` | 构建上下文中的坐标系标识符。 |
| `point` | 以内容区左上角为原点、已应用布局 DPI 的宿主坐标。 |

**返回：** 由指定坐标系解释的数据坐标。

### `ConvertToPixel(String,TCYM.UI.Chart.CoordinateSystems.ChartCoordinateValue)`

把数据坐标转换为图表内容区的宿主局部布局像素坐标。

| 参数 | 说明 |
| --- | --- |
| `coordinateSystemId` | 构建上下文中的坐标系标识符。 |
| `value` | 要转换的数据坐标。 |

**返回：** 以内容区左上角为原点、已应用布局 DPI 的宿主坐标。

### `DispatchAction(TCYM.UI.Chart.Core.ChartAction)`

向内核分派交互 action，并请求重新绘制可能发生的状态变化。

| 参数 | 说明 |
| --- | --- |
| `action` | 要执行的 action。 |

**说明：** `ChartShowTipAction` 的显式 X/Y 使用内容区宿主布局像素；控件会在进入内核前转换为逻辑像素。

### `Dispose`

释放图表内核、原生场景资源和事件订阅。

**说明：** 必须在创建内核的 UI 线程调用，且不能从构建、渲染或扩展回调中重入。
若线程或重入验证失败，释放会抛出异常并保留宿主状态，以便稍后在正确边界重试；重复成功释放是安全的。

### `GetOption`

获取当前规范图表选项的独立副本。

**返回：** 可由调用方安全修改、且不会直接改变当前图表的选项副本。

### `HasActiveAnimation`

由 UI 更新阶段请求连续帧，避免绘制中 MarkDirty 导致工作线程永远收不到动画帧。

### `Layout(Single,Single,Single,Single)`

### `Measure(Single,Single)`

### `OnMouseEvent(TCYM.UI.Events.UIMouseEvent)`

**说明：** 鼠标滚轮、双击和离开事件使用完整屏幕到局部逆变换；按下、移动和抬起事件的窗口坐标会短暂缓存，
供随后到达的兼容指针回调恢复旋转或缩放后的准确内容区坐标。

### `OnPointerDown(Single,Single)`

**说明：** 将元素局部坐标扣除边框和内边距，再去除布局 DPI 后转交给图表内核。

### `OnPointerMove(Single,Single)`

**说明：** 将元素局部坐标扣除边框和内边距，再去除布局 DPI 后转交给图表内核。

### `OnPointerUp(Single,Single)`

**说明：** 将元素局部坐标扣除边框和内边距，再去除布局 DPI 后转交给图表内核。

### `OnTouchEvent(TCYM.UI.Events.UITouchEvent)`

**说明：** 基类指针或触摸订阅者优先处理事件；普通阶段被消费后不再调用内核。TouchCancel 始终完成
已建立的主触点配对；已消费的 TouchEnd 也会以 Cancel 收口而不产生 Click，防止订阅者在序列
中途接管后留下旧 touchId。没有新坐标时使用最近一次主触点坐标完成清理。

### `Prepare`

按当前控件内容区尺寸提前构建图表场景，但不执行绘制或推进动画。

**说明：** 可在路由预加载等 UI 空闲阶段调用，以降低首次可见帧的构建延迟。

### `SetImageResolver(TCYM.UI.Chart.Rendering.Symbols.IChartImageResolver)`

替换此控件内核借用的 `image://` 图片解析器，并请求重建及重绘。

| 参数 | 说明 |
| --- | --- |
| `imageResolver` | 新解析器；为 `null` 时禁用图片解析。控件不会取得或释放其所有权。 |

### `SetOption(TCYM.UI.Chart.Model.ChartOption,TCYM.UI.Chart.Model.ChartSetOptionOptions)`

按指定更新策略合并或替换图表选项，并请求重新绘制。

| 参数 | 说明 |
| --- | --- |
| `option` | 要应用的图表选项。 |
| `options` | 合并、延迟构建和静默事件等更新策略；为 `null` 时使用默认策略。 |

**说明：** 内核保留选项快照；后续修改传入对象不会直接改变已提交状态。

### `SetTheme(TCYM.UI.Chart.Model.ChartTheme)`

替换当前主题快照，并请求从布局阶段重新构建图表。

| 参数 | 说明 |
| --- | --- |
| `theme` | 新的主题。 |

### `Update(Single)`

在录制之前处理内核上一帧产生的重绘请求，保持冻结帧版本稳定。
