# ChartStackItemSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Series.Stack`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个处理后数据项的原值、堆叠基线、累计结果与稳定 lineage。

## 构造函数

### `ChartStackItemSnapshot(TCYM.UI.Chart.Data.ChartDataKey,Int32,Int32,TCYM.UI.Chart.Data.ChartValue,Nullable{Double},Nullable{Double},Boolean,Nullable{Double},Nullable{Int32})`

创建一个与处理后数据视图项一一对应的不可变堆叠结果。

| 参数 | 说明 |
| --- | --- |
| `key` | lineage 根稳定数据键。 |
| `rawIndex` | lineage 根 rawIndex。 |
| `insideIndex` | 当前处理后视图 insideIndex。 |
| `stackByValue` | 跨系列匹配使用的离散维度身份或 rawIndex 值；无效显式 category 保留原值供诊断，但不匹配。 |
| `sourceValue` | 可转换为有限数值时的系列原值。 |
| `resultValue` | 计算成功时的累计结果。 |
| `hasStackedOnValue` | 是否找到了符合策略的前驱项。 |
| `stackedOverValue` | 前驱项的累计值；`All` 策略选择到无效前驱时允许为空并传播空结果。 |
| `stackedOnSeriesIndex` | 实际提供前驱项的系列索引。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `HasStackedOnValue` | 获取当前项是否选中了一个符合策略的前驱项。 |
| `InsideIndex` | 获取当前处理后数据视图中的 insideIndex。 |
| `Key` | 获取 lineage 根稳定数据键。 |
| `RawIndex` | 获取 lineage 根 rawIndex。 |
| `ResultValue` | 获取堆叠后的有限累计结果；原值无效、`All` 传播无效前驱或加法溢出时为空。 |
| `SourceValue` | 获取当前系列的有限原值；空值表示数据不能参与数值计算。 |
| `StackByValue` | 获取跨系列匹配使用的离散维度身份或 rawIndex 值；无效显式 category 保留原值但不匹配。 |
| `StackedOnSeriesIndex` | 获取实际提供前驱项的系列索引；没有前驱时为空。 |
| `StackedOverValue` | 获取选中前驱项的累计值；`All` 选择到无效前驱时该值为空。 |
