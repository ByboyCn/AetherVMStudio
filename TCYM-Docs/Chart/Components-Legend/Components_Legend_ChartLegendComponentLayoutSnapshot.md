# ChartLegendComponentLayoutSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Legend`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个 Legend 组件在 Visual 阶段完成的不可变状态与最终布局。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AllItems` | 获取所有逻辑图例项，供 action 和 selection mask 使用。 |
| `Bounds` | 获取最终边框盒。 |
| `BoxStyle` | 获取不可变外框样式。 |
| `ComponentId` | 获取 Legend 显式 Id。 |
| `ComponentIndex` | 获取 Legend 同类索引。 |
| `ComponentName` | 获取 Legend 显式 Name。 |
| `ContentClip` | 获取内容裁剪区域。 |
| `Controls` | 获取 selector 与分页控件。 |
| `CurrentPage` | 获取一基当前页码。 |
| `Items` | 获取当前页实际绘制的图例项。 |
| `Orient` | 获取水平或垂直方向。 |
| `PageCount` | 获取总页数；空 Legend 为零。 |
| `ScrollDataIndex` | 获取当前确定分页起始索引。 |
| `ScrollOptionRevision` | 获取选项分页种子版本。 |
| `Selected` | 获取全部逻辑项的有效选中快照。 |
| `SelectedMode` | 获取有效选择模式。 |
| `SelectionOptionRevision` | 获取选项选择种子版本。 |
| `Show` | 获取当前组件是否显示。 |
| `Silent` | 获取当前组件是否忽略交互。 |
| `TriggerEvent` | 获取是否公开 legend 组件 metadata。 |
| `Type` | 获取 plain 或 scroll 类型。 |
