# ChartBuildContext

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

表示一次配置到场景构建过程中的回调上下文，并按处理阶段限制模型、数据、制品和渲染写权限。

## 说明

上下文及其写入门面只在创建它们的当前回调作用域有效；异步或保留后的回调只能操作自己已持有的图元。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Animator` | 获取绑定到当前引擎和回调 owner 的动画门面。 |
| `Artifacts` | 获取跨阶段共享的强类型制品门面。候选写权限绑定到精确处理器调用；作用域外读取返回<br />隔离的已发布快照，任何修改都会被拒绝。 |
| `Commands` | 获取安全排队 action 或请求宿主重绘的精确 invocation 命令门面。 |
| `CoordinateSystems` | 获取本上下文当前可见坐标系的只读字典，键为坐标系标识。 |
| `Diagnostics` | 获取当前构建共享的诊断收集器。 |
| `FrameScheduler` | 获取绑定到当前引擎和回调 owner 的非补间逐帧任务门面。 |
| `ImageResolver` | 获取当前 Engine 借用的宿主图片解析器；上下文及扩展不得释放该实例。 |
| `IsDataReady` | 获取 Normalize 是否已完成且数据运行时可用。 |
| `Labels` | 获取当前 view 回调的事务式标签提交门面。门面只能在创建它的 Engine、owner、render invocation<br />与 owner-update 代次内创建 host 或提交 descriptor。 |
| `Option` | 获取当前回调使用的有效配置快照。它与 `GetOption` 返回的规范配置隔离。 |
| `Registry` | 获取只读扩展注册表视图。 |
| `RenderTarget` | 获取当前处理器或视图回调的作用域渲染目标。 |
| `RuntimeState` | 获取绑定当前 Engine、owner 与 invocation 的组件运行时状态只读门面。 |
| `RuntimeStateMutation` | 获取当前 action 候选事务的运行时状态写门面；其他回调或延迟回调访问会失败。 |
| `SeriesData` | 获取本次构建中所有系列的不可变原始存储和隔离处理视图。数据处理器应通过此运行时<br />处理数据，而不是修改 `Option`。 |
| `Theme` | 获取当前回调使用的主题快照；修改它不会回写引擎的规范主题。 |
| `Viewport` | 获取当前图表内容区，以图表本地像素表示。 |

## 方法

### `Add()`

把图元添加到当前回调的作用域渲染目标。

| 参数 | 说明 |
| --- | --- |
| `element` | 要添加的图元。 |

**返回：** 传入的图元，便于继续配置。

### `AddCoordinateSystem(TCYM.UI.Chart.CoordinateSystems.IChartCoordinateSystem)`

向当前布局候选注册一个坐标系。

| 参数 | 说明 |
| --- | --- |
| `coordinateSystem` | 具有唯一非空标识的坐标系。 |

### `GetPaletteColor(Int32)`

从有效配置或主题调色板中循环取色。

| 参数 | 说明 |
| --- | --- |
| `index` | 可为任意整数的颜色索引。 |

**返回：** 调色板颜色；两级调色板均为空时返回透明色。

### `GetSeriesData(Int32)`

按有效配置索引获取系列数据运行时。

| 参数 | 说明 |
| --- | --- |
| `seriesIndex` | 系列索引。 |

**返回：** 对应系列的原始存储、绑定和处理视图。

### `ResolveData(TCYM.UI.Chart.Model.ChartSeriesOption)`

返回原始表格的兼容副本。修改返回对象不会影响不可变原始快照或其他系列的处理视图。

| 参数 | 说明 |
| --- | --- |
| `series` | 要解析的系列配置。 |

**返回：** 独立表格副本；数据源未解析或不是表格数据时为 `null`。

### `ResolveDataView(TCYM.UI.Chart.Model.ChartSeriesOption)`

解析系列当前的处理数据视图。

| 参数 | 说明 |
| --- | --- |
| `series` | 要解析的系列配置。 |

**返回：** 已解析的数据视图；数据未准备或系列不匹配时为 `null`。

### `TryGetCoordinateSystem(String,TCYM.UI.Chart.CoordinateSystems.IChartCoordinateSystem@)`

尝试获取当前上下文中的坐标系。

| 参数 | 说明 |
| --- | --- |
| `id` | 坐标系标识。 |
| `coordinateSystem` | 找到时返回坐标系快照。 |

**返回：** 找到时为 `true`。

### `TryGetSeriesData(Int32,TCYM.UI.Chart.Data.ChartSeriesDataRuntime@)`

按有效配置索引尝试获取系列数据运行时。

| 参数 | 说明 |
| --- | --- |
| `seriesIndex` | 系列索引。 |
| `data` | 找到时返回系列数据运行时。 |

**返回：** 数据运行时可用且索引有效时为 `true`。

### `TryGetSeriesData(TCYM.UI.Chart.Model.ChartSeriesOption,TCYM.UI.Chart.Data.ChartSeriesDataRuntime@)`

按系列配置的规范运行时身份尝试获取数据运行时。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前有效配置中的系列节点或其保留身份的副本。 |
| `data` | 找到时返回系列数据运行时。 |

**返回：** 找到匹配系列时为 `true`。
