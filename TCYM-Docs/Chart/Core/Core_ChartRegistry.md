# ChartRegistry

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

管理处理器、视图、渲染器、坐标系、action 与交互控制器的注册。
修改操作是线程安全的：每次有效修改先在锁内提交递增版本，再在修改线程同步触发
`Changed`。并发通知可能乱序到达，订阅者合并工作时应以事件携带的版本为准。
多项官方或自定义模块应使用
`RegisterModule`，避免分离查询和写入造成竞态。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Version` | 获取最近一次有效修改提交后的单调递增版本。 |

## 事件

| 名称 | 说明 |
| --- | --- |
| `Changed` | 在修改完成提交后触发。订阅者彼此隔离：一个订阅者的异常不会阻止其他订阅者运行。 |

## 方法

### `RegisterAction(TCYM.UI.Chart.Core.IChartActionHandler,Boolean)`

注册 action 处理器。

| 参数 | 说明 |
| --- | --- |
| `handler` | 要注册的处理器。 |
| `replace` | 同类型项存在时是否替换。 |

**返回：** 当前注册表。

### `RegisterComponent(TCYM.UI.Chart.Core.IChartComponentRenderer,Boolean)`

注册旧式组件渲染器。

| 参数 | 说明 |
| --- | --- |
| `renderer` | 要注册的渲染器。 |
| `replace` | 同名项存在时是否替换。 |

**返回：** 当前注册表。

### `RegisterComponentView(TCYM.UI.Chart.Core.IChartComponentViewFactory,Boolean)`

注册组件持久视图工厂。

| 参数 | 说明 |
| --- | --- |
| `factory` | 要注册的工厂。 |
| `replace` | 同名项存在时是否替换。 |

**返回：** 当前注册表。

### `RegisterCoordinateSystem(TCYM.UI.Chart.CoordinateSystems.IChartCoordinateSystemFactory,Boolean)`

注册坐标系工厂。

| 参数 | 说明 |
| --- | --- |
| `factory` | 要注册的工厂。 |
| `replace` | 同名项存在时是否替换。 |

**返回：** 当前注册表。

### `RegisterInteractionController(TCYM.UI.Chart.Core.IChartInteractionController)`

注册交互控制器；重复注册同一实例不会产生修改。

| 参数 | 说明 |
| --- | --- |
| `controller` | 要注册的控制器。 |

**返回：** 当前注册表。

### `RegisterModule(String,Action{TCYM.UI.Chart.Core.ChartModuleRegistration})`

以稳定模块键原子注册一组处理器、View、渲染器、坐标系、校验器、action 与 controller。

| 参数 | 说明 |
| --- | --- |
| `moduleKey` | 在当前注册表内永久标识此模块的非空键；成功提交后不能用同一键再次装配。 |
| `configure` | 在注册表锁外完整构造模块候选的同步回调。回调结束后配置立即冻结。 |

**返回：** 当前注册表，便于继续链式装配。

**说明：** 配置及所有公开属性先在锁外冻结；随后在同一个注册表锁内完成模块键、处理器稳定键和所有自然键的
全量预检，并以 copy-on-write 一次交换完整状态。重复模块、任何其他键冲突、配置异常或
候选构建异常都不会留下部分注册。
整个模块作为一个版本事务提交，并通过一条 `Changed` 批次通知在锁外发布；
通知的 `Entries` 包含全部实际注册项。通知发出前
整个模块已经可见，因此调用方不需要也不应通过一组 `TryGet*` 自行实现预检。
配置回调应只填充传入的 `ChartModuleRegistration`；它主动执行的其他注册表修改
是独立事务，不属于本模块的回滚范围。

### `RegisterProcessor(TCYM.UI.Chart.Core.IChartProcessor)`

注册一个处理器；重复注册同一实例不会产生修改。

| 参数 | 说明 |
| --- | --- |
| `processor` | 要注册的处理器。 |

**返回：** 当前注册表，便于链式调用。

### `RegisterSeries(TCYM.UI.Chart.Core.IChartSeriesRenderer,Boolean)`

注册旧式系列渲染器。

| 参数 | 说明 |
| --- | --- |
| `renderer` | 要注册的渲染器。 |
| `replace` | 同名项存在时是否替换。 |

**返回：** 当前注册表。

### `RegisterSeriesAttachment(TCYM.UI.Chart.Core.IChartSeriesAttachmentViewFactory,Boolean)`

注册一个按宿主系列动态存在的持久 attachment View 工厂。

| 参数 | 说明 |
| --- | --- |
| `factory` | 共享 Registry 中必须保持无 Engine-local 状态的工厂。 |
| `replace` | 同 attachment 键存在时是否替换。 |

**返回：** 当前注册表。

### `RegisterSeriesView(TCYM.UI.Chart.Core.IChartSeriesViewFactory,Boolean)`

注册系列持久视图工厂。

| 参数 | 说明 |
| --- | --- |
| `factory` | 要注册的工厂。 |
| `replace` | 同名项存在时是否替换。 |

**返回：** 当前注册表。

### `TryGetCoordinateSystem(String,TCYM.UI.Chart.CoordinateSystems.IChartCoordinateSystemFactory@)`

尝试查找指定类型的坐标系工厂。

| 参数 | 说明 |
| --- | --- |
| `type` | 坐标系类型。 |
| `factory` | 找到时返回已注册工厂。 |

**返回：** 找到注册项时为 `true`。
