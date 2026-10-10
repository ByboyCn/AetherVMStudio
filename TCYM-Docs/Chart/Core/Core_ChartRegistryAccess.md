# ChartRegistryAccess

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

图表回调中公开的只读注册表视图。注册属于应用初始化操作，不能在引擎协调状态时
通过构建上下文修改注册表。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Version` | 获取当前已提交的注册表版本。 |

## 方法

### `TryGetCoordinateSystem(String,TCYM.UI.Chart.CoordinateSystems.IChartCoordinateSystemFactory@)`

尝试查找指定类型的坐标系工厂。

| 参数 | 说明 |
| --- | --- |
| `type` | 坐标系类型。 |
| `factory` | 找到时返回已注册工厂。 |

**返回：** 找到注册项时为 `true`。
