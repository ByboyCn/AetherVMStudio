# ChartAxisLabelOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示坐标轴标签的采样、排布、文本样式和格式化补丁。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Align` | 获取或设置标签文本水平对齐。 |
| `Color` | 获取或设置文本画刷；显式赋空恢复主题默认值。 |
| `Culture` | 获取或设置数字与日期时间标签使用的显式区域性。设置值会被克隆并冻结；默认使用<br />`InvariantCulture`，日期时间不会执行隐式时区转换。 |
| `FontSize` | 获取或设置非负有限字号。 |
| `Formatter` | 获取或设置 ECharts 风格字符串 formatter；显式赋空可清除旧模板。 |
| `FormatterCallback` | 获取或设置专用强类型 formatter；存在时优先于字符串模板。 |
| `HideOverlap` | 获取或设置是否隐藏与其他轴标签重叠的标签。 |
| `Inside` | 获取或设置标签是否绘制在 grid 内侧。 |
| `Interval` | 获取或设置 category 标签采样间隔；空值表示自动，零表示全部显示。 |
| `LineHeight` | 获取或设置非负有限行高；空值交由文本引擎使用自然行高。 |
| `Margin` | 获取或设置标签与轴线之间的非负有限像素间距。 |
| `NameMoveOverlap` | 获取或设置轴名称是否移动以避开最终入选标签；空值采用 ECharts 6 的默认启用语义。 |
| `Rich` | 获取或设置可按名称新增、删除和深度合并的 rich 文本样式补丁。属性赋值表示整体替换，<br />会深复制当前内容；赋入空字典或空值表示整体清空。增量更新可继续使用 getter 返回字典<br />的索引器、`Remove` 或<br />`Clear`。 |
| `RichInheritPlainStyle` | 获取或设置 rich 字体相关字段是否继承普通轴标签样式；空值使用 ECharts 6 默认值。 |
| `Rotate` | 获取或设置顺时针旋转角度。 |
| `Show` | 获取或设置轴标签是否显示。 |
| `ShowMaxLabel` | 获取或设置是否强制显示最大值标签；空值表示自动判定。 |
| `ShowMinLabel` | 获取或设置是否强制显示最小值标签；空值表示自动判定。 |
| `TextFormatter` | 获取或设置公共强类型文本 formatter；存在时优先于兼容的<br />`FormatterCallback` 和字符串模板，并且可以直接返回 rich runs。 |
| `Typeface` | 获取或设置借用字体；选项及视图不会释放该实例。 |
| `VerticalAlign` | 获取或设置标签文本垂直对齐。 |

## 方法

### `Clone`

创建画刷、文本字段和 presence 日志均隔离的 axisLabel 副本。

**返回：** 独立副本。

### `Reset`

显式恢复整个 axisLabel 默认值。
