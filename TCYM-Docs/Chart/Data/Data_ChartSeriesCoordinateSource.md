# ChartSeriesCoordinateSource

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

描述一个 encode 通道解析后的确定数据来源；标量条件分支只用于 inline 默认坐标通道。

## 构造函数

### `ChartSeriesCoordinateSource(TCYM.UI.Chart.Data.ChartSeriesCoordinateSourceKind,Int32,String)`

创建一个已经验证的 encode 来源。

| 参数 | 说明 |
| --- | --- |
| `kind` | 存储维度、合成 rawIndex 或标量条件来源。 |
| `dimensionIndex` | 需要存储值时为非负索引；纯 rawIndex 来源固定为 -1。 |
| `dimensionName` | 可选存储维度名称；纯 rawIndex 来源固定为空。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `DimensionIndex` | 获取存储维度索引；不读取存储值的来源返回 -1。 |
| `DimensionName` | 获取存储维度名称；不读取存储值的来源返回空。 |
| `ForRawIndex` | 获取按稳定 rawIndex 合成的共享来源。 |
| `ForScalarRawIndex` | 获取仅对标量语法合成 rawIndex 的共享来源。 |
| `Kind` | 获取来源类别。 |
| `UsesStoredDimension` | 获取该来源是否可能读取一个存储维度。 |

## 方法

### `ForDimension(Int32,String)`

为一个已解析的存储维度创建来源。

| 参数 | 说明 |
| --- | --- |
| `dimensionIndex` | 非负维度索引。 |
| `dimensionName` | 可选维度名称。 |

**返回：** 存储维度来源。

### `ForScalarDimension(Int32,String)`

创建仅对标量语法读取指定维度的来源。

| 参数 | 说明 |
| --- | --- |
| `dimensionIndex` | 非负维度索引。 |
| `dimensionName` | 可选维度名称。 |

**返回：** 标量条件存储来源。

### `ForScalarRawIndexOrDimension(Int32,String)`

创建标量语法使用 rawIndex、向量语法读取维度的来源。

| 参数 | 说明 |
| --- | --- |
| `dimensionIndex` | 非负维度索引。 |
| `dimensionName` | 可选维度名称。 |

**返回：** 标量/向量条件来源。

### `Read(TCYM.UI.Chart.Data.ChartDataViewItem)`

按当前数据项的标量语法和稳定 rawIndex 读取最终图表值。

| 参数 | 说明 |
| --- | --- |
| `item` | 当前处理后数据视图项。 |

**返回：** 存储值、合成索引或不适用分支的空值。
