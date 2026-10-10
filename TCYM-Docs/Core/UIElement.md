# UIElement

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

组件元素的动画支持部分。

## 方法

### LoadBackgroundImage()

```csharp
void LoadBackgroundImage()
```

加载背景图片（存在则解码到 SKBitmap），并重置缓存的 SKImage。

### Update(float)

```csharp
void Update(float deltaSeconds)
```

每帧更新：处理悬停清理延迟、启动/反转动画，推动子元素更新。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaSeconds` | `float` | 距离上次更新的时间增量（秒）。 |

### HasActiveAnimation()

```csharp
bool HasActiveAnimation()
```

元素是否有激活的动画。子类可重写以汇报自定义动画状态（例如 Segmented 滑块过渡）。 默认实现覆盖内置 animation/transition/keyframe。

### IsHoverActive()

```csharp
bool IsHoverActive()
```

当前是否处于悬停激活或进入动画阶段。

### ApplyHoverStyle(UIStyle?)

```csharp
void ApplyHoverStyle(UIStyle? hover)
```

应用悬停样式：按需合并与动画过渡。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `hover` | `UIStyle?` |  |

### ClearHoverStyle()

```csharp
void ClearHoverStyle()
```

清除悬停样式：若 hover 设置了 display:none，使用延迟清理以避免闪烁。

### ForceClearHover()

```csharp
void ForceClearHover()
```

立即清除悬停状态（不使用延迟）。 如果有 Transition 动画，会执行反向动画恢复到原始状态。

### UpdateHoverSnapshot()

```csharp
void UpdateHoverSnapshot()
```

更新悬停快照为当前元素状态。 当用户在悬停期间通过 UpdateStyle 修改样式时调用此方法， 以确保离开悬停时不会恢复到旧的样式。 注意：如果悬停样式有 Transition，则不更新快照，以便能正确恢复到原始状态。

### HasActiveAnimationRecursive()

```csharp
bool HasActiveAnimationRecursive()
```

递归检查动画状态。


---

# UIElement

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

动画生命周期事件：逐帧仅比较状态，完成属性提交后再执行用户回调。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `OnAnimationStart` | `event Action<UIAnimationEvent>?` | 动画进入有效播放区间，或滚动时间轴反向重新进入有效区间。 |
| `OnAnimationStartAsync` | `event Func<UIAnimationEvent, Task>?` | 动画开始的异步通知，不阻塞本帧绘制。 |
| `OnAnimationIteration` | `event Action<UIAnimationEvent>?` | 有效播放期间跨越迭代边界；一次采样最多通知一次。 |
| `OnAnimationIterationAsync` | `event Func<UIAnimationEvent, Task>?` | 动画迭代的异步通知，不阻塞本帧绘制。 |
| `OnAnimationEnd` | `event Action<UIAnimationEvent>?` | 动画离开有效播放区间。 |
| `OnAnimationEndAsync` | `event Func<UIAnimationEvent, Task>?` | 动画结束的异步通知，不阻塞本帧绘制。 |
| `OnAnimationCancel` | `event Action<UIAnimationEvent>?` | 动画在自然结束前被取消。 |
| `OnAnimationCancelAsync` | `event Func<UIAnimationEvent, Task>?` | 动画取消的异步通知，不阻塞本帧绘制。 |


---

# UIElement

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIElement

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

UIElement 的 Binding V2 与事件绑定入口。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `BindingContext` | `object?` |  |
| `DataContext` | `UIDataContext?` |  |
| `Binding` | `BindingCollection` |  |
| `Events` | `UIEventBindings?` |  |

## 方法

### ClearBindingContext()

```csharp
void ClearBindingContext()
```

清除本地 BindingContext，使元素重新继承父级上下文。

### SetBinding(string, string, BindingMode)

```csharp
void SetBinding(string targetProperty, string sourceProperty, BindingMode mode = BindingMode.OneWay)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `targetProperty` | `string` |  |
| `sourceProperty` | `string` |  |
| `mode` | `BindingMode` |  |

### SetBinding(string, string, BindingMode, object?)

