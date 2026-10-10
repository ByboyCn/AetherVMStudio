# ChartLegendSelectionMask

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Visual`　**Chart 版本**：`0.1.1.25`

## 概述

保存公共 Legend Visual processor 解析出的不可变目标选择掩码。没有列入掩码的系列或数据项
默认可见，确保未配置 Legend 时 series 无需构造额外状态。

## 构造函数

### `ChartLegendSelectionMask(Collections.Generic.IEnumerable{Collections.Generic.KeyValuePair{TCYM.UI.Chart.Visual.ChartLegendTarget,Boolean}})`

深复制目标到选择值的映射。

| 参数 | 说明 |
| --- | --- |
| `selected` | 由 Legend processor 聚合且不含重复目标的选择项。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取掩码中显式列出的目标数量。 |

## 方法

### `IsDataItemSelected(TCYM.UI.Chart.Model.ChartSeriesOption,String)`

查询系列中的稳定数据项是否被 Legend 选中。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前有效系列或保留同一身份的快照。 |
| `dataKey` | 由系列定义的非空稳定数据键。 |

**返回：** 显式数据项选择值；未列入掩码时返回 `true`。

### `IsSelected(TCYM.UI.Chart.Visual.ChartLegendTarget)`

查询一个规范 Legend 目标是否选中。

| 参数 | 说明 |
| --- | --- |
| `target` | 系列或数据项目标。 |

**返回：** 显式值；目标未列入掩码时返回 `true`。

### `IsSeriesSelected(TCYM.UI.Chart.Model.ChartSeriesOption)`

查询整个系列是否被 Legend 选中。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前有效系列或保留同一身份的快照。 |

**返回：** 显式系列选择值；未列入掩码时返回 `true`。

### `IsTypedDataItemSelected(TCYM.UI.Chart.Model.ChartSeriesOption,TCYM.UI.Chart.Data.ChartDataKey)`

查询系列中的强类型稳定数据项是否被 Legend 选中。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前有效系列或保留同一身份的快照。 |
| `dataKey` | 包含来源、值和重复序号的强类型规范数据键。 |

**返回：** 强类型显式值；不存在时兼容旧 `ChartDataKey.ToString()` 目标，
两种目标均未列入掩码时返回 `true`。
