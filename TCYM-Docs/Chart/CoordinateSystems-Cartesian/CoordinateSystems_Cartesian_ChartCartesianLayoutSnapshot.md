# ChartCartesianLayoutSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

表示一次候选布局中全部直角网格和坐标轴的聚合不可变快照。构造函数复制输入集合，
验证网格引用和组件身份唯一后才公开只读视图。

## 构造函数

### `ChartCartesianLayoutSnapshot(Collections.Generic.IEnumerable{TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartCartesianGridLayoutSnapshot},Collections.Generic.IEnumerable{TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisLayoutSnapshot},Collections.Generic.IEnumerable{TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisTextLayoutSnapshot})`

创建全部直角网格和坐标轴的聚合布局快照。

| 参数 | 说明 |
| --- | --- |
| `grids` | 待复制的不可变网格布局。 |
| `axes` | 待复制的不可变坐标轴布局。 |
| `axisTexts` | 与轴身份一一对应的可选同源文本布局。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Axes` | 获取构造时复制的只读坐标轴布局集合。 |
| `AxisTexts` | 获取布局阶段冻结的轴标签采样、formatter 内容与统一文本布局。 |
| `Grids` | 获取构造时复制的只读网格布局集合。 |

## 方法

### `TryGetAxis(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisIdentity,TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisLayoutSnapshot@)`

按完整坐标轴身份尝试取得布局。

| 参数 | 说明 |
| --- | --- |
| `identity` | 待查找的坐标轴身份。 |
| `axis` | 成功时得到不可变坐标轴布局；失败时为空。 |

**返回：** 存在完全相同身份的坐标轴时返回 `true`。

### `TryGetAxisText(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisIdentity,TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisTextLayoutSnapshot@)`

按完整坐标轴身份尝试取得同源文本布局。

| 参数 | 说明 |
| --- | --- |
| `identity` | 待查找轴身份。 |
| `axisText` | 成功时得到该轴不可变文本快照。 |

**返回：** 布局包含对应轴文本时为真。

### `TryGetGrid(String,TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartCartesianGridLayoutSnapshot@)`

按稳定布局标识尝试取得网格。

| 参数 | 说明 |
| --- | --- |
| `id` | 待查找的网格布局标识。 |
| `grid` | 成功时得到不可变网格；失败时为空。 |

**返回：** 存在使用完全相同标识的网格时返回 `true`。