```csharp
void SetBinding(string targetProperty, string sourceProperty, BindingMode mode, object? source)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `targetProperty` | `string` |  |
| `sourceProperty` | `string` |  |
| `mode` | `BindingMode` |  |
| `source` | `object?` |  |

### ClearBinding(IBindableProperty)

```csharp
bool ClearBinding(IBindableProperty targetProperty)
```

移除指定目标属性的声明式绑定。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `targetProperty` | `IBindableProperty` |  |

### UpdateBindingSource(IBindableProperty)

```csharp
void UpdateBindingSource(IBindableProperty targetProperty)
```

对 Explicit 绑定显式请求目标值回写。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `targetProperty` | `IBindableProperty` |  |


---

# UIElement

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIElement

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIElement

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIElement

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

**继承 / 实现**：`IUIEventListener`

## 概述

UI 基类（树节点）。 说明： -通过 partial 拆分职责，主文件仅包含字段、属性、子元素管理与通用辅助方法。 - 子类可重写布局/渲染/事件等虚方法，具体实现见对应 partial 文件。 - 坐标系：X/Y 为相对于父元素的局部坐标，宽高为布局测量结果或显式设置值。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `DefaultTypeface` | `SKTypeface` | 全局默认字体。 |
| `LifetimeToken` | `CancellationToken` | 获取当前元素的生命周期取消令牌。元素进入拥有型释放时令牌会被取消，异步事件处理器可将它 传给网络、磁盘或其它可取消操作，避免页面离开后继续更新已经释放的 UI。 |
| `Parent` | `UIElement?` |  |
| `Children` | `UIElementCollection` |  |
| `IReadOnlyList` | `class UIElementCollection : IList<UIElement>,` | 受控子元素集合。所有写操作都会维护 Parent、Manager、Id 注册并触发布局。 |
| `X` | `float` | 元素相对于父级的 X 坐标。 |
| `Y` | `float` | 元素相对于父级的 Y 坐标。 |
| `Width` | `float` | 元素宽度。设置后视为显式宽度，布局不会覆盖。 |
| `Height` | `float` | 元素高度。设置后视视为显式高度，布局不会覆盖。 |
| `MarginTop` | `float` | 外边距-上 |
| `MarginRight` | `float` | 外边距-右 |
| `MarginBottom` | `float` | 外边距-下 |
| `MarginLeft` | `float` | 外边距-左 |
| `PaddingTop` | `float` | 内边距-上 |
| `PaddingRight` | `float` | 内边距-右 |
| `PaddingBottom` | `float` | 内边距-下 |
| `PaddingLeft` | `float` | 内边距-左 |
| `BackgroundColor` | `SKColor` | 背景颜色（可透明）。 |
| `BorderRadius` | `float` | 圆角半径（像素）。 |
| `BorderTopLeftRadius` | `float` | 左上角圆角半径（像素）。 |
| `BorderTopRightRadius` | `float` | 右上角圆角半径（像素）。 |
| `BorderBottomRightRadius` | `float` | 右下角圆角半径（像素）。 |
| `BorderBottomLeftRadius` | `float` | 左下角圆角半径（像素）。 |
| `BorderColor` | `SKColor` | 边框颜色。 |
| `BorderWidth` | `float` | 边框宽度（像素）。 |
| `BorderStyle` | `string` | 边框样式（solid/dashed/dotted）。 |
| `BorderLeft` | `bool` | 是否绘制左边框。 |
| `BorderTop` | `bool` | 是否绘制上边框。 |
| `BorderRight` | `bool` | 是否绘制右边框。 |
| `BorderBottom` | `bool` | 是否绘制下边框。 |
| `Opacity` | `float` | 不透明度（0~1）。 |
| `BackgroundImageSource` | `string?` | 背景图片路径（可为空）。 |
| `BackgroundImageRepeat` | `string` | 背景图平铺方式（no-repeat/repeat 等）。 |
| `BackgroundImageSize` | `string` | 背景图缩放模式（cover/contain/auto/fill）。 |
| `BackgroundImageOpacity` | `float` | 背景图不透明度（0~1）。 |
| `BackgroundImagePosition` | `string` | 背景图位置（如：left top/50%50%/10px10px）。 |
| `BackgroundImagePositionXIsPercent` | `bool` | 背景图 X位置是否以百分比指定（true 表示0~100%）。 |
| `BackgroundImagePositionXVal` | `float` | 背景图 X位置的取值：当以百分比时为0~100；像素时为具体像素值。 |
| `BackgroundImagePositionYIsPercent` | `bool` | 背景图 Y位置是否以百分比指定（true 表示0~100%）。 |
| `BackgroundImagePositionYVal` | `float` | 背景图 Y位置的取值：当以百分比时为0~100；像素时为具体像素值。 |
| `ZIndex` | `int` | 层叠顺序（同级内从小到大绘制）。 |
| `Position` | `string` | 定位模式（relative/absolute/fixed）。 |
| `Display` | `string` | 显示类型（block/flex/inline/none）。 |
| `OverflowX` | `string?` | 水平方向溢出策略（visible/hidden/scroll/auto），null 表示未设置。 |
| `OverflowY` | `string?` | 垂直方向溢出策略（visible/hidden/scroll/auto），null 表示未设置。 |
| `Left` | `float?` | 左偏移（像素，空表示未设置）。 |
| `Top` | `float?` | 上偏移（像素，空表示未设置）。 |
| `Right` | `float?` | 右偏移（像素，空表示未设置）。 |
| `Bottom` | `float?` | 下偏移（像素，空表示未设置）。 |
| `MinWidth` | `float?` | 最小宽度（像素，空表示未设置）。 |
| `MaxWidth` | `float?` | 最大宽度（像素，空表示未设置）。 |
| `MinHeight` | `float?` | 最小高度（像素，空表示未设置）。 |
| `MaxHeight` | `float?` | 最大高度（像素，空表示未设置）。 |
| `BorderBoxSizing` | `string` | 边框占位策略：border-box（边框在内）或 outside（边框在外）。 |
| `CornerCurve` | `string` | 圆角曲线类型：circular（普通圆角）或 continuous（iOS 风格连续圆角）。 |
| `Font` | `SKTypeface` | 字体。 |
| `FontSize` | `float` | 字号（像素）。 |
| `FontWeight` | `float` | 字重（400 = regular，700 = bold）。渲染时与 Font 的族一起解析出对应字重的 typeface。 |
| `TextColor` | `SKColor` |  |
| `BoxShadowBlur` | `float` | 盒阴影模糊半径。 |
| `BoxShadowColor` | `SKColor` | 盒阴影颜色。 |
| `BoxShadowOffsetX` | `float` | 盒阴影 X 偏移。 |
| `BoxShadowOffsetY` | `float` | 盒阴影 Y 偏移。 |
| `BoxShadowSpread` | `float` | 盒阴影扩展量。 |
| `BoxShadowInset` | `bool` | 是否为内阴影（inset）。 |
| `TextShadowBlur` | `float` | 文本阴影模糊半径（像素）。 |
| `TextShadowColor` | `SKColor` | 文本阴影颜色；透明表示未启用。 |
| `TextShadowOffsetX` | `float` | 文本阴影 X 偏移（像素）。 |
| `TextShadowOffsetY` | `float` | 文本阴影 Y 偏移（像素）。 |
| `Cursor` | `UICursor` | 鼠标光标样式。 |
| `BackdropBlur` | `float` | 背景高斯模糊强度（Backdrop）。 |
| `RenderCacheEnabled` | `bool` | 是否启用渲染缓存（默认 false）。仅在内容变化频率低于绘制频率时启用。 |
| `Style` | `UIStyle?` | 元素样式。设置时会合并类名样式（如有）并应用到元素。 |
| `MouseLeaveWhenEnterChild` | `bool` | 当鼠标从当前元素移动到其子元素时，是否也触发当前元素的 MouseLeave。 默认 false（进入子元素不会触发父元素离开），更符合常见的 UI 行为。 |
| `IsPressed` | `bool` | 是否处于鼠标按下（主键）状态。 |
| `Id` | `string` | id 属性，唯一标识元素。设置时会自动在 UIManager 中注册/注销。 |
| `IReadOnlyList` | `class UIClassNameCollection : IList<string>,` | ClassName 使用的列表兼容类型，同时支持从 List&lt;string&gt; 和空白分隔字符串隐式转换。 |
| `ClassName` | `UIClassNameCollection` |  |
| `IsFocused` | `bool` | 获取当前元素是否拥有键盘焦点。 |
| `AppliedTransforms` | `List<Helpers.Transform>` | 元素当前已应用的变换列表（与 Style.Transforms 分离，记录最后一次应用到元素的真实渲染基线）。 |
| `AppliedTransformCss` | `string` | 元素当前已应用的原始 TransformCss 字符串（记录基线，避免 Style 合并后丢失起始值）。 |

## 方法

### SetTag(string, string)

```csharp
void SetTag(string key, string value)
```

设置元素的临时标签键值（供渐变等扩展特性使用）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `key` | `string` |  |
| `value` | `string` |  |

### GetTag(string)

```csharp
string GetTag(string key)
```

获取元素的临时标签值，不存在则返回空字符串。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `key` | `string` |  |

### GetMousePosition()

```csharp
(float x, float y) GetMousePosition()
```

获取当前鼠标在窗口坐标系中的位置（X,Y）。 若当前存在 UIManager，则返回其实时记录的坐标；否则返回 (0,0)。

### set_Children(List<UIElement>?)

```csharp
void set_Children(List<UIElement>? value)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `value` | `List<UIElement>?` |  |

