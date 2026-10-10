# UINotification

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

## 概述

全局通知提醒组件，支持 TCYM.UI 窗口内通知和可替换的跨平台系统通知提供程序。

## 说明

窗口内通知支持六种位置、Key 更新、自动关闭进度、悬停暂停和操作按钮。 系统通知的外观、时长与位置由 Windows、Linux 或 macOS 的通知服务决定。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `SystemProvider` | `ISystemNotificationProvider` | 获取或替换系统通知提供程序。设置为 null 会恢复默认跨平台提供程序。 |
| `SystemCapabilities` | `SystemNotificationCapabilities` | 获取当前系统通知能力。能力是宿主环境的即时快照，发送时仍可能因权限或桌面会话变化而失败。 |
| `CurrentConfig` | `NotificationGlobalConfig` | 获取当前窗口内全局配置的独立快照。 |

## 方法

### Config(NotificationGlobalConfig)

```csharp
void Config(NotificationGlobalConfig config)
```

设置窗口内通知的全局默认配置。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `config` | `NotificationGlobalConfig` | 新的全局配置。 |

### ResetConfig()

```csharp
void ResetConfig()
```

恢复 UINotification 的默认全局配置。

### Open(NotificationConfig)

```csharp
void Open(NotificationConfig config)
```

在当前 UISystem 窗口中打开一条普通通知。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `config` | `NotificationConfig` | 通知配置。 |

### Open(UIManager, NotificationConfig)

```csharp
void Open(UIManager manager, NotificationConfig config)
```

在指定窗口管理器中打开一条普通通知。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `manager` | `UIManager` | 通知所属的窗口管理器。 |
| `config` | `NotificationConfig` | 通知配置。 |

### Info(string, string, float?, NotificationPlacement?, string?)

```csharp
void Info(string title, string description, float? duration = null, NotificationPlacement? placement = null, string? key = null)
```

在当前窗口显示信息通知。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `title` | `string` | 通知标题。 |
| `description` | `string` | 通知正文。 |
| `duration` | `float?` | 自动关闭秒数；为空时使用全局值。 |
| `placement` | `NotificationPlacement?` | 显示位置；为空时使用全局值。 |
| `key` | `string?` | 用于更新或关闭通知的唯一标识。 |

### Success(string, string, float?, NotificationPlacement?, string?)

```csharp
void Success(string title, string description, float? duration = null, NotificationPlacement? placement = null, string? key = null)
```

在当前窗口显示成功通知。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `title` | `string` | 通知标题。 |
| `description` | `string` | 通知正文。 |
| `duration` | `float?` | 自动关闭秒数；为空时使用全局值。 |
| `placement` | `NotificationPlacement?` | 显示位置；为空时使用全局值。 |
| `key` | `string?` | 用于更新或关闭通知的唯一标识。 |

### Warning(string, string, float?, NotificationPlacement?, string?)

```csharp
void Warning(string title, string description, float? duration = null, NotificationPlacement? placement = null, string? key = null)
```

在当前窗口显示警告通知。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `title` | `string` | 通知标题。 |
| `description` | `string` | 通知正文。 |
| `duration` | `float?` | 自动关闭秒数；为空时使用全局值。 |
| `placement` | `NotificationPlacement?` | 显示位置；为空时使用全局值。 |
| `key` | `string?` | 用于更新或关闭通知的唯一标识。 |

### Error(string, string, float?, NotificationPlacement?, string?)

```csharp
void Error(string title, string description, float? duration = null, NotificationPlacement? placement = null, string? key = null)
```

在当前窗口显示错误通知。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `title` | `string` | 通知标题。 |
| `description` | `string` | 通知正文。 |
| `duration` | `float?` | 自动关闭秒数；为空时使用全局值。 |
| `placement` | `NotificationPlacement?` | 显示位置；为空时使用全局值。 |
| `key` | `string?` | 用于更新或关闭通知的唯一标识。 |

### Close(string)

```csharp
void Close(string key)
```

关闭当前窗口中指定 Key 的通知。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `key` | `string` | 通知唯一标识。 |

### Close(UIManager, string)

```csharp
void Close(UIManager manager, string key)
```

关闭指定窗口中指定 Key 的通知。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `manager` | `UIManager` | 通知所属的窗口管理器。 |
| `key` | `string` | 通知唯一标识。 |

### Destroy(string?)

```csharp
void Destroy(string? key = null)
```

关闭当前窗口中的指定通知，或在 Key 为空时关闭全部通知。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `key` | `string?` | 通知唯一标识；为空时关闭全部通知。 |

### DestroyAll()

```csharp
void DestroyAll()
```

关闭当前窗口中的全部通知。

### DestroyAll(UIManager)

```csharp
void DestroyAll(UIManager manager)
```

关闭指定窗口中的全部通知。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `manager` | `UIManager` | 通知所属的窗口管理器。 |

### OpenAsync(NotificationConfig, NotificationDelivery, CancellationToken)

