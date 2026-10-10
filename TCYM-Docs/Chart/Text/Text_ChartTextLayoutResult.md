# ChartTextLayoutResult

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Text`　**Chart 版本**：`0.1.1.25`

## 概述

表示可缓存的不可变文本布局结果。绘制、测量和命中应共同消费此对象，避免三条路径重复解释
formatter、rich、换行或截断语义。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Bounds` | 获取兼容旧文本元素测量 API 的逻辑包围盒。 |
| `ClipBounds` | 获取绘制文字时使用的内容裁剪框；无溢出裁剪时为空。 |
| `Content` | 获取布局使用的不可变格式化内容。 |
| `ContentBounds` | 获取根文本框内部的内容约束区域。 |
| `InkBounds` | 获取文字、box 和 shadow 可能产生像素的包围盒。 |
| `IsTruncated` | 获取布局是否因宽高约束截断了源文本。 |
| `Lines` | 获取按从上到下顺序排列的不可变文本行。 |
| `LogicalBounds` | 获取包含宽高约束、padding 和 border 的逻辑包围盒。 |
| `SourceRequest` | 获取产生本结果的完整不可变请求。预布局消费者必须从这里恢复普通内容、根样式、rich 样式及<br />继承开关，不能用当前元素的另一份可变配置伪造来源。 |
| `Style` | 获取根文本样式快照。 |
