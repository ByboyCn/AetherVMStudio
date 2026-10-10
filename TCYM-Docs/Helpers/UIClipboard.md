# UIClipboard

> **类型**：类　**分类**：Helpers　**框架版本**：`0.1.1.24`

## 概述

跨平台剪贴板帮助类（基于 SDL3，Windows / Linux / macOS 通用）。

## 方法

### SetText(string?)

```csharp
bool SetText(string? text)
```

将文本写入系统剪贴板。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `text` | `string?` | 要写入的文本，为 null 时清空剪贴板。 |

**返回：** 成功返回 true，失败返回 false。

### GetText()

```csharp
string GetText()
```

从系统剪贴板读取文本。

**返回：** 剪贴板中的文本，无内容时返回空字符串。

### HasText()

```csharp
bool HasText()
```

检查剪贴板是否包含文本。

### SetImage(SKBitmap?)

```csharp
bool SetImage(SKBitmap? bitmap)
```

将图片写入系统剪贴板。Windows 下写入 CF_DIB 与 PNG 格式；其它平台当前返回 false。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `bitmap` | `SKBitmap?` |  |

### SetImage(byte[]?)

```csharp
bool SetImage(byte[]? encodedImageBytes)
```

将编码后的图片字节写入系统剪贴板。支持 SkiaSharp 可解码的常见格式。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `encodedImageBytes` | `byte[]?` |  |
