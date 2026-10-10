# ChartSeriesDataTarget

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

使用数据类型命名空间、稳定源数据键和可选 presentation 身份唯一标识一个系列数据项。
未指定 presentation 时目标覆盖该源项的全部公开表示；指定后只覆盖一个精确公开表示。

## 构造函数

### `ChartSeriesDataTarget(TCYM.UI.Chart.Series.ChartSeriesDataType,TCYM.UI.Chart.Data.ChartDataKey,String)`

创建一个已经验证的源数据或精确 presentation 复合目标。

| 参数 | 说明 |
| --- | --- |
| `dataType` | 目标数据集合类型。 |
| `dataKey` | 目标数据项在该集合内的稳定键。 |
| `presentationKey` | 系列公开 presentation 内 owner-local 的稳定身份；为空时表示全部公开表示。 |

### `ChartSeriesDataTarget(TCYM.UI.Chart.Series.ChartSeriesDataType,TCYM.UI.Chart.Data.ChartDataKey)`

创建一个已经验证的源数据目标，并覆盖该源项的全部公开表示。

| 参数 | 说明 |
| --- | --- |
| `dataType` | 目标数据集合类型。 |
| `dataKey` | 目标数据项在该集合内的稳定键。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataKey` | 获取目标数据项在集合内的稳定键。 |
| `DataType` | 获取目标数据集合类型。 |
| `IsExactPresentation` | 获取目标是否只覆盖一个精确 presentation。 |
| `PresentationKey` | 获取系列公开 presentation 内的精确稳定身份；为空时目标覆盖源项的全部公开表示。 |

## 方法

### `ToSourceTarget`

取得丢弃精确 presentation 限定后的源数据目标。

**返回：** 数据类型与源稳定键保持不变的源目标。
