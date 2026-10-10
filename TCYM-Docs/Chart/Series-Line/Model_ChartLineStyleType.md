# ChartLineStyleType

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts 6.1 `lineStyle.type` 的预定义关键字、数值或数值数组联合类型。
自定义数组在输入、输出和 option 生命周期边界都会深度隔离。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Dashed` | 获取预定义虚线关键字。 |
| `DashLength` | 获取数值类别的重复虚线长度；其他类别返回空。 |
| `DashPattern` | 获取自定义虚线图案的只读深拷贝；其他类别返回空。<br />每次读取都会返回新的隔离集合，不能反向修改当前联合值。 |
| `Dotted` | 获取预定义点线关键字。 |
| `Kind` | 获取线型联合值的当前类别。 |
| `Solid` | 获取连续实线关键字。 |

## 方法

### `Equals(Object)`

### `Equals(TCYM.UI.Chart.Model.ChartLineStyleType)`

### `FromDashLength(Single)`

从非负有限数值创建重复虚线长度。

| 参数 | 说明 |
| --- | --- |
| `dashLength` | 非负有限虚线长度。 |

**返回：** 数值形式的线型联合值。

### `FromDashPattern(Collections.Generic.IEnumerable{Single})`

从非空的非负有限数值序列创建自定义虚线图案。

| 参数 | 说明 |
| --- | --- |
| `dashPattern` | 待捕获的虚线长度序列。 |

**返回：** 拥有独立数组快照的线型联合值。

### `GetHashCode`
