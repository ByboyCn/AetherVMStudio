# ChartAxisNameTruncateOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示轴名称在可用宽度不足时的 ECharts 风格截断补丁。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Ellipsis` | 获取或设置截断后追加的省略文本；空值使用文本引擎默认值。 |
| `MaxWidth` | 获取或设置轴名称允许占用的非负有限最大宽度；空值表示不额外约束。 |
| `Placeholder` | 获取或设置宽度不足以容纳任何名称字符时使用的占位文本。 |

## 方法

### `Clone`

创建值和 presence 日志均独立的 nameTruncate 副本。

**返回：** 内容等价的独立副本。

### `Reset`

显式恢复完整 nameTruncate 块的自动默认值。
