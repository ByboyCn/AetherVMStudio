# UIImage

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView, IDisposable`

## 概述

Image 图片组件。支持本地资源、HTTP(S) 图片、GIF/APNG/WebP 等多帧图片、缩放、旋转和复制到剪贴板。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Source` | `string?` | 图片地址。支持 http://、https://、res:// 嵌入资源、绝对路径和相对资源路径。 |
| `ImageBytes` | `byte[]?` | 图片原始字节。设置后优先于 Source。 |
| `Alt` | `string` | 图片加载失败时显示的替代文本。 |
| `ShowLoadingPlaceholder` | `bool` | 是否在远程图片下载或图片解码期间显示加载占位层。 |
| `LoadingText` | `string` | 图片加载期间显示的文字。设置为空字符串可隐藏文字，仅保留加载背景。 |
| `LoadingBackgroundColor` | `SKColor` | 加载占位层的背景颜色，默认透明。 |
| `LoadingHighlightColor` | `SKColor` | 加载占位层中流动高光的颜色。设置为透明色可关闭高光动画。 |
| `LoadingTextColor` | `SKColor` | 加载文字颜色。 |
| `LoadingFontSize` | `float` | 加载文字字号。小于等于 0 时跟随 UIImage.FontSize。 |
| `MaxRemoteImageBytes` | `long` | 单张远程图片允许下载的最大字节数。小于等于 0 时使用默认的 64 MB 限制。 |
| `ObjectFit` | `UIImageFit` | 图片在内容区域中的适配方式。 |
| `ObjectPositionX` | `float` | 水平定位，0 表示左侧，0.5 居中，1 表示右侧。 |
| `ObjectPositionY` | `float` | 垂直定位，0 表示顶部，0.5 居中，1 表示底部。 |
| `AutoPlay` | `bool` | 是否自动播放多帧图片。 |
| `PlaybackRate` | `float` | 播放速度倍率。 |
| `EnableWheelZoom` | `bool` | 鼠标滚轮是否控制缩放。 |
| `WheelZoomModifiers` | `UIKeyModifiers` | 触发滚轮缩放所需的修饰键。默认 Ctrl+滚轮；设置为 None 时普通滚轮即可缩放。 |
| `ShowToolbar` | `bool` | 是否显示内置工具条。 |
| `ToolbarAlwaysVisible` | `bool` | 工具条是否一直显示。false 时鼠标悬停在图片上显示，离开后隐藏。 |
| `ShowCopyButton` | `bool` | 是否显示复制按钮。 |
| `Scale` | `float` | 当前缩放倍率。 |
| `MinScale` | `float` | 最小缩放倍率。 |
| `MaxScale` | `float` | 最大缩放倍率。 |
| `ScaleStep` | `float` | 每次缩放变化量。 |
| `RotationDegrees` | `float` | 当前旋转角度，单位为度。 |
| `RotateStep` | `float` | 每次旋转变化量，单位为度。 |
| `OnLoad` | `Action<UIImage>?` | 图片加载完成事件。 |
| `OnLoadAsync` | `Func<UIImage, Task>?` | 图片加载完成异步回调。 |
| `OnError` | `Action<UIImage, string>?` | 图片加载失败事件。 |
| `OnErrorAsync` | `Func<UIImage, string, Task>?` | 图片加载失败异步回调。 |
| `OnTransformChanged` | `Action<UIImage>?` | 缩放或旋转变化事件。 |
| `OnTransformChangedAsync` | `Func<UIImage, Task>?` | 缩放或旋转变化异步回调。 |
| `OnCopy` | `Action<UIImage, bool>?` | 复制完成事件，参数表示是否成功。 |
| `OnCopyAsync` | `Func<UIImage, bool, Task>?` | 复制完成异步回调。 |
| `OnToolbarActionCompleted` | `Action<UIImage, UIImageToolbarAction, bool>?` | 内置工具条动作完成事件。参数依次为图片实例、工具条动作、动作是否成功。 |
| `OnToolbarActionCompletedAsync` | `Func<UIImage, UIImageToolbarAction, bool, Task>?` | 内置工具栏动作完成异步回调。 |
| `IsAnimated` | `bool` | 当前是否为多帧图片。 |
| `IsLoading` | `bool` | 当前是否正在后台加载或解码图片。 |
| `IsCopying` | `bool` | 当前是否正在后台复制当前帧到剪贴板。 |
| `NaturalWidth` | `int` | 当前图片自然宽度。 |
| `NaturalHeight` | `int` | 当前图片自然高度。 |

## 方法

### ZoomIn()

```csharp
void ZoomIn()
```

放大图片。

### ZoomOut()

```csharp
void ZoomOut()
```

缩小图片。

### RotateLeft()

```csharp
void RotateLeft()
```

向左旋转图片。

### RotateRight()

```csharp
void RotateRight()
```

向右旋转图片。

### ResetTransform()

```csharp
void ResetTransform()
```

重置缩放和旋转。

### CopyToClipboard()

```csharp
bool CopyToClipboard()
```

启动复制当前帧到系统剪贴板。返回值表示是否已成功发起复制，最终结果通过 OnCopy 回调通知。

### Reload()

```csharp
void Reload()
```

重新加载图片。

### Dispose()

```csharp
void Dispose()
```

释放当前图片帧。

### Measure(float, float)

```csharp
void Measure(float availableWidth, float availableHeight)
```

根据图片自然尺寸和显式宽高计算组件尺寸。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `availableWidth` | `float` |  |
| `availableHeight` | `float` |  |

### Update(float)

```csharp
void Update(float deltaSeconds)
```

更新多帧图片播放进度。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaSeconds` | `float` |  |

### OnMouseEvent(UIMouseEvent)

```csharp
void OnMouseEvent(UIMouseEvent e)
```

处理滚轮缩放和内置工具条交互。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UIMouseEvent` |  |

## 相关类型

### UIImageFit

> **类型**：枚举

图片适配模式，对应 CSS object-fit 的常用取值。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Contain` | - | 保持图片比例完整显示在内容区域内。 |
| `Cover` | - | 保持图片比例并覆盖整个内容区域。 |
| `Fill` | - | 拉伸图片填满内容区域。 |
| `None` | - | 使用图片原始尺寸显示。 |
| `ScaleDown` | - | 在图片大于内容区域时等比缩小，否则使用原始尺寸。 |

### UIImageToolbarAction

> **类型**：枚举

图片工具条动作。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `ZoomOut` | - | 缩小图片。 |
| `ZoomIn` | - | 放大图片。 |
| `RotateLeft` | - | 向左旋转图片。 |
| `RotateRight` | - | 向右旋转图片。 |
| `Reset` | - | 重置缩放和旋转。 |
| `Copy` | - | 复制当前图片帧到剪贴板。 |
