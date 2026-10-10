# UIPenBoard

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView`

## 概述

支持触控笔压力、橡皮擦以及鼠标/触摸回退的高 DPI 画板组件。 笔迹使用逻辑像素保存，渲染时自动适配窗口布局缩放。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `StrokeColor` | `SKColor` | 当前画笔颜色。 |
| `EraserMode` | `bool` | 鼠标或触摸输入是否使用橡皮擦；触控笔的橡皮擦端会自动识别。 |
| `MinStrokeWidth` | `float` | 最小画笔宽度（逻辑像素）。 |
| `MaxStrokeWidth` | `float` | 最大画笔宽度（逻辑像素）。 |
| `UseFixedStrokeWidth` | `bool` | 是否使用固定画笔宽度。为 true 时忽略触控笔压力并使用 <see cref="FixedStrokeWidth"/>。 |
| `FixedStrokeWidth` | `float` | <see cref="UseFixedStrokeWidth"/> 为 true 时使用的画笔宽度（逻辑像素）。 |
| `EraserWidth` | `float` | 橡皮擦宽度（逻辑像素）。 |
| `PointerPressure` | `float` | 鼠标或无压感触摸输入使用的压力值。 |
| `MinimumPointDistance` | `float` | 连续采样点之间的最小距离（逻辑像素），用于过滤输入抖动。 |
| `PressureSmoothing` | `float` | 压力平滑系数，范围为 0~1。值越小越平滑，值越大越接近设备原始压力。 |
| `StrokeCount` | `int` | 当前可见笔迹数量。 |
| `CanUndo` | `bool` | 是否可以撤销。 |
| `CanRedo` | `bool` | 是否可以重做。 |
| `Changed` | `event Action?` | 画板内容变化时触发。 |
| `ChangedAsync` | `event Func<Task>?` | 画板内容变化时触发的异步事件。 |
| `StrokeCompleted` | `event Action?` | 一条笔迹完成时触发。 |
| `StrokeCompletedAsync` | `event Func<Task>?` | 笔画绘制完成时触发的异步事件。 |
| `HistoryChanged` | `event Action?` | 撤销、重做、清空或完成笔迹导致历史状态变化时触发。 |
| `HistoryChangedAsync` | `event Func<Task>?` | 撤销重做历史变化时触发的异步事件。 |
| `InputSampled` | `event Action<UIPenBoardInputSource, float>?` | 画板采用有效输入采样时触发。可用于确认 Windows 平板实际走 Pen、PenTouch、Touch 或 Mouse 链路。 |
| `InputSampledAsync` | `event Func<UIPenBoardInputSource, float, Task>?` | 采集到输入样本时触发的异步事件。 |

## 方法

### Clear()

```csharp
void Clear()
```

清空画板和重做历史。

### Undo()

```csharp
bool Undo()
```

撤销最近完成的一条笔迹。

**返回：** 成功撤销时返回 <see langword="true"/>。

### Redo()

```csharp
bool Redo()
```

重做最近撤销的一条笔迹。

**返回：** 成功重做时返回 <see langword="true"/>。

### SaveImage(string, SKEncodedImageFormat, int, float, bool)

```csharp
void SaveImage(string filePath, SKEncodedImageFormat format = SKEncodedImageFormat.Png, int quality = 100, float scale = 1f, bool includeBackground = true)
```

将当前画板内容保存为图片文件。导出内容包含所有可见笔迹和橡皮擦效果，不包含组件边框。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `filePath` | `string` | 图片文件保存路径。 |
| `format` | `SKEncodedImageFormat` | 图片编码格式，默认为 PNG。 |
| `quality` | `int` | 图片质量（0~100），仅对有损格式有效。 |
| `scale` | `float` | 相对于画板当前渲染尺寸的导出倍率，默认为 1；例如 2 表示宽高各导出为两倍像素。 |
| `includeBackground` | `bool` | 是否使用画板背景色填充背景；为 false 时导出透明背景。 |

### OnPenEvent(UIPenEvent)

```csharp
void OnPenEvent(UIPenEvent e)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UIPenEvent` |  |

### OnPointerDown(float, float)

```csharp
void OnPointerDown(float x, float y)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### OnPointerMove(float, float)

```csharp
void OnPointerMove(float x, float y)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### OnPointerUp(float, float)

```csharp
void OnPointerUp(float x, float y)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### OnTouchEvent(UITouchEvent)

```csharp
void OnTouchEvent(UITouchEvent e)
```

处理手指绘制，并消费当前触点事件，防止祖先 UIScrollView 在绘制时同步滚动。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UITouchEvent` |  |
