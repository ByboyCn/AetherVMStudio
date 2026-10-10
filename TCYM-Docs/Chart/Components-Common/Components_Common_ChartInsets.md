# ChartInsets

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Components.Common`　**Chart 版本**：`0.1.1.25`

## 概述

表示图表矩形四侧的不可变非负像素内边距。默认值表示四侧均为零。

## 构造函数

### `ChartInsets(Single,Single,Single,Single)`

使用四个独立像素值创建内边距。

| 参数 | 说明 |
| --- | --- |
| `left` | 左侧有限非负像素值。 |
| `top` | 顶部有限非负像素值。 |
| `right` | 右侧有限非负像素值。 |
| `bottom` | 底部有限非负像素值。 |

### `ChartInsets(Single,Single)`

使用水平值和垂直值创建四侧内边距。

| 参数 | 说明 |
| --- | --- |
| `horizontal` | 左、右两侧共同使用的有限非负像素值。 |
| `vertical` | 上、下两侧共同使用的有限非负像素值。 |

### `ChartInsets(Single)`

使用同一个像素值创建四侧内边距。

| 参数 | 说明 |
| --- | --- |
| `all` | 四侧共同使用的有限非负像素值。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Bottom` | 获取底部像素内边距。 |
| `Horizontal` | 获取左右内边距之和。 |
| `IsEmpty` | 获取四侧是否均为零。 |
| `Left` | 获取左侧像素内边距。 |
| `Right` | 获取右侧像素内边距。 |
| `Top` | 获取顶部像素内边距。 |
| `Vertical` | 获取上下内边距之和。 |

## 方法

### `Deflate(SkiaSharp.SKRect)`

从规范化矩形四侧扣除当前内边距。内边距超过可用尺寸时，对应维度折叠为零，
且结果始终位于来源矩形内部。

| 参数 | 说明 |
| --- | --- |
| `bounds` | 端点有限且左右、上下有序的来源矩形。 |

**返回：** 有限、非负且包含在来源矩形中的矩形。

### `Equals(Object)`

### `Equals(TCYM.UI.Chart.Components.Common.ChartInsets)`

### `GetHashCode`
