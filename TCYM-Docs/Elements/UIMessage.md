# UIMessage

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

## 概述

全局提示组件（参考 Ant Design Message）。 通过静态方法调用，在页面顶部居中显示提示信息，支持多种类型、自动关闭、手动关闭等。 <para>用法示例：</para> <code> UIMessage.Info("操作成功"); UIMessage.Success("保存成功", duration: 5); UIMessage.Error("网络异常"); UIMessage.Warning("请注意"); UIMessage.Loading("加载中..."); UIMessage.Loading("加载中...", key: "load1"); UIMessage.Open(new MessageConfig { Content = "自定义样式", Type = MessageType.Success, Style = new DefaultUIStyle // 外壳样式 { BackgroundColor = SKColor.Parse("#f6ffed"), BorderRadius = 4, }, ContentStyle = new DefaultUIStyle // 文本样式 { FontSize = 16, Color = SKColor.Parse("#52c41a"), } }); UIMessage.Config(new MessageGlobalConfig { Top = 20, Duration = 5, Style = new DefaultUIStyle // 所有消息的默认外壳样式 { BackgroundColor = SKColor.Parse("#1a1a2e"), BorderRadius = 12, }, ContentStyle = new DefaultUIStyle // 所有消息的默认文本样式 { Color = SKColors.White, } }); </code>

## 方法

### Config(MessageGlobalConfig)

```csharp
void Config(MessageGlobalConfig config)
```

配置全局默认参数。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `config` | `MessageGlobalConfig` |  |

### Config(float?, float?, int?)

```csharp
void Config(float? top = null, float? duration = null, int? maxCount = null)
```

配置全局默认参数（便捷方式）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `top` | `float?` |  |
| `duration` | `float?` |  |
| `maxCount` | `int?` |  |

### Info(string, float?, Action?, string?)

```csharp
void Info(string content, float? duration = null, Action? onClose = null, string? key = null)
```

普通信息提示。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `content` | `string` | 提示内容。 |
| `duration` | `float?` | 自动关闭延时（秒），null 使用全局默认值。 |
| `onClose` | `Action?` | 关闭后回调。 |
| `key` | `string?` | 消息唯一标识，用于更新或关闭。 |

### Info(string, float?, Func<Task>, string?)

```csharp
void Info(string content, float? duration, Func<Task> onCloseAsync, string? key = null)
```

普通信息提示，并在关闭后调用异步回调。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `content` | `string` | 提示内容。 |
| `duration` | `float?` | 自动关闭延时（秒），null 使用全局默认值。 |
| `onCloseAsync` | `Func<Task>` | 关闭后的异步回调。 |
| `key` | `string?` | 消息唯一标识，用于更新或关闭。 |

### Success(string, float?, Action?, string?)

```csharp
void Success(string content, float? duration = null, Action? onClose = null, string? key = null)
```

成功提示。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `content` | `string` |  |
| `duration` | `float?` |  |
| `onClose` | `Action?` |  |
| `key` | `string?` |  |

### Success(string, float?, Func<Task>, string?)

```csharp
void Success(string content, float? duration, Func<Task> onCloseAsync, string? key = null)
```

成功提示，并在关闭后调用异步回调。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `content` | `string` | 提示内容。 |
| `duration` | `float?` | 自动关闭延时（秒），null 使用全局默认值。 |
| `onCloseAsync` | `Func<Task>` | 关闭后的异步回调。 |
| `key` | `string?` | 消息唯一标识，用于更新或关闭。 |

### Error(string, float?, Action?, string?)

```csharp
void Error(string content, float? duration = null, Action? onClose = null, string? key = null)
```

错误提示。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `content` | `string` |  |
| `duration` | `float?` |  |
| `onClose` | `Action?` |  |
| `key` | `string?` |  |

### Error(string, float?, Func<Task>, string?)

```csharp
void Error(string content, float? duration, Func<Task> onCloseAsync, string? key = null)
```

错误提示，并在关闭后调用异步回调。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `content` | `string` | 提示内容。 |
| `duration` | `float?` | 自动关闭延时（秒），null 使用全局默认值。 |
| `onCloseAsync` | `Func<Task>` | 关闭后的异步回调。 |
| `key` | `string?` | 消息唯一标识，用于更新或关闭。 |

### Warning(string, float?, Action?, string?)

```csharp
void Warning(string content, float? duration = null, Action? onClose = null, string? key = null)
```

警告提示。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `content` | `string` |  |
| `duration` | `float?` |  |
| `onClose` | `Action?` |  |
| `key` | `string?` |  |

### Warning(string, float?, Func<Task>, string?)

```csharp
void Warning(string content, float? duration, Func<Task> onCloseAsync, string? key = null)
```

警告提示，并在关闭后调用异步回调。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `content` | `string` | 提示内容。 |
| `duration` | `float?` | 自动关闭延时（秒），null 使用全局默认值。 |
| `onCloseAsync` | `Func<Task>` | 关闭后的异步回调。 |
| `key` | `string?` | 消息唯一标识，用于更新或关闭。 |

### Loading(string, float?, Action?, string?)

```csharp
void Loading(string content, float? duration = null, Action? onClose = null, string? key = null)
```

加载中提示（默认不自动关闭）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `content` | `string` |  |
| `duration` | `float?` |  |
| `onClose` | `Action?` |  |
| `key` | `string?` |  |

### Loading(string, float?, Func<Task>, string?)

```csharp
void Loading(string content, float? duration, Func<Task> onCloseAsync, string? key = null)
```

加载中提示，并在关闭后调用异步回调。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `content` | `string` | 提示内容。 |
| `duration` | `float?` | 自动关闭延时（秒），null 表示不自动关闭。 |
| `onCloseAsync` | `Func<Task>` | 关闭后的异步回调。 |
| `key` | `string?` | 消息唯一标识，用于更新或关闭。 |

### Open(MessageConfig)

```csharp
void Open(MessageConfig config)
```

打开一条消息。若指定 Key 且已存在，则更新内容；否则新增。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `config` | `MessageConfig` |  |

### Close(string)

```csharp
void Close(string key)
```

关闭指定 Key 的消息。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `key` | `string` |  |

### DestroyAll()

```csharp
void DestroyAll()
```

关闭所有消息。

## 相关类型

### MessageConfig

> **类型**：类

全局提示的配置参数。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Content` | `string` | 提示内容文本。 |
| `Duration` | `float` | 自动关闭延时（秒），默认 2 秒。设为 0 则不自动关闭。 |
| `Type` | `MessageType` | 消息类型。 |
| `OnClose` | `Action?` | 关闭后的回调。 |
| `OnCloseAsync` | `Func<Task>?` | 关闭后的异步回调。 |
| `Key` | `string?` | 当前消息的唯一标识。不为 null 时可用于更新或关闭指定消息。 |
| `Style` | `UIStyle?` | 自定义消息条外壳样式（背景色、圆角、阴影、内边距等）。 |
| `ContentStyle` | `UIStyle?` | 自定义消息文本样式（字号、颜色等）。 |

### MessageGlobalConfig

> **类型**：类

UIMessage 全局配置。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Top` | `float` | 消息距离顶部的位置（像素），默认 33。 |
| `Duration` | `float` | 默认自动关闭延时（秒），默认 2。 |
| `MaxCount` | `int` | 最大同时显示数量，0 表示不限制。 |
| `Style` | `UIStyle?` | 全局默认消息条外壳样式（背景色、圆角、阴影、内边距等），会被单条 MessageConfig.Style 覆盖。 |
| `ContentStyle` | `UIStyle?` | 全局默认消息文本样式（字号、颜色等），会被单条 MessageConfig.ContentStyle 覆盖。 |

### MessageType

> **类型**：枚举

全局提示消息类型。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Info` | - | 普通信息提示。 |
| `Success` | - | 成功提示。 |
| `Error` | - | 错误提示。 |
| `Warning` | - | 警告提示。 |
| `Loading` | - | 加载中提示。 |
