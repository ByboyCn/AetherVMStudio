# ChartBoxLayout

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Components.Common`　**Chart 版本**：`0.1.1.25`

## 概述

解析 ECharts 风格组件矩形约束。每个维度遵循同一确定冲突规则：显式尺寸优先；
显式尺寸存在时起侧约束优先于末侧约束；尺寸为空且两侧都是数值约束时由两侧拉伸；
其余情况使用期望尺寸，并按起侧、末侧的顺序选择锚点。

## 方法

### `Resolve(TCYM.UI.Chart.Components.Common.ChartBoxLayoutRequest@)`

解析布局请求并同时得到边框盒和内容盒。

| 参数 | 说明 |
| --- | --- |
| `request` | 待解析请求。 |

**返回：** 有限、非负且完全包含在请求视口中的确定布局。
