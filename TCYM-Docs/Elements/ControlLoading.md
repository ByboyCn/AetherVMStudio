# ControlLoading

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`


---

# ControlLoading

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView, IDisposable`

## 概述

蓝、橙双圆点旋转缩放加载动画，对应 Electron 的 ControlLoading。 默认绝对定位覆盖父容器，居中绘制 35dp 动画，并对背后的内容施加 1dp 模糊。 全部使用 C# 和 SkiaSharp 实现，无需加载 CSS、图片或 WebView。

## 说明

将控件加入 Position="relative" 的容器即可显示加载遮罩；通过 Style = new UpdateUIStyle { Display = "none" } 隐藏。 可用 UpdateUIStyle 修改定位、宽高、BackdropBlur 等样式，以作为普通行内控件使用。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `SizeLoader` | `float` | 中央动画的边长（dp），默认 35；不改变遮罩覆盖范围。 |
| `DurationSec` | `float` | 旋转一周及缩放一个周期的时长（秒），默认 1；修改时保留当前相位。 |
| `PrimaryColor` | `SKColor` | 上方圆点颜色，默认 #03A9F4；支持颜色自身的 Alpha。 |
| `SecondaryColor` | `SKColor` | 下方圆点颜色，默认 #FF9800，其缩放比上方圆点延迟半个周期。 |
| `IsAnimating` | `bool` | 是否推进动画，默认 true；暂停时保留当前画面及遮罩，恢复时继续播放。 |

## 方法

### Restart()

```csharp
void Restart()
```

重置旋转、缩放和橙色圆点的首次延迟，不改变暂停状态。

### Measure(float, float)

```csharp
void Measure(float availableWidth, float availableHeight)
```

同步运行时布局 DPI，使背景模糊与自绘圆点保持相同缩放。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `availableWidth` | `float` |  |
| `availableHeight` | `float` |  |

### Update(float)

```csharp
void Update(float deltaSeconds)
```

使用框架帧时钟推进动画；暂停、隐藏及离开视口时停止推进。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaSeconds` | `float` |  |

### HasActiveAnimation()

```csharp
bool HasActiveAnimation()
```

向框架报告自绘动画，确保空闲调度和缓存识别持续运动的控件。

### Dispose()

```csharp
void Dispose()
```

释放复用的 Skia 画笔；可重复调用。
