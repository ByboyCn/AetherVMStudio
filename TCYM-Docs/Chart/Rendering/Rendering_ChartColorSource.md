# ChartColorSource

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Rendering`　**Chart 版本**：`0.1.1.25`

## 概述

表示无需 sentinel 画刷或反射的强类型颜色来源。固定画刷在创建时按公共画刷契约冻结；
`default` 不是有效声明，option setter 会同步拒绝它。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Auto` | 获取由消费组件解析的自动颜色来源。 |
| `Brush` | 获取已隔离的固定画刷；auto/inherit 返回空。 |
| `Inherit` | 获取继承父级有效颜色的来源。 |
| `Inherited` | 获取 `Inherit` 的说明性兼容别名。 |
| `IsStatic` | 获取是否携带固定画刷。 |
| `Kind` | 获取颜色来源类别。 |

## 方法

### `Equals(Object)`

### `Equals(TCYM.UI.Chart.Rendering.ChartColorSource)`

### `FromBrush(TCYM.UI.Chart.Rendering.ChartBrush)`

创建固定画刷来源。

| 参数 | 说明 |
| --- | --- |
| `brush` | 要立即冻结的非空画刷。 |

**返回：** 与调用方后续修改隔离的固定颜色来源。

### `GetHashCode`

### `Static(TCYM.UI.Chart.Rendering.ChartBrush)`

创建固定画刷来源；这是 `FromBrush` 的语义化别名。
