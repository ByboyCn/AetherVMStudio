# ChartLength

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts 风格的布局长度，支持像素、百分比、`auto` 和位置关键字。

## 构造函数

### `ChartLength(Single,TCYM.UI.Chart.Model.ChartLengthUnit)`

使用数值与单位创建长度。

| 参数 | 说明 |
| --- | --- |
| `value` | 数值；百分比单位下表示百分数而非 0 到 1 的比例。 |
| `unit` | 长度单位。 |

### `ChartLength(String)`

从已验证的布局关键字创建长度，并将 `auto` 规范化为专用单位。

| 参数 | 说明 |
| --- | --- |
| `keyword` | 非空布局关键字。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Auto` | 获取自动长度。 |
| `IsAuto` | 获取当前值是否为自动长度。 |
| `Keyword` | 获取关键字；非关键字长度返回 `null`。 |
| `Unit` | 获取长度单位。 |
| `Value` | 获取原始数值。 |

## 方法

### `FromKeyword(String)`

从布局关键字创建长度。

| 参数 | 说明 |
| --- | --- |
| `keyword` | 例如 `left`、`center` 或 `right`。 |

### `Percent(Single)`

创建百分比长度。

| 参数 | 说明 |
| --- | --- |
| `value` | 百分数，例如 50 表示 50%。 |

### `Pixels(Single)`

创建像素长度。

| 参数 | 说明 |
| --- | --- |
| `value` | 像素值。 |

### `Resolve(Single,Single)`

根据可用空间解析为像素值。

| 参数 | 说明 |
| --- | --- |
| `available` | 百分比计算所基于的可用长度。 |
| `autoValue` | 自动值或关键字无法直接解析时使用的回退值。 |

**返回：** 解析后的像素值。

### `ToString`

返回可再次解析的长度文本。

### `TryParse(String,TCYM.UI.Chart.Model.ChartLength@)`

尝试解析像素、百分比或布局关键字。

| 参数 | 说明 |
| --- | --- |
| `text` | 待解析文本。 |
| `length` | 解析成功时得到的长度。 |

**返回：** 输入非空时返回 `true`；非数值文本按关键字处理。