### ClearExplicitWidth()

```csharp
void ClearExplicitWidth()
```

清除显式宽度，使其可由测量/布局决定。

### ClearExplicitHeight()

```csharp
void ClearExplicitHeight()
```

清除显式高度，使其可由测量/布局决定。

### InvalidateRenderCache()

```csharp
void InvalidateRenderCache()
```

使当前元素及缓存其内容的父级渲染缓存失效；下一次 Render 会重新录制。

### HasClass(string)

```csharp
bool HasClass(string className)
```

判断当前元素是否包含指定类名。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `className` | `string` |  |

### AddClass(string, bool)

```csharp
bool AddClass(string className, bool overrideExplicit = false)
```

为当前元素追加一个类名，并自动重新计算样式。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `className` | `string` | 要追加的类名。 |
| `overrideExplicit` | `bool` | 是否让类样式覆盖显式样式。 |

**返回：** 当类名被成功追加时返回 true；若为空或已存在则返回 false。

### RemoveClass(string, bool)

```csharp
bool RemoveClass(string className, bool overrideExplicit = false)
```

从当前元素移除一个类名，并自动重新计算样式。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `className` | `string` | 要移除的类名。 |
| `overrideExplicit` | `bool` | 是否让类样式覆盖显式样式。 |

**返回：** 当类名被成功移除时返回 true；若不存在则返回 false。

