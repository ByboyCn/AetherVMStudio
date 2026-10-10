# ChartSymbolSize

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 symbol 的二维像素尺寸；单值输入会创建正方形尺寸。

## 构造函数

### `ChartSymbolSize(Single,Single)`

创建二维 symbol 尺寸。

| 参数 | 说明 |
| --- | --- |
| `width` | 非负有限宽度。 |
| `height` | 非负有限高度。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Height` | 获取 symbol 高度。 |
| `Width` | 获取 symbol 宽度。 |

## 方法

### `Square(Single)`

创建宽高相等的 symbol 尺寸。

| 参数 | 说明 |
| --- | --- |
| `size` | 非负有限边长。 |

**返回：** 正方形尺寸。
