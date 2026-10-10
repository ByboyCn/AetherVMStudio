# ChartTextLayoutRequest

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Text`　**Chart 版本**：`0.1.1.25`

## 概述

表示一次文本布局的不可变输入。构造时立即复制内容、普通样式和 rich 样式，调用方随后
原位修改公开样式或字典不会改变本次请求。

## 构造函数

### `ChartTextLayoutRequest(String,TCYM.UI.Chart.Rendering.ChartTextStyle)`

使用纯文本创建布局请求。

| 参数 | 说明 |
| --- | --- |
| `text` | 普通文本；空值按空字符串处理。 |
| `style` | 普通文本样式。 |

### `ChartTextLayoutRequest(TCYM.UI.Chart.Text.ChartTextContent,TCYM.UI.Chart.Rendering.ChartTextStyle,Collections.Generic.IEnumerable{Collections.Generic.KeyValuePair{String,TCYM.UI.Chart.Rendering.ChartTextStyle}},Boolean)`

创建包含普通和 rich runs 的布局请求。

| 参数 | 说明 |
| --- | --- |
| `content` | 已经防御复制的格式化文本内容。 |
| `style` | 普通文本样式及根文本框约束。 |
| `richStyles` | 按 rich 名称索引的可变样式；构造函数会立即复制。 |
| `richInheritPlainStyle` | rich 样式是否继承普通样式的字体、颜色、行高和透明度；默认值与 ECharts 6 一致。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Content` | 获取不可变格式化文本内容。 |
| `RichInheritPlainStyle` | 获取 rich 字体相关字段是否继承普通样式。 |
| `RichStyles` | 获取按名称索引的不可变 rich 样式快照。 |
| `Style` | 获取普通文本和根文本框的不可变样式快照。 |