### SetClassNames(IEnumerable<string>, bool)

```csharp
void SetClassNames(IEnumerable<string> classNames, bool overrideExplicit = false)
```

设置当前元素的类名集合并重新计算样式。 逻辑： 1. 去重并保存新的类名列表。 2. 收集所有类对应的样式并合并成一个临时类样式（后出现的类覆盖前面的同名属性）。 3. 创建一个全新的最终样式对象： - 当 overrideExplicit = false:以类样式为基底，再叠加原始显式样式（显式样式优先）。 - 当 overrideExplicit = true :以原始显式样式为基底，再叠加类样式（类样式优先）。 4. 应用最终样式并请求重新布局与重绘。 注意：始终从最初记录的显式样式副本 (_explicitStyle) 开始，避免类样式的 Hover 等属性永久污染显式样式。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `classNames` | `IEnumerable<string>` | 要设置的类名集合。 |
| `overrideExplicit` | `bool` | 是否让类样式覆盖显式样式（true 表示类样式优先）。 |

### AddChild(UIElement)

```csharp
void AddChild(UIElement child)
```

添加一个子元素，自动维护父子关系并触发布局变更。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `child` | `UIElement` |  |

### InsertChild(int, UIElement)

```csharp
void InsertChild(int index, UIElement child)
```

在指定位置插入一个子元素，自动维护父子关系并触发布局变更。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `index` | `int` | 目标插入索引。 |
| `child` | `UIElement` | 要插入的子元素。 |

### RemoveChild(UIElement)

```csharp
void RemoveChild(UIElement child)
```

移除一个子元素，自动维护父子关系并触发布局变更。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `child` | `UIElement` |  |

### RemoveChildAndDispose(UIElement)

```csharp
void RemoveChildAndDispose(UIElement child)
```

