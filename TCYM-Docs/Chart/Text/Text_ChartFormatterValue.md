# ChartFormatterValue

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Text`　**Chart 版本**：`0.1.1.25`

## 概述

表示 formatter `params.value` 的显式标量或向量不可变快照。

## 说明

标量与向量的形状由 `FromScalar` 或 `FromVector` 的入口确定，
不会根据值数量推断；因此单元素向量仍然是向量，空向量也不会退化为空标量。

## 属性

| 名称 | 说明 |
| --- | --- |
| `IsScalar` | 获取当前值是否来自标量语法。 |
| `IsVector` | 获取当前值是否来自数组、dataset 行等向量语法。 |
| `Primary` | 获取第一个值；显式空向量返回 `Null`。 |
| `Values` | 获取按原始存储顺序排列的只读值快照；标量包含一项，向量可以包含零项、一项或多项。 |

## 方法

### `FromScalar(TCYM.UI.Chart.Data.ChartValue)`

从一个值创建显式标量快照。

| 参数 | 说明 |
| --- | --- |
| `value` | 待隔离的标量。 |

**返回：** 形状固定为标量的不可变值。

### `FromVector(Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue})`

从值序列创建显式向量快照。

| 参数 | 说明 |
| --- | --- |
| `values` | 按数组或 dataset 行原始顺序提供的值；即使只包含一项，结果仍保持向量形状。 |

**返回：** 已复制并隔离每个自定义载荷的不可变向量。

### `ToObject`

转换为公开 CLR 表示；标量返回其领域对象，向量返回当前只读值快照，且不会静默取主值。

**返回：** 标量对象、向量只读快照或空标量对应的 `null`。

### `TryGetScalar(TCYM.UI.Chart.Data.ChartValue@)`

仅当当前联合值为标量时取得该值。

| 参数 | 说明 |
| --- | --- |
| `value` | 成功时得到标量，包括显式空标量；向量时返回 `Null`。 |

**返回：** 当前形状是标量时返回 `true`。