```csharp
Task<NotificationDeliveryResult> OpenAsync(NotificationConfig config, NotificationDelivery delivery, CancellationToken cancellationToken = default)
```

按指定投递方式异步打开通知。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `config` | `NotificationConfig` | 通知配置。 |
| `delivery` | `NotificationDelivery` | 窗口内、系统或优先系统。 |
| `cancellationToken` | `CancellationToken` | 取消系统通知尝试的令牌。 |

**返回：** 实际投递目标和系统尝试详情。

### OpenAsync(UIManager, NotificationConfig, NotificationDelivery, CancellationToken)

```csharp
Task<NotificationDeliveryResult> OpenAsync(UIManager manager, NotificationConfig config, NotificationDelivery delivery, CancellationToken cancellationToken = default)
```

针对指定窗口按指定投递方式异步打开通知。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `manager` | `UIManager` | 窗口内通知及降级通知所属的管理器。 |
| `config` | `NotificationConfig` | 通知配置。 |
| `delivery` | `NotificationDelivery` | 窗口内、系统或优先系统。 |
| `cancellationToken` | `CancellationToken` | 取消系统通知尝试的令牌。 |

**返回：** 实际投递目标和系统尝试详情。

### ShowSystemAsync(NotificationConfig, bool, CancellationToken)

```csharp
Task<NotificationDeliveryResult> ShowSystemAsync(NotificationConfig config, bool fallbackToInApp = false, CancellationToken cancellationToken = default)
```

尝试显示系统通知，可选择在失败时降级为窗口内通知。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `config` | `NotificationConfig` | 通知配置。 |
| `fallbackToInApp` | `bool` | 系统通知失败时是否显示窗口内通知。 |
| `cancellationToken` | `CancellationToken` | 取消系统通知尝试的令牌。 |

**返回：** 实际投递结果。

### ShowSystemAsync(UIManager, NotificationConfig, bool, CancellationToken)

```csharp
Task<NotificationDeliveryResult> ShowSystemAsync(UIManager manager, NotificationConfig config, bool fallbackToInApp = false, CancellationToken cancellationToken = default)
```

针对指定窗口尝试显示系统通知，并可在失败时降级为该窗口内通知。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `manager` | `UIManager` | 降级通知所属的窗口管理器。 |
| `config` | `NotificationConfig` | 通知配置。 |
| `fallbackToInApp` | `bool` | 系统通知失败时是否显示窗口内通知。 |
| `cancellationToken` | `CancellationToken` | 取消系统通知尝试的令牌。 |

**返回：** 实际投递结果。

## 相关类型

### ISystemNotificationProvider

> **类型**：接口

定义向操作系统提交原生通知的提供程序。

### NotificationAction

> **类型**：类

通知卡片底部的一个操作按钮。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Text` | `string` | 按钮文字。 |
| `OnClick` | `Action?` | 点击按钮后的同步回调。 |
| `OnClickAsync` | `Func<Task>?` | 点击按钮后的异步回调。 |
| `CloseOnClick` | `bool` | 点击按钮后是否关闭通知，默认关闭。 |
| `Style` | `UIStyle?` | 按钮的自定义样式。 |

### NotificationConfig

> **类型**：类

单条 UINotification 的显示配置。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Title` | `string` | 通知标题。 |
| `Description` | `string` | 通知说明正文。 |
| `Type` | `NotificationType` | 通知语义类型。 |
| `Placement` | `NotificationPlacement?` | 窗口内通知的位置；为空时使用全局配置。 |
| `Duration` | `float?` | 自动关闭延时（秒）；为空时使用全局配置，0 表示不自动关闭。 |
| `Key` | `string?` | 通知唯一标识。相同 Key 的窗口内通知会原位更新。 |
| `Closable` | `bool` | 是否显示右上角关闭按钮。 |
| `ShowProgress` | `bool?` | 是否显示自动关闭进度条；为空时使用全局配置。 |
| `PauseOnHover` | `bool?` | 鼠标悬停时是否暂停自动关闭计时；为空时使用全局配置。 |
| `CloseOnClick` | `bool` | 点击通知卡片后是否自动关闭。 |
| `OnClick` | `Action?` | 通知卡片被点击后的同步回调。 |
| `OnClickAsync` | `Func<Task>?` | 通知卡片被点击后的异步回调。 |
| `OnClose` | `Action?` | 通知关闭后的同步回调。 |
| `OnCloseAsync` | `Func<Task>?` | 通知关闭后的异步回调。 |
| `Actions` | `IReadOnlyList<NotificationAction>?` | 通知底部的操作按钮集合。 |
| `Style` | `UIStyle?` | 通知卡片外壳的自定义样式。 |
| `TitleStyle` | `UIStyle?` | 通知标题的自定义样式。 |
| `DescriptionStyle` | `UIStyle?` | 通知正文的自定义样式。 |
| `ProgressStyle` | `UIStyle?` | 自动关闭进度条的自定义样式。 |

### NotificationDeliveredTo

> **类型**：枚举