移除一个子元素并递归释放其绑定、渲染资源以及 <see cref="IDisposable"/> 生命周期。 对持有原生资源或外部订阅的控件（例如 UIChart）应使用此入口；普通 <see cref="RemoveChild(UIElement)"/> 保留可再次挂载的非 owning 语义。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `child` | `UIElement` |  |

### ClearChildren()

```csharp
void ClearChildren()
```

清理所有子元素，自动维护父子关系并触发布局变更。

### RemoveAllChildren()

```csharp
void RemoveAllChildren()
```

移除所有子元素，并递归释放实现了 IDisposable 的子树对象。

### AddRangeChild(IEnumerable<UIElement>)

```csharp
void AddRangeChild(IEnumerable<UIElement> newChildren)
```

更新子元素集合：清空现有子元素并添加新的集合。 这是一个便捷方法，比单独调用 Clear() 和 AddRange() 更高效，只触发一次布局请求。 线程安全：可以从后台线程调用，会自动请求重绘。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `newChildren` | `IEnumerable<UIElement>` | 要设置的新子元素集合 |

### set_ClassName(List<string>?)

```csharp
void set_ClassName(List<string>? value)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `value` | `List<string>?` |  |

### SetStyle(UIStyle)

```csharp
void SetStyle(UIStyle style)
```

设置元素的样式对象并应用。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `style` | `UIStyle` |  |

### IsDisplayed()

```csharp
bool IsDisplayed()
```

判断元素是否处于显示状态（display != none）。 悬停态可能通过内部 display 覆盖进行控制。

### UpdateStyle(UIStyle)

```csharp
void UpdateStyle(UIStyle updates)
```

更新当前元素的样式，只应用新样式中非默认值的属性。 支持 DefaultUIStyle 和 UpdateUIStyle： - DefaultUIStyle: 使用 MergeWith 合并（受默认值影响） - UpdateUIStyle: 只应用非 null 的属性（不受默认值影响）✅

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `updates` | `UIStyle` | 包含要更新的属性的样式对象。 |


---

# UIElement

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 方法

### SetCssVariable(string, string)

```csharp
void SetCssVariable(string name, string value)
```

设置当前元素的局部 CSS 变量；变量名区分大小写，并由后代元素继承。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `name` | `string` |  |
| `value` | `string` |  |

### RemoveCssVariable(string)

```csharp
void RemoveCssVariable(string name)
```

删除当前元素通过 SetCssVariable 设置的局部覆盖，恢复 CSS 声明或父级继承。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `name` | `string` |  |

### GetCssVariable(string)

```csharp
string? GetCssVariable(string name)
```

读取当前作用域已经计算完成的 CSS 变量；缺失或循环引用时返回 null。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `name` | `string` |  |


---

# UIElement

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

Mouse/Touch/Keyboard 事件处理相关部分。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `OnPointerEvent` | `event Action<UIPointerEvent>?` | 统一公共指针事件，同时覆盖鼠标与触摸输入。 |
| `OnPointerEventAsync` | `event Func<UIPointerEvent, Task>?` | 统一公共指针异步事件，同时覆盖鼠标与触摸输入。 |
| `OnPointerPressed` | `event Action<UIPointerEvent>?` | 统一指针按下事件。 |
| `OnPointerPressedAsync` | `event Func<UIPointerEvent, Task>?` | 统一指针按下异步事件。 |
| `OnPointerReleased` | `event Action<UIPointerEvent>?` | 统一指针抬起事件。 |
| `OnPointerReleasedAsync` | `event Func<UIPointerEvent, Task>?` | 统一指针抬起异步事件。 |
| `OnPointerMoved` | `event Action<UIPointerEvent>?` | 统一指针移动事件。 |
| `OnPointerMovedAsync` | `event Func<UIPointerEvent, Task>?` | 统一指针移动异步事件。 |
| `OnPointerEntered` | `event Action<UIPointerEvent>?` | 统一指针进入事件。 |
| `OnPointerEnteredAsync` | `event Func<UIPointerEvent, Task>?` | 统一指针进入异步事件。 |
| `OnPointerExited` | `event Action<UIPointerEvent>?` | 统一指针离开事件。 |
| `OnPointerExitedAsync` | `event Func<UIPointerEvent, Task>?` | 统一指针离开异步事件。 |
| `OnPointerCanceled` | `event Action<UIPointerEvent>?` | 统一指针取消事件。 |
| `OnPointerCanceledAsync` | `event Func<UIPointerEvent, Task>?` | 统一指针取消异步事件。 |
| `OnClick` | `event Action<UIMouseEvent>?` | 鼠标点击事件，在元素内按下并抬起时触发。 |
| `OnClickAsync` | `event Func<UIMouseEvent, Task>?` | 鼠标点击异步事件，在元素内按下并抬起时触发。 |
| `OnMouseDown` | `event Action<UIMouseEvent>?` | 鼠标按下（任意键）。 |
| `OnMouseDownAsync` | `event Func<UIMouseEvent, Task>?` | 鼠标按下异步事件（任意键）。 |
| `OnMouseUp` | `event Action<UIMouseEvent>?` | 鼠标抬起。 |
| `OnMouseUpAsync` | `event Func<UIMouseEvent, Task>?` | 鼠标抬起异步事件。 |
| `OnMouseMove` | `event Action<UIMouseEvent>?` | 鼠标移动（仅在元素内）。 |
| `OnMouseMoveAsync` | `event Func<UIMouseEvent, Task>?` | 鼠标移动异步事件（仅在元素内）。 |
| `OnMouseEnter` | `event Action<UIMouseEvent>?` | 鼠标进入元素。 |
| `OnMouseEnterAsync` | `event Func<UIMouseEvent, Task>?` | 鼠标进入元素异步事件。 |
| `OnMouseLeave` | `event Action<UIMouseEvent>?` | 鼠标离开元素。 |
| `OnMouseLeaveAsync` | `event Func<UIMouseEvent, Task>?` | 鼠标离开元素异步事件。 |
| `OnTouchStart` | `event Action<UITouchEvent>?` | 触摸开始（Primary 命中）。 |
| `OnTouchStartAsync` | `event Func<UITouchEvent, Task>?` | 触摸开始异步事件（Primary 命中）。 |
| `OnTouchMove` | `event Action<UITouchEvent>?` | 触摸移动（Primary 命中）。 |
| `OnTouchMoveAsync` | `event Func<UITouchEvent, Task>?` | 触摸移动异步事件（Primary 命中）。 |
| `OnTouchEnd` | `event Action<UITouchEvent>?` | 触摸结束（Primary 命中）。 |
| `OnTouchEndAsync` | `event Func<UITouchEvent, Task>?` | 触摸结束异步事件（Primary 命中）。 |
| `OnTouchCancel` | `event Action<UITouchEvent>?` | 触摸取消（不要求命中）。 |
| `OnTouchCancelAsync` | `event Func<UITouchEvent, Task>?` | 触摸取消异步事件（不要求命中）。 |
| `OnPen` | `event Action<UIPenEvent>?` | 笔（触控笔）事件（带压力 / 倾斜 / 橡皮擦 / 笔身按钮，命中时触发）。 |
| `OnPenAsync` | `event Func<UIPenEvent, Task>?` | 笔（触控笔）异步事件（命中时触发）。 |
| `OnFileDrop` | `event Action<UIFileDropEvent>?` | 文件 / 文本拖放事件（命中时触发）。 |
| `OnFileDropAsync` | `event Func<UIFileDropEvent, Task>?` | 文件 / 文本拖放异步事件（命中时触发）。 |
| `OnKeyDown` | `event Action<UIKeyboardEvent>?` | 键盘按下事件。 |
| `OnKeyDownAsync` | `event Func<UIKeyboardEvent, Task>?` | 键盘按下异步事件。 |
| `OnKeyUp` | `event Action<UIKeyboardEvent>?` | 键盘抬起事件。 |
| `OnKeyUpAsync` | `event Func<UIKeyboardEvent, Task>?` | 键盘抬起异步事件。 |
| `OnJoystick` | `event Action<UIJoystickEvent>?` |  |
| `OnJoystickAsync` | `event Func<UIJoystickEvent, Task>?` | 摇杆 / 手柄异步事件。 |

## 方法

### OnPointerDown(float, float)

```csharp
void OnPointerDown(float x, float y)
```

派生类可重写以处理指针按下（局部坐标）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### OnPointerUp(float, float)

```csharp
void OnPointerUp(float x, float y)
```

派生类可重写以处理指针抬起（局部坐标）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### OnPointerMove(float, float)

```csharp
void OnPointerMove(float x, float y)
```

派生类可重写以处理指针移动（局部坐标）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### OnKeyboardEvent(UIKeyboardEvent)

```csharp
void OnKeyboardEvent(UIKeyboardEvent e)
```

键盘事件入口：根据 e.Type 分发并调用虚方法。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UIKeyboardEvent` |  |

