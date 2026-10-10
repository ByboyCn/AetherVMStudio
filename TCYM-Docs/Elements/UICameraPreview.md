# UICameraPreview

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView`

## 概述

基于 DirectShow 的 USB 摄像头预览控件。 - 仅在 Windows 上可用； - 使用 SampleGrabber 拉取帧并交给 Skia 渲染，避免原生子窗口盖住 UI； - 默认优先打开首个可用视频输入设备，也可通过 PreferredDeviceId 或 PreferredDeviceName 指定设备。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `PreferredDeviceName` | `string?` | 指定优先打开的摄像头名称。 |
| `PreferredDeviceId` | `string?` | 指定优先打开的摄像头稳定标识；若已设置，则优先于 PreferredDeviceName 生效。 |
| `AutoPlay` | `bool` | 控制是否在首次渲染时自动尝试打开摄像头。 |
| `Stretch` | `StretchMode` | 控制预览画面在控件区域内的拉伸方式。 |
| `MaintainAspectRatio` | `bool` | 控制预览画面是否保持原始纵横比。 |
| `IsPlaying` | `bool` | 当前是否已经成功启动 DirectShow 预览图。 |
| `IsRecording` | `bool` | 当前是否正在把摄像头帧写入视频文件。 |
| `StatusText` | `string` | 当前展示给用户的状态提示文本。 |
| `PlaceholderBackgroundColor` | `SKColor` | 占位态背景色；默认透明。 |

## 方法

### GetVideoInputDeviceInfos()

```csharp
IReadOnlyList<UICameraDeviceInfo> GetVideoInputDeviceInfos()
```

枚举当前系统中的所有视频输入设备信息。

### GetVideoInputDevices()

```csharp
IReadOnlyList<string> GetVideoInputDevices()
```

枚举当前系统中的所有视频输入设备显示名称。

### Play()

```csharp
void Play()
```

创建并运行 DirectShow 预览图，开始接收摄像头帧。

### Stop()

```csharp
void Stop()
```

停止当前摄像头图，并清空已缓存的最后一帧。

### Restart()

```csharp
void Restart()
```

按停止后重建图形的方式重新打开摄像头。

### CapturePhoto(string, SKEncodedImageFormat, int)

```csharp
void CapturePhoto(string filePath, SKEncodedImageFormat format = SKEncodedImageFormat.Png, int quality = 100)
```

将当前摄像头最新一帧保存为图片文件

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `filePath` | `string` | 图片文件保存路径。 |
| `format` | `SKEncodedImageFormat` | 图片编码格式，默认为 PNG。 |
| `quality` | `int` | 图片质量（0-100），仅对有损格式有效，默认为 100。 |

### StartRecordingAsync(string)

```csharp
Task StartRecordingAsync(string filePath)
```

开始把摄像头录制为 AVI 视频文件。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `filePath` | `string` |  |

### Update(float)

```csharp
void Update(float deltaSeconds)
```

推动 AOT 预览图在 UI 更新周期中主动拉取最新帧。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaSeconds` | `float` |  |

### StopRecordingAsync()

```csharp
Task StopRecordingAsync()
```

停止当前 AVI 录像并保留摄像头预览。

### Measure(float, float)

```csharp
void Measure(float availableWidth, float availableHeight)
```

在未设置显式尺寸时，根据当前视频分辨率估算控件大小。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `availableWidth` | `float` |  |
| `availableHeight` | `float` |  |

## 相关类型

### StretchMode

> **类型**：枚举

内容缩放模式枚举： - Contain：按比例缩放以完整显示，可能留边（信箱/柱箱）。 - Cover：按比例缩放以铺满容器，可能裁剪超出部分。 - Fill：不保持比例，直接拉伸填满容器。 - None：不缩放，按原始分辨率绘制（可能超出或留边）。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Contain` | - | 按比例缩放以完整显示，可能留边（信箱/柱箱） |
| `Cover` | - | 按比例缩放以铺满容器，可能裁剪超出部分。 |
| `Fill` | - | 不保持比例，直接拉伸填满容器。 |
| `None` | - | 不缩放，按原始分辨率绘制（可能超出或留边）。 |
