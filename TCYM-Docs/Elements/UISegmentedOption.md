# UISegmentedOption

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

## 概述

Segmented 的选项定义。 支持纯文本标签或自定义 UIElement 内容。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `value` | `UISegmentedOption(string label, object?` | 使用文本标签创建一个选项。 |
| `value` | `UISegmentedOption(UIElement content, object?` | 使用自定义 UIElement 内容创建一个选项。 |
| `Value` | `object?` | 选项值。未设置时会回退为 Label、Content 或索引。 |
| `Label` | `string?` | 纯文本标签。 |
| `Content` | `UIElement?` | 自定义内容。 |
| `Disabled` | `bool` | 是否禁用当前选项。 |
| `Style` | `UpdateUIStyle?` | 常规态增量样式。 |
| `SelectedStyle` | `UpdateUIStyle?` | 选中态增量样式。 |