### OnMouseEvent(UIMouseEvent)

```csharp
void OnMouseEvent(UIMouseEvent e)
```

鼠标事件入口：将全局坐标转换为局部坐标，进行命中测试并分派。 - Move进入/离开维持 _isMouseInside 状态； - Down/Up仅在命中时触发，Up 时附带 Click； - Enter/Leave 为合成事件。 注意：PointerDown 时 UIManager 已经通过 HitTest选中当前元素，这里不再进行二次 inside 检查，避免由于布局尚未稳定导致初始子元素无法收到按下事件。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UIMouseEvent` |  |

### OnTouchEvent(UITouchEvent)

```csharp
void OnTouchEvent(UITouchEvent e)
```

触摸事件入口：仅使用 Primary 点进行命中测试和分派。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UITouchEvent` |  |

### OnPenEvent(UIPenEvent)

```csharp
void OnPenEvent(UIPenEvent e)
```

笔事件入口：触发订阅者。命中测试与冒泡由 <see cref="UIManager"/> 完成。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UIPenEvent` | 笔事件。 |

### OnJoystickEvent(UIJoystickEvent)

```csharp
void OnJoystickEvent(UIJoystickEvent e)
```

HID 摇杆 / 手柄事件入口：触发订阅者。事件由 UIManager 广播并沿父链冒泡。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UIJoystickEvent` |  |

