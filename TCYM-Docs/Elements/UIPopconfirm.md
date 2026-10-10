# UIPopconfirm

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UITooltip, IDisposable, IUIElementDisposalPreflight`

## 概述

轻量气泡确认框。点击子元素后在其附近显示标题、描述以及确认/取消操作， 并复用 <see cref="UITooltip"/> 的十二向定位、箭头、溢出调整与受控显隐能力。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `RootClassName` | `string` | 组件根节点的默认语义类名。 |
| `ContentClassName` | `string` | 气泡内容根节点的语义类名。 |
| `IconClassName` | `string` | 图标宿主的语义类名。 |
| `MessageClassName` | `string` | 图标与文字消息行的语义类名。 |
| `TextClassName` | `string` | 标题与描述文字列的语义类名。 |
| `TitleClassName` | `string` | 标题宿主的语义类名。 |
| `DescriptionClassName` | `string` | 描述宿主的语义类名。 |
| `ActionsClassName` | `string` | 按钮操作区的语义类名。 |
| `CancelButtonClassName` | `string` | 取消按钮的语义类名。 |
| `OkButtonClassName` | `string` | 确认按钮的语义类名。 |
| `Title` | `string?` | 确认框标题。设置 <see cref="TitleContent"/> 时优先显示自定义元素。 |
| `TitleContent` | `UIElement?` | 自定义标题元素；为空时显示 <see cref="Title"/> 文本。 |
| `Description` | `string?` | 确认操作的补充说明文本。 |
| `DescriptionContent` | `UIElement?` | 自定义描述元素；为空时显示 <see cref="Description"/> 文本。 |
| `Icon` | `UIElement?` | 自定义提示图标；为空时显示默认黄色感叹号。 |
| `ShowIcon` | `bool` | 是否显示提示图标。 |
| `IconColor` | `SKColor` | 默认提示图标颜色。 |
| `OkText` | `string` | 确认按钮文字。 |
| `CancelText` | `string` | 取消按钮文字。 |
| `OkLoadingText` | `string` | 异步确认执行期间的按钮文字。 |
| `OkType` | `PopconfirmOkType` | 确认按钮视觉类型。 |
| `ShowCancel` | `bool` | 是否显示取消按钮。 |
| `Disabled` | `bool` | 是否禁用确认框。禁用时点击触发元素不会打开，已打开的气泡会关闭。 |
| `ConfirmLoading` | `bool` | 手动控制确认按钮的 loading 状态。 |
| `IsConfirmLoading` | `bool` | 当前确认按钮是否处于手动或异步 loading 状态。 |
| `IsActionPending` | `bool` | 当前是否正在等待确认或取消异步回调。 |
| `IsOpen` | `bool` | 当前实际显示状态；禁用状态会返回 false。 |
| `PopupWidth` | `float` | 气泡内容宽度（DIP），默认 240。 |
| `ContentStyle` | `UIStyle?` | 气泡内部内容根节点样式。 |
| `MessageStyle` | `UIStyle?` | 图标与文字所在消息行的样式。 |
| `IconStyle` | `UIStyle?` | 图标宿主样式；自定义 Icon 也会放入该宿主。 |
| `ActionsStyle` | `UIStyle?` | 确认与取消按钮操作区样式。 |
| `TitleStyle` | `UIStyle?` | 标题文本样式；仅应用于内置文本标题。 |
| `DescriptionStyle` | `UIStyle?` | 描述文本样式；仅应用于内置文本描述。 |
| `OkButtonStyle` | `UIStyle?` | 确认按钮自定义样式。 |
| `CancelButtonStyle` | `UIStyle?` | 取消按钮自定义样式。 |
| `OnConfirm` | `Action?` | 点击确认按钮时执行的同步回调。 |
| `OnConfirmAsync` | `Func<Task>?` | 点击确认按钮时执行并等待的异步回调。执行期间自动进入 loading，成功完成后关闭气泡； 取消或抛出异常时保持打开并通过框架异常入口上报。 |
| `OnCancel` | `Action?` | 点击取消按钮时执行的同步回调。 |
| `OnCancelAsync` | `Func<Task>?` | 点击取消按钮时执行并等待的异步回调，成功完成后关闭气泡。 |

## 方法

### Refresh()

```csharp
void Refresh()
```

重新应用文本、图标、操作按钮及自定义样式。

### Measure(float, float)

```csharp
void Measure(float availableWidth, float availableHeight)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `availableWidth` | `float` |  |
| `availableHeight` | `float` |  |

### Layout(float, float, float, float)

```csharp
void Layout(float x, float y, float width, float height)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |
| `width` | `float` |  |
| `height` | `float` |  |

### VerifyCanDispose()

```csharp
void VerifyCanDispose()
```

同时预检 Tooltip overlay 与尚未挂入 overlay 的内部内容树。

### Dispose()

```csharp
void Dispose()
```

直接释放同样遵循预检后提交，且通过重新实现接口避免落回基类预检。

## 相关类型

### PopconfirmOkType

> **类型**：枚举

确认按钮的视觉类型。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Primary` | 0 | 主要按钮（蓝色填充）。 |
| `Danger` | - | 危险按钮（红色填充）。 |
| `Default` | - | 默认按钮（白色背景）。 |
