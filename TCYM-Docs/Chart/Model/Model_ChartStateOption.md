# ChartStateOption

> **类型**：class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 emphasis、blur 与 select 共用的视觉状态配置。这里只公开三个状态都支持的
label/itemStyle；disabled、blurScope、focus 等角色字段由精确的状态类型公开。

## 属性

| 名称 | 说明 |
| --- | --- |
| `ItemStyle` | 获取或设置该状态下的图元样式补丁；赋空会显式重置嵌套样式。 |
| `Label` | 获取或设置该状态下的标签补丁；赋空会显式重置嵌套标签。 |

## 方法

### `Clone`

创建状态字段、嵌套块与 presence 日志均独立的副本。

**返回：** 内容等价的新状态选项。

### `Reset`

显式清除整个状态块，包括嵌套 label 与 itemStyle。公开入口不可重写，避免外部派生
状态改变系列 backing 的重置语义。
