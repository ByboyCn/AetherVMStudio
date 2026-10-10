# FilePickerFileType

> **类型**：类　**分类**：Storage　**框架版本**：`0.1.1.24`

## 概述

文件类型过滤项，接口形态参考 Avalonia 的 FilePickerFileType。 当前 Windows 原生实现优先使用 <see cref="Patterns"/>。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Name` | `string` | 过滤器显示名称。 |
| `Patterns` | `IReadOnlyList<string>?` | 文件匹配模式列表，例如 <c>*.txt</c>、<c>*.png</c>。 |
| `MimeTypes` | `IReadOnlyList<string>?` | MIME 类型列表。当前 Windows 原生实现暂未使用。 |
| `AppleUniformTypeIdentifiers` | `IReadOnlyList<string>?` | Apple UTI 列表。当前 Windows 原生实现暂未使用。 |
