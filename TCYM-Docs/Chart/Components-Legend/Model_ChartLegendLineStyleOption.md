# ChartLegendLineStyleOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Legend 线型图标的 presence-aware 描边样式补丁。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Color` | 获取或设置线条画刷；空值恢复 presentation 继承值。 |
| `InactiveColor` | 获取或设置未选中时的线条画刷。 |
| `InactiveWidth` | 获取或设置未选中时的有限非负线宽。 |
| `Opacity` | 获取或设置 0～1 的线条不透明度；空值恢复继承值。 |
| `Type` | 获取或设置线型关键字，例如 `solid`、`dashed` 或 `dotted`。 |
| `Width` | 获取或设置有限非负线宽；空值使用 ECharts auto 语义。 |

## 方法

### `Clone`

创建画刷、数值及 presence 日志均独立的副本。

**返回：** 内容等价的新线条样式。

### `Reset`

显式清除整个 Legend 线条样式块。
