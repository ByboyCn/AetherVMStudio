# ChartEndLabelOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

扩展公共标签配置，补充 Line endLabel 的 precision，并为公共 valueAnimation 重述
Line 首次揭示语义。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Precision` | 获取或设置首次 Line 裁剪揭示期间的 `auto` 或显式小数位数；<br />空值清除当前声明并恢复有效默认 `auto`。 |
| `ValueAnimation` | 获取或设置终点标签是否在首次 Line 裁剪揭示中插值 normal formatter 数值；<br />普通数据更新遵循 ECharts 6.1 语义直接跳到最终文本。 |

## 方法

### `Clone`

创建值、富文本字典与 presence 日志均独立的副本；字体仍遵循借用资源契约。

**返回：** 内容等价的新标签选项；其中 `SKTypeface` 引用会共享。