### OnFileDropEvent(UIFileDropEvent)

```csharp
void OnFileDropEvent(UIFileDropEvent e)
```

文件 / 文本拖放事件入口：触发订阅者。命中测试与冒泡由 <see cref="UIManager"/> 完成。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UIFileDropEvent` | 拖放事件。 |


---

# UIElement

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIElement

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIElement

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIElement

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

多关键帧动画运行时：定义在变更时编译，逐帧只采样已声明属性。


---

# UIElement

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

Layout, measure, positioning, and layout helpers 组件布局相关方法

## 方法

### Measure(float, float)

```csharp
void Measure(float availableWidth, float availableHeight)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `availableWidth` | `float` |  |
| `availableHeight` | `float` |  |

### HitTestGlobal(float, float)

```csharp
bool HitTestGlobal(float screenX, float screenY)
```

使用累计矩阵进行命中测试：把屏幕坐标映射到当前元素局部空间，再做 AABB。 包含父链的平移、2D变换、Zoom。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `screenX` | `float` |  |
| `screenY` | `float` |  |

### LocalToScreen(float, float)

```csharp
SKPoint LocalToScreen(float localX, float localY)
```

将当前元素局部坐标转换为窗口坐标。 该转换与 <see cref="HitTestGlobal(float,float)"/> 使用完全相同的父链、滚动、 transform 与 zoom 矩阵，因此可用于需要与实际渲染位置严格对齐的自定义控件。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `localX` | `float` |  |
| `localY` | `float` |  |

### LocalToScreen(SKPoint)

```csharp
SKPoint LocalToScreen(SKPoint point)
```

将当前元素局部坐标转换为窗口坐标。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `point` | `SKPoint` |  |

### TryScreenToLocal(float, float, SKPoint)

```csharp
bool TryScreenToLocal(float screenX, float screenY, SKPoint point)
```

尝试将窗口坐标转换为当前元素局部坐标。 当父链中包含零缩放等不可逆变换时返回 <see langword="false"/>。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `screenX` | `float` |  |
| `screenY` | `float` |  |
| `point` | `SKPoint` |  |

### TryScreenToLocal(SKPoint, SKPoint)

```csharp
bool TryScreenToLocal(SKPoint point, SKPoint localPoint)
```

