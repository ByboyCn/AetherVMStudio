# UIModal

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

## 概述

对话框组件（参考 Ant Design Modal）。通过静态方法弹出模态对话框， 支持标题、正文、确认 / 取消按钮、遮罩、Esc 关闭、loading、自定义页脚、 以及 Info / Success / Error / Warning / Confirm 五种语义化变体。 <para>用法示例：</para> <code> // 1) 普通对话框 UIModal.Show(new ModalConfig { Title = "提示", Content = "你确认要执行该操作吗?", OnOk = () => { /* 返回 false 可阻止关闭 */ return true; }, OnCancel = () => { /* 用户取消 */ }, }); // 2) 语义化便捷方法 UIModal.Info("通知", "系统更新已完成。"); UIModal.Success("成功", "保存成功!"); UIModal.Error("错误", "连接服务器失败。"); UIModal.Warning("警告", "磁盘空间不足。"); UIModal.Confirm("删除确认", "确定要删除该项目吗？该操作不可恢复。", okType: ModalOkType.Danger, onOk: () => { /*...*/ }); // 3) 全局配置 UIModal.Config(new ModalGlobalConfig { Mask = true, ZIndex = 9500 }); </code>

## 方法

### Config(ModalGlobalConfig)

```csharp
void Config(ModalGlobalConfig config)
```

配置全局默认参数。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `config` | `ModalGlobalConfig` |  |

### Show(ModalConfig)

```csharp
ModalInstance Show(ModalConfig config)
```

弹出一个对话框；返回实例 handle，可用于 .Update() / .Destroy()。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `config` | `ModalConfig` |  |

### Info(string, string, Action?)

```csharp
ModalInstance Info(string title, string content, Action? onOk = null)
```

信息提示对话框（蓝色 info 图标，默认仅显示 OK）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `title` | `string` |  |
| `content` | `string` |  |
| `onOk` | `Action?` |  |

### Info(string, string, Func<Task>)

```csharp
ModalInstance Info(string title, string content, Func<Task> onOkAsync)
```

信息提示对话框；确定回调可异步完成。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `title` | `string` | 对话框标题。 |
| `content` | `string` | 对话框内容。 |
| `onOkAsync` | `Func<Task>` | 点击确定后等待执行的异步回调。 |

**返回：** 用于更新或关闭该对话框的实例。

### Success(string, string, Action?)

```csharp
ModalInstance Success(string title, string content, Action? onOk = null)
```

成功对话框。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `title` | `string` |  |
| `content` | `string` |  |
| `onOk` | `Action?` |  |

### Success(string, string, Func<Task>)

```csharp
ModalInstance Success(string title, string content, Func<Task> onOkAsync)
```

成功对话框；确定回调可异步完成。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `title` | `string` | 对话框标题。 |
| `content` | `string` | 对话框内容。 |
| `onOkAsync` | `Func<Task>` | 点击确定后等待执行的异步回调。 |

**返回：** 用于更新或关闭该对话框的实例。

### Error(string, string, Action?)

```csharp
ModalInstance Error(string title, string content, Action? onOk = null)
```

错误对话框。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `title` | `string` |  |
| `content` | `string` |  |
| `onOk` | `Action?` |  |

### Error(string, string, Func<Task>)

```csharp
ModalInstance Error(string title, string content, Func<Task> onOkAsync)
```

错误对话框；确定回调可异步完成。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `title` | `string` | 对话框标题。 |
| `content` | `string` | 对话框内容。 |
| `onOkAsync` | `Func<Task>` | 点击确定后等待执行的异步回调。 |

**返回：** 用于更新或关闭该对话框的实例。

### Warning(string, string, Action?)

```csharp
ModalInstance Warning(string title, string content, Action? onOk = null)
```

警告对话框。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `title` | `string` |  |
| `content` | `string` |  |
| `onOk` | `Action?` |  |

### Warning(string, string, Func<Task>)

```csharp
ModalInstance Warning(string title, string content, Func<Task> onOkAsync)
```

警告对话框；确定回调可异步完成。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `title` | `string` | 对话框标题。 |
| `content` | `string` | 对话框内容。 |
| `onOkAsync` | `Func<Task>` | 点击确定后等待执行的异步回调。 |

**返回：** 用于更新或关闭该对话框的实例。

### Confirm(string, string, Action?, Action?, ModalOkType, string, string)

```csharp
ModalInstance Confirm(string title, string content, Action? onOk = null, Action? onCancel = null, ModalOkType okType = ModalOkType.Primary, string okText = "确定", string cancelText = "取消")
```

确认对话框（带 OK + Cancel）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `title` | `string` |  |
| `content` | `string` |  |
| `onOk` | `Action?` |  |
| `onCancel` | `Action?` |  |
| `okType` | `ModalOkType` |  |
| `okText` | `string` |  |
| `cancelText` | `string` |  |

### Confirm(string, string, Func<Task>, Func<Task>?, ModalOkType, string, string)

```csharp
ModalInstance Confirm(string title, string content, Func<Task> onOkAsync, Func<Task>? onCancelAsync = null, ModalOkType okType = ModalOkType.Primary, string okText = "确定", string cancelText = "取消")
```

确认对话框；确定和取消回调均可异步完成。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `title` | `string` | 对话框标题。 |
| `content` | `string` | 对话框内容。 |
| `onOkAsync` | `Func<Task>` | 点击确定后等待执行的异步回调。 |
| `onCancelAsync` | `Func<Task>?` | 点击取消后等待执行的异步回调。 |
| `okType` | `ModalOkType` | 确定按钮样式。 |
| `okText` | `string` | 确定按钮文本。 |
| `cancelText` | `string` | 取消按钮文本。 |

**返回：** 用于更新或关闭该对话框的实例。

### DestroyAll()

