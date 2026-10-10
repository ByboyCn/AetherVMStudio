# ChartDataZoomModule

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Components.DataZoom`　**Chart 版本**：`0.1.1.25`

## 概述

集中装配 inside/slider dataZoom 的窗口处理器、视图、action 与交互控制器。

## 字段

| 名称 | 说明 |
| --- | --- |
| `ModuleKey` | 获取 dataZoom 组件在注册表中的稳定模块键。 |

## 方法

### `Register(TCYM.UI.Chart.Core.ChartRegistry)`

把 inside/slider dataZoom 能力原子注册到指定扩展注册表。

| 参数 | 说明 |
| --- | --- |
| `registry` | 接收处理器、action 和 controller 的注册表。 |

**返回：** 传入注册表，便于继续链式装配。

**说明：** 注册实例不保存 Engine-local 状态；窗口和拖动会话均按组件 RuntimeUid 存入所属 Engine。
