# ChartTooltipPosition

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts position 的 AOT 安全不可变联合值，支持 point、keyword、box 和 callback。
本类型不暴露 DOM 元素；原生场景回调通过 `ChartTooltipPositionContext` 获取等价几何。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Auto` | 获取跟随指针并自动翻转的共享位置。 |
| `Box` | 获取 box layout 值；仅 `Box` 有效。 |
| `Callback` | 获取位置回调；仅 `Callback` 有效。 |
| `Keyword` | 获取相对图元关键字；其他种类为空。 |
| `Kind` | 获取位置表达式种类。 |
| `X` | 获取 point 横坐标；其他种类为空。 |
| `Y` | 获取 point 纵坐标；其他种类为空。 |

## 方法

### `Around(TCYM.UI.Chart.Model.ChartTooltipPositionKeyword)`

创建相对于命中图元包围盒的位置。

| 参数 | 说明 |
| --- | --- |
| `keyword` | inside、top、left、right 或 bottom。 |

**返回：** 不可变 keyword 位置。

### `At(TCYM.UI.Chart.Model.ChartLength,TCYM.UI.Chart.Model.ChartLength)`

创建像素或百分比二维位置。

| 参数 | 说明 |
| --- | --- |
| `x` | 横向像素或百分比长度。 |
| `y` | 纵向像素或百分比长度。 |

**返回：** 不可变 point 位置。

### `FromCallback(TCYM.UI.Chart.Model.ChartTooltipPositionCallback)`

创建在内容测量后执行的强类型位置回调。

| 参数 | 说明 |
| --- | --- |
| `callback` | 不得为空的位置解析器。 |

**返回：** 不可变 callback 位置。

### `InBox(TCYM.UI.Chart.Model.ChartTooltipBoxPosition)`

创建 left/top/right/bottom box layout 位置。

| 参数 | 说明 |
| --- | --- |
| `box` | 至少指定一侧的不可变 box 位置。 |

**返回：** 不可变 box 位置。