```csharp
void DestroyAll()
```

关闭所有对话框。

### Destroy(string)

```csharp
void Destroy(string key)
```

关闭指定 Key 的对话框。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `key` | `string` |  |

## 相关类型

### ModalConfig

> **类型**：类

单个对话框的配置参数（参考 Ant Design Modal）。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Title` | `string?` | 对话框标题文本。 |
| `Content` | `string?` | 对话框正文（字符串，会以 UILabel 渲染并自动换行）。 |
| `Body` | `UIElement?` | 自定义正文内容元素。优先级高于 <see cref="Content"/>。 若同时传入，则 Body 渲染在 Content 文本之下。 |
| `Type` | `ModalType` | 对话框类型（决定默认图标与默认页脚布局）。 |
| `OkText` | `string` | 确定按钮文字，默认 "确定"。 |
| `CancelText` | `string` | 取消按钮文字，默认 "取消"。 |
| `OkType` | `ModalOkType` | OK 按钮的视觉类型。 |
| `OnOk` | `Func<bool>?` | 点击确定回调。返回 true 或不返回（void 风格）表示允许关闭； 返回 false 则保持对话框打开（适合表单校验）。 |
| `OnOkAsync` | `Func<Task<bool>>?` | 点击确定时执行的异步回调。返回 <see langword="true"/> 允许关闭，返回 <see langword="false"/> 保持打开；执行期间确认按钮会自动进入禁用状态。 |
| `OnCancel` | `Action?` | 点击取消 / 关闭按钮 / 遮罩 / Esc 时的回调。 |
| `OnCancelAsync` | `Func<Task>?` | 点击取消 / 关闭按钮 / 遮罩 / Esc 时执行并等待的异步回调。 |
| `AfterClose` | `Action?` | 对话框关闭动画结束后的回调。 |
| `AfterCloseAsync` | `Func<Task>?` | 对话框关闭动画结束后的异步通知。 |
| `Width` | `float` | 对话框宽度（像素），默认 416（参考 Ant Design 默认 520，简洁场景常用 416）。 |
| `Centered` | `bool` | 是否垂直居中显示。默认 true。 |
| `Mask` | `bool` | 是否显示遮罩。默认 true。 |
| `MaskClosable` | `bool` | 点击遮罩是否关闭。默认 true。 |
| `Closable` | `bool` | 是否显示右上角关闭按钮。默认 true。 |
| `Keyboard` | `bool` | 是否支持 Esc 键关闭。默认 true。 |
| `HideFooter` | `bool` | 是否隐藏默认页脚（自带的 OK/Cancel 按钮）。 当需要完全自定义页脚时设为 true 并通过 <see cref="FooterContent"/> 注入。 |
| `FooterContent` | `UIElement?` | 自定义页脚元素（设置后会替换默认按钮区）。 |
| `ConfirmLoading` | `bool` | 确认按钮显示 loading 状态（loading 期间禁用按钮）。 |
| `Top` | `float` | 距离顶部的距离（像素）。在 <see cref="Centered"/> = false 时使用，默认 100。 |
| `ZIndex` | `int` | 层叠顺序。默认 9000。 |
| `Key` | `string?` | 对话框唯一 key，用于 Update / Destroy 指定对话框。 |
| `Style` | `UIStyle?` | 对话框面板自定义样式（背景、圆角、阴影等）。 |
| `BodyStyle` | `UIStyle?` | 对话框正文区自定义样式（内边距、字号等）。 |
| `MaskStyle` | `UIStyle?` | 对话框遮罩自定义样式（背景色等）。 |
| `TitleStyle` | `UIStyle?` | 对话框标题自定义样式。 |

### ModalGlobalConfig

> **类型**：类

UIModal 全局默认配置（被单条 <see cref="ModalConfig"/> 覆盖）。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Width` | `float` | 默认对话框宽度。 |
| `Centered` | `bool` | 默认是否垂直居中。 |
| `Top` | `float` | 默认距离顶部的距离（仅 Centered=false 时生效）。 |
| `Mask` | `bool` | 默认是否显示遮罩。 |
| `MaskClosable` | `bool` | 默认遮罩是否可关闭。 |
| `Keyboard` | `bool` | 默认是否可通过 Esc 关闭。 |
| `ZIndex` | `int` | 默认 ZIndex。 |
| `Style` | `UIStyle?` | 全局对话框面板样式（被单条 Style 覆盖）。 |
| `BodyStyle` | `UIStyle?` | 全局对话框正文区样式。 |
| `MaskStyle` | `UIStyle?` | 全局遮罩样式。 |
| `TitleStyle` | `UIStyle?` | 全局标题样式。 |

### ModalInstance

> **类型**：类

单个对话框的实例 handle，可用于运行时更新内容或关闭。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Key` | `string?` | 对话框 Key。 |
| `IsClosed` | `bool` | 是否已关闭。 |

### ModalOkType

> **类型**：枚举

OK 按钮的视觉类型。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Primary` | 0 | 主要按钮（蓝色填充）。 |
| `Danger` | - | 危险按钮（红色填充，用于确认删除等场景）。 |
| `Default` | - | 默认按钮（白底）。 |

### ModalType

> **类型**：枚举

对话框类型。决定默认图标与默认页脚按钮。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `None` | 0 | 普通对话框（默认 OK + Cancel）。 |
| `Info` | - | 信息提示（蓝色 info 图标，默认仅 OK）。 |
| `Success` | - | 成功提示（绿色 check 图标，默认仅 OK）。 |
| `Error` | - | 错误提示（红色 close 图标，默认仅 OK）。 |
| `Warning` | - | 警告提示（黄色 ! 图标，默认仅 OK）。 |
| `Confirm` | - | 确认对话框（黄色 ? 图标，OK + Cancel）。 |