尝试将窗口坐标转换为当前元素局部坐标。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `point` | `SKPoint` |  |
| `localPoint` | `SKPoint` |  |

### ScreenToLocal(float, float)

```csharp
SKPoint ScreenToLocal(float screenX, float screenY)
```

将窗口坐标转换为当前元素局部坐标。 当累计矩阵不可逆时抛出 <see cref="InvalidOperationException"/>；输入分派代码通常应优先使用 <see cref="TryScreenToLocal(float,float,out SKPoint)"/>。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `screenX` | `float` |  |
| `screenY` | `float` |  |

### ScreenToLocal(SKPoint)

```csharp
SKPoint ScreenToLocal(SKPoint point)
```

将窗口坐标转换为当前元素局部坐标。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `point` | `SKPoint` |  |

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

### HitTest(float, float)

```csharp
bool HitTest(float x, float y)
```

按相对于元素未变换布局原点的坐标命中，使用与屏幕命中完全相同的变换和祖先裁剪。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### GetAbsoluteBounds()

```csharp
SKRect GetAbsoluteBounds()
```

获取当前元素在全局（窗口）坐标系中的包围矩形。 不考虑 2D/3D 变换，仅使用布局后的 X/Y/Width/Height。

### GetAbsoluteBoundsTransformed()

```csharp
SKRect GetAbsoluteBoundsTransformed()
```

获取当前元素在全局（窗口）坐标系中的包围矩形，并计入自身及祖先的 transform 变换（translate/scale/rotate，含百分比 translate）与 zoom。 用于需要与视觉位置一致的场景（如 Tooltip 悬停区域判定、弹层定位）。 对于无变换的元素，结果与 <see cref="GetAbsoluteBounds"/> 一致。

### IsOutOfViewport(bool, bool)

```csharp
bool IsOutOfViewport(bool considerAncestorClipping = true, bool treatPartialOutAsOut = false)
```

判断元素是否超出可见区域。 - 以窗口区域(根元素 0,0,Root.Width,Root.Height)为基准； - 当 considerAncestorClipping = true 时，再与所有 overflow:hidden 的祖先内容区做交集裁剪； - 当 treatPartialOutAsOut = true 时，只要部分越界也返回 true；否则仅在完全不可见时返回 true。 注意：不考虑 Transform/Zoom 后的视觉外轮廓，仅以布局边框计算。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `considerAncestorClipping` | `bool` |  |
| `treatPartialOutAsOut` | `bool` |  |

### RequestLayout()

```csharp
void RequestLayout()
```

请求重新布局：清除非显式尺寸并向上冒泡，同时标记 UI 脏区。

### RequestRedraw()

```csharp
void RequestRedraw()
```

请求重绘当前元素（线程安全）。 可以从任何线程调用此方法来触发 UI 更新。


---

# UIElement

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIElement

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `EnableRenderTypeProfile` | `bool` | 是否开启分元素类型的渲染耗时统计。 |

## 方法

### Render(SKCanvas)

```csharp
void Render(SKCanvas canvas)
```

渲染入口： 多线程模式下仍在 UI 线程录制。传入画布可能是录制画布，不能依赖真实 Surface； 普通 Skia 图片/字体由录制结果持有，借用像素不得在后台帧完成前改写或释放。 无法满足录制资源约束的自定义原生绘制可覆盖 RequiresSynchronousRendering。 - 过滤不可见场景； - 处理整体不透明度（SaveLayer 合成）； - 用统一矩阵处理 2D 与元素平面的 3D 投影； - 依序绘制背景、伪元素、内容和伪元素； - 最后恢复画布与图层状态。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `canvas` | `SKCanvas` |  |

### DumpAndResetRenderTypeProfile()

```csharp
void DumpAndResetRenderTypeProfile()
```

打印当前累计的分类型渲染耗时并清零（exclusive time，不含后代）。


---

# UIElement

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIElement

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIElement

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 方法

### ApplyStyleWithTransition(UIStyle, UIStyle?)

```csharp
void ApplyStyleWithTransition(UIStyle newStyle, UIStyle? StartStyle)
```

解析并应用带过渡效果的样式更新。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `newStyle` | `UIStyle` | 目标样式 |
| `StartStyle` | `UIStyle?` | 可选的起始样式（在样式 Merge 之前采集） |
