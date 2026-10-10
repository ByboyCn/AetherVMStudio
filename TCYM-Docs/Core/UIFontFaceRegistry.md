# UIFontFaceRegistry

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

字体注册表

## 方法

### Register(string, string?, string?)

```csharp
void Register(string family, string? src, string? format = null)
```

注册字体

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `family` | `string` | 字体名字 |
| `src` | `string?` | 字体文件路径 |
| `format` | `string?` | 字体格式 |

### TryGet(string, SKTypeface)

```csharp
bool TryGet(string family, SKTypeface typeface)
```

尝试获取已注册的字体

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `family` | `string` | 字体名字 |
| `typeface` | `SKTypeface` | 字体对象 |

### Clear()

```csharp
void Clear()
```

清除已注册的字体
