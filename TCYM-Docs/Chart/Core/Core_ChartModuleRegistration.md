# ChartModuleRegistration

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

收集一次模块装配需要提交的全部注册项。
实例只由 `RegisterModule`
在配置回调期间提供；回调结束后即被冻结，不能继续修改。

## 方法

### `AddAction(TCYM.UI.Chart.Core.IChartActionHandler)`

加入一个 action 处理器。

| 参数 | 说明 |
| --- | --- |
| `handler` | 要随模块原子提交的处理器。 |

**返回：** 当前配置，便于链式添加。

### `AddComponentRenderer(TCYM.UI.Chart.Core.IChartComponentRenderer)`

加入一个旧式组件渲染器。

| 参数 | 说明 |
| --- | --- |
| `renderer` | 要随模块原子提交的渲染器。 |

**返回：** 当前配置，便于链式添加。

### `AddComponentView(TCYM.UI.Chart.Core.IChartComponentViewFactory)`

加入一个组件持久 View 工厂。

| 参数 | 说明 |
| --- | --- |
| `factory` | 要随模块原子提交的工厂。 |

**返回：** 当前配置，便于链式添加。

### `AddCoordinateSystem(TCYM.UI.Chart.CoordinateSystems.IChartCoordinateSystemFactory)`

加入一个坐标系工厂。

| 参数 | 说明 |
| --- | --- |
| `factory` | 要随模块原子提交的工厂。 |

**返回：** 当前配置，便于链式添加。

### `AddInteractionController(TCYM.UI.Chart.Core.IChartInteractionController,String)`

加入一个交互控制器，并冻结其顺序与稳定冲突键。

| 参数 | 说明 |
| --- | --- |
| `controller` | 要随模块原子提交的控制器。 |
| `registrationKey` | 可选的全局稳定控制器键。省略时由顺序和实现类型组成。 |

**返回：** 当前配置，便于链式添加。

### `AddOptionValidator(TCYM.UI.Chart.Core.IChartOptionValidator)`

加入一个 option 校验器。同一模块的全部校验器会在锁外完整冻结为一个处理器，
再与模块的其他注册项一起提交。

| 参数 | 说明 |
| --- | --- |
| `validator` | 要随模块原子提交的校验器。 |

**返回：** 当前配置，便于链式添加。

### `AddProcessor(TCYM.UI.Chart.Core.IChartProcessor,String)`

加入一个处理器，并在当前调用中冻结其阶段、顺序和稳定冲突键。

| 参数 | 说明 |
| --- | --- |
| `processor` | 要随模块原子提交的处理器。 |
| `registrationKey` | 可选的全局稳定处理器键。省略时由阶段、顺序和实现类型组成；只有模块确实需要注册相同签名的<br />多个实例时才应显式指定。 |

**返回：** 当前配置，便于链式添加。

### `AddSeriesAttachment(TCYM.UI.Chart.Core.IChartSeriesAttachmentViewFactory)`

加入一个按宿主系列动态存在的持久 attachment View 工厂。

| 参数 | 说明 |
| --- | --- |
| `factory` | 要随模块原子提交的无状态 attachment 工厂。 |

**返回：** 当前配置，便于链式添加。

### `AddSeriesRenderer(TCYM.UI.Chart.Core.IChartSeriesRenderer)`

加入一个旧式系列渲染器。

| 参数 | 说明 |
| --- | --- |
| `renderer` | 要随模块原子提交的渲染器。 |

**返回：** 当前配置，便于链式添加。

### `AddSeriesView(TCYM.UI.Chart.Core.IChartSeriesViewFactory)`

加入一个系列持久 View 工厂。

| 参数 | 说明 |
| --- | --- |
| `factory` | 要随模块原子提交的工厂。 |

**返回：** 当前配置，便于链式添加。
