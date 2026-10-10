# UIFileDropEvent

> **类型**：类　**分类**：Events　**框架版本**：`0.1.1.24`

## 概述

文件 / 文本拖放事件（把文件或文本从系统拖入窗口）。 SDL3 对拖放做了增强：新增了拖动过程中的位置更新（DROP_POSITION），因此本事件带有落点坐标。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Phase` | `UIFileDropPhase` | 拖放事件阶段。 |
| `Position` | `SKPoint` | 当前拖放 / 落点位置（渲染坐标）。 |
| `Files` | `IReadOnlyList<string>` | 拖入的文件路径列表（文本拖放时为空）。 |
| `Text` | `string?` | 拖入的纯文本（文件拖放时为 null）。 |
| `Handled` | `bool` | 是否已被处理。 |
| `text` | `UIFileDropEvent(UIFileDropPhase phase, SKPoint position, IReadOnlyList<string> files, string?` | 创建文件 / 文本拖放事件。 |