通知最终实际投递到的位置。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `None` | - | 通知未投递。 |
| `InApp` | - | 通知显示在 TCYM.UI 窗口内。 |
| `System` | - | 通知已交给操作系统通知服务。 |

### NotificationDelivery

> **类型**：枚举

通知的投递方式。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `InApp` | - | 仅在当前 TCYM.UI 窗口内显示。 |
| `System` | - | 仅请求操作系统通知，不自动降级。 |
| `PreferSystem` | - | 优先请求操作系统通知，不可用或失败时降级为窗口内通知。 |

### NotificationDeliveryResult

> **类型**：类

一次通知投递请求的结构化结果。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `RequestedDelivery` | `NotificationDelivery` | 调用方请求的投递方式。 |
| `DeliveredTo` | `NotificationDeliveredTo` | 通知最终实际投递到的位置。 |
| `UsedFallback` | `bool` | 是否因系统通知不可用而降级到窗口内通知。 |
| `SystemResult` | `SystemNotificationResult?` | 系统通知尝试的详细结果；未尝试系统通知时为空。 |
| `Succeeded` | `bool` | 通知是否已成功投递到任一目标。 |

### NotificationGlobalConfig

> **类型**：类

UINotification 的窗口内全局默认配置。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Placement` | `NotificationPlacement` | 默认显示位置。 |
| `Duration` | `float` | 默认自动关闭延时（秒）。0 表示不自动关闭。 |
| `Top` | `float` | 顶部通知距离窗口顶部的逻辑像素。 |
| `Bottom` | `float` | 底部通知距离窗口底部的逻辑像素。 |
| `HorizontalOffset` | `float` | 角落通知距离窗口左右边缘的逻辑像素。 |
| `Width` | `float` | 通知卡片宽度。 |
| `Gap` | `float` | 同一位置相邻通知之间的间距。 |
| `MaxCount` | `int` | 一个窗口内最多同时显示的通知数；0 表示不限制。 |
| `ShowProgress` | `bool` | 默认是否显示自动关闭进度条。 |
| `PauseOnHover` | `bool` | 默认是否在鼠标悬停时暂停自动关闭计时。 |
| `ApplicationName` | `string` | 系统通知中使用的默认应用名称。 |
| `Style` | `UIStyle?` | 全部通知卡片的默认外壳样式。 |
| `TitleStyle` | `UIStyle?` | 全部通知标题的默认文本样式。 |
| `DescriptionStyle` | `UIStyle?` | 全部通知正文的默认文本样式。 |
| `ProgressStyle` | `UIStyle?` | 全部自动关闭进度条的默认样式。 |

### NotificationPlacement

> **类型**：枚举

应用窗口内通知的显示位置。

**说明：**

此位置只适用于 TCYM.UI 窗口内通知。操作系统通知的位置由各平台的通知中心决定。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Top` | - | 顶部居中。 |
| `TopLeft` | - | 左上角。 |
| `TopRight` | - | 右上角。 |
| `Bottom` | - | 底部居中。 |
| `BottomLeft` | - | 左下角。 |
| `BottomRight` | - | 右下角。 |

### NotificationType

> **类型**：枚举

通知的语义类型，用于选择默认图标与强调色。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Default` | - | 不强调状态的普通通知。 |
| `Info` | - | 信息通知。 |
| `Success` | - | 成功通知。 |
| `Warning` | - | 警告通知。 |
| `Error` | - | 错误通知。 |

### SystemNotificationCapabilities

> **类型**：类

描述当前系统通知提供程序的能力。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `ProviderName` | `string` | 获取提供程序名称。 |
| `IsSupported` | `bool` | 获取当前环境是否支持该提供程序。 |
| `CanControlPlacement` | `bool` | 获取是否可以控制系统通知在屏幕上的显示位置。 系统通知的位置始终由操作系统或桌面通知服务决定，因此该值固定为 <see langword="false"/>。 |
| `Description` | `string` | 获取提供程序的能力与限制说明。 |

### SystemNotificationResult

> **类型**：类

表示一次系统通知提交的结果。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `exception` | `SystemNotificationResult(             SystemNotificationStatus status,             string providerName,             string message,             Exception?` | 初始化系统通知结果。 |
| `Status` | `SystemNotificationStatus` | 获取结果状态。 |
| `ProviderName` | `string` | 获取处理请求的提供程序名称。 |
| `Message` | `string` | 获取结果说明。 |
| `Exception` | `Exception?` | 获取导致失败的异常；没有异常时为 <see langword="null"/>。 |
| `Succeeded` | `bool` | 获取通知请求是否已被操作系统通知服务接受。 |

### SystemNotificationStatus

> **类型**：枚举

系统通知的提交结果状态。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Submitted` | - | 系统通知服务已经接受请求，但不保证用户实际看到通知。 |
| `Unavailable` | - | 当前平台、桌面会话或通知工具不可用。 |
| `PermissionDenied` | - | 操作系统拒绝了通知权限。 |
| `Failed` | - | 通知提交失败。 |
| `Cancelled` | - | 通知提交已取消。 |
