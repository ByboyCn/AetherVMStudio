# UIStyle

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

抽象样式类，用于描述 CSS 风格属性。 所有 UIElement 都应持有一个 UIStyle 实例。 （此类仅保存样式数据，不负责渲染或布局）

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `ImportantProperties` | `HashSet<string>` | 实现类似 CSS 中的 !important 功能的属性集合。 |
| `SetProperties` | `HashSet<string>` | 记录被显式赋值过的属性名集合，用于区分"显式设为默认值"和"从未设置"。 |
| `Variables` | `Dictionary<string, string>?` | 本地 CSS 自定义属性（如 --color）；变量名严格区分大小写。运行时请通过 UpdateStyle 或元素 SetCssVariable 更新。 |
| `Display` | `string` | 显示类型：'block'、'flex'、'inline'、'none' |
| `Position` | `string` | 定位类型：'relative'、'absolute'、'fixed' |
| `Top` | `UnitValue?` | 上边位置（可空，单位为样式单元/逻辑像素） |
| `Left` | `UnitValue?` | 左边位置（可空） |
| `Right` | `UnitValue?` | 右边位置（可空） |
| `Bottom` | `UnitValue?` | 底部位置（可空） |
| `Width` | `UnitValue?` | 宽度（可空；若设置则会作为显式宽度） |
| `Height` | `UnitValue?` | 高度（可空；若设置则会作为显式高度） |
| `MinWidth` | `UnitValue?` | 最小宽度（可空） |
| `MaxWidth` | `UnitValue?` | 最大宽度（可空） |
| `MinHeight` | `UnitValue?` | 最小高度（可空） |
| `MaxHeight` | `UnitValue?` | 最大高度（可空） |
| `Overflow` | `string` | 内容溢出策略：'visible'（显示）、'hidden'（隐藏）、'scroll'、'auto' |
| `OverflowX` | `string?` | 水平方向溢出策略：'visible'、'hidden'、'scroll'、'auto'、null 表示继承 Overflow |
| `OverflowY` | `string?` | 垂直方向溢出策略：'visible'、'hidden'、'scroll'、'auto'、null 表示继承 Overflow |
| `PointerEvents` | `string` | 指针事件处理： 'auto'（默认）接受指针事件， 'none'（禁用所有指针事件）， 'pass-through'（穿透）允许子元素接收事件， 'box-only'（仅盒子）只允许当前元素接收事件，子元素不接收。 |
| `MarginTop` | `UnitValue` | 上外边距（单位为样式单位） |
| `MarginRight` | `UnitValue` | 右外边距 |
| `MarginBottom` | `UnitValue` | 下外边距 |
| `MarginLeft` | `UnitValue` | 左外边距 |
| `PaddingTop` | `UnitValue` | 上内边距（padding） |
| `PaddingRight` | `UnitValue` | 右内边距 |
| `PaddingBottom` | `UnitValue` | 下内边距 |
| `PaddingLeft` | `UnitValue` | 左内边距 |
| `BackgroundColor` | `SKColor` | 背景颜色（SkiaSharp 的 SKColor） |
| `BackgroundGradient` | `string?` | 背景线性渐变定义（例如 "linear-gradient(to right, blue, pink)") |
| `TextGradient` | `string?` | 文本渲染用的渐变（样式属性名为 text-gradient） |
| `BackgroundImage` | `string?` | 背景图片路径（相对或绝对路径），库会尝试加载该路径的图片 |
| `BackgroundRepeat` | `string` | 背景重复策略：'no-repeat'、'repeat'、'repeat-x'、'repeat-y' |
| `BackgroundSize` | `string` | 背景大小：'cover'、'contain'、'auto'、'fill' |
| `BackgroundOpacity` | `float` | 背景图的不透明度（0.0 - 1.0） |
| `BackgroundPosition` | `string` | 背景位置：支持关键字(left/center/right, top/center/bottom)、百分比（50% 50%）或像素值（10px 20px） |
| `Background` | `string?` | CSS background 简写原始值（用于 !important 匹配） |
| `BackdropBlur` | `float` | 背景模糊半径（CSS px）。保留为兼容的快捷属性。 |
| `BackdropFilterCss` | `string` |  |
| `FilterCss` | `string?` | 标准 CSS filter 函数链；空值撤销声明，非法声明保持之前的有效值。 |
| `BackdropFilterHasEffect` | `bool` | 有序函数链中是否包含至少一个非恒等滤镜。 |
| `BackdropSaturate` | `float` | 背景饱和度倍数（1 = 原始）。 |
| `BackdropBrightness` | `float` | 背景亮度倍数（1 = 原始）。 |
| `BackdropContrast` | `float` | 背景对比度倍数（1 = 原始）。 |
| `BackdropGrayscale` | `float` | 背景灰度比例（0 = 原始，1 = 完全灰度）。 |
| `BackdropOpacity` | `float` | 背景滤镜输出不透明度（1 = 原始）。 |
| `BackdropRefraction` | `float` | TCYM 液体玻璃边缘折射强度（CSS px，0 表示关闭）。 |
| `BorderWidth` | `UnitValue` | 边框宽度 |
| `BorderColor` | `SKColor` | 边框颜色 |
| `BorderStyle` | `string` | 边框样式：'solid'、'dashed'、'dotted' |
| `BorderRadius` | `UnitValue` | 圆角半径（统一值） |
| `BorderTopLeftRadius` | `UnitValue` | 左上角圆角 |
| `BorderTopRightRadius` | `UnitValue` | 右上角圆角 |
| `BorderBottomRightRadius` | `UnitValue` | 右下角圆角 |
| `BorderBottomLeftRadius` | `UnitValue` | 左下角圆角 |
| `BorderBoxSizing` | `string` | 边框盒模型："border-box"（边框占用元素内尺寸）或 "outside"（边框绘制在元素外侧） |
| `CornerCurve` | `string` | 圆角曲线类型：circular（普通圆角）或 continuous（iOS 风格连续圆角）。 |
| `BorderLeft` | `bool` | 是否绘制左侧边框（有时需要禁用单侧边框） |
| `BorderTop` | `bool` | 是否绘制上侧边框 |
| `BorderRight` | `bool` | 是否绘制右侧边框 |
| `BorderBottom` | `bool` | 是否绘制下侧边框 |
| `BorderTopWidth` | `UnitValue` | 单独的上边框宽度（优先于统一 BorderWidth），支持 px/%/calc。 |
| `BorderRightWidth` | `UnitValue` | 单独的右边框宽度，未设置时使用统一 BorderWidth。 |
| `BorderBottomWidth` | `UnitValue` | 单独的下边框宽度，未设置时使用统一 BorderWidth。 |
| `BorderLeftWidth` | `UnitValue` | 单独的左边框宽度，未设置时使用统一 BorderWidth。 |
| `BorderTopColor` | `SKColor` | 上边框颜色（独立覆盖 BorderColor）。 |
| `BorderRightColor` | `SKColor` | 右边框颜色（独立覆盖 BorderColor）。 |
| `BorderBottomColor` | `SKColor` | 下边框颜色（独立覆盖 BorderColor）。 |
| `BorderLeftColor` | `SKColor` | 左边框颜色（独立覆盖 BorderColor）。 |
| `BorderTopStyle` | `string` | 上边框样式（solid/dashed/dotted），空字符串表示继承统一 BorderStyle。 |
| `BorderRightStyle` | `string` | 右边框样式（solid/dashed/dotted），空字符串表示继承统一 BorderStyle。 |
| `BorderBottomStyle` | `string` | 下边框样式（solid/dashed/dotted），空字符串表示继承统一 BorderStyle。 |
| `BorderLeftStyle` | `string` | 左边框样式（solid/dashed/dotted），空字符串表示继承统一 BorderStyle。 |
| `BoxShadowColor` | `SKColor` | 阴影颜色 |
| `BoxShadowBlur` | `UnitValue` | 阴影模糊半径 |
| `BoxShadowSpread` | `UnitValue` | 阴影扩展量（spread） |
| `BoxShadowOffsetX` | `UnitValue` | 阴影水平偏移 |
| `BoxShadowOffsetY` | `UnitValue` | 阴影垂直偏移 |
| `BoxShadowInset` | `bool` | 是否为内阴影（inset） |
| `FontFamily` | `SKTypeface?` | 字体（SKTypeface），使用 SKTypeface.Default 表示未指定 |
| `FontSize` | `UnitValue?` | 字体大小（样式单位） |
| `Color` | `SKColor?` | 文本颜色 |
| `FontWeight` | `float` | 字体粗细（数值，常用 400=normal, 700=bold） |
| `Italic` | `bool` | 是否斜体 |
| `TextAlign` | `string` | 文本对齐：'left'、'center'、'right' |
| `WhiteSpace` | `string?` | 空白与换行策略：normal、nowrap、pre、pre-wrap、pre-line、break-spaces；null 保留标签原有行为。 |
| `TextOverflow` | `string?` | 内联文本溢出：clip 或 ellipsis；横排限制宽度，竖排限制高度，并配合 overflow: hidden 使用。 |
| `Direction` | `string?` | 文本基础方向：ltr 或 rtl；null 继承父级，未声明时保留原有行为。 |
| `WritingMode` | `string?` | 文本书写模式：horizontal-tb、vertical-rl、vertical-lr；null 继承父级。 |
| `UserSelect` | `string?` | 用户选择策略：auto、none、text、all、contain；支持 initial、inherit、unset。null 表示未声明，按非继承属性的初始值 auto 求值。 |
| `LineHeight` | `float` | 行高（乘数或像素，当前实现当作乘数参考） |
| `LetterSpacing` | `float` | 字母间距（目前未必被渲染系统使用） |
| `TextDecoration` | `string?` | 文本装饰（underline/line-through/none） |
| `TextShadowColor` | `SKColor` | 文本阴影颜色；透明表示未启用。 |
| `TextShadowOffsetX` | `UnitValue` | 文本阴影水平偏移。 |
| `TextShadowOffsetY` | `UnitValue` | 文本阴影垂直偏移。 |
| `TextShadowBlur` | `UnitValue` | 文本阴影模糊半径。 |
| `Cursor` | `UICursor` | 鼠标指针类型，等价于 CSS `cursor` |
| `TransformCss` | `string?` | CSS transform属性字符串（例如"rotate(45deg) translate(10px, 20px)"） |
| `PctTranslateXCached` | `float` | 从 TransformCss 解析出的百分比形式 translate(X) 系数（例如 -50% → -0.5）。 注意：渲染热路径每帧调用；动画下 TransformCss 每帧变化，不做跨帧缓存。 实现使用 Span 切片避免 ToLower/Substring 分配。 |
| `PctTranslateYCached` | `float` | 从 TransformCss 解析出的百分比形式 translate(Y) 系数。 |
| `Transforms` | `List<Helpers.Transform>` | 解析后的变换列表 |
| `TransformOriginX` | `UnitValue` | 变换原点 X（支持 px/%/calc），默认 50%（center）。 用于 rotate/scale 等变换的中心点。 |
| `TransformOriginY` | `UnitValue` | 变换原点 Y（支持 px/%/calc），默认 50%（center）。 |
| `TransformOriginZ` | `UnitValue` | 三维变换原点的 Z 轴长度，默认为 0，不接受百分比。 |
| `Animation` | `string?` | CSS animation 简写原始值（用于 !important 匹配） |
| `Transition` | `string?` | 过渡定义（例如 "0.2s" 或 "all0.2s"），用于 hover/transition |
| `AnimationName` | `string?` | 动画名称（@keyframes 名称，默认 none） |
| `AnimationDuration` | `float` | 动画时长（秒，默认0） |
| `AnimationTimingFunction` | `string` | 时间函数（默认 ease-out） |
| `AnimationIterationCount` | `string` | 迭代次数（数字或 'infinite'，默认1） |
| `AnimationDelay` | `float` | 延迟时间（秒，默认0） |
| `AnimationFillMode` | `string` | 填充模式（none/forwards/backwards/both，默认 none） |
| `AnimationPlayState` | `string` | 播放状态（running/paused，默认 running） |
| `AnimationDirection` | `string` | 播放方向：normal、reverse、alternate 或 alternate-reverse。 |
| `AnimationTimeline` | `string` | 动画时间轴：auto、none、scroll()、view() 或命名时间轴。 |
| `AnimationRangeStart` | `string` | 时间轴有效范围起点，允许百分比或视图命名范围。 |
| `AnimationRangeEnd` | `string` | 时间轴有效范围终点，允许百分比或视图命名范围。 |
| `AnimationComposition` | `string` | 动画合成方式：replace、add 或 accumulate；默认保留历史变换兼容规则。 |
| `ScrollTimelineName` | `string` | 声明滚动时间轴名称，多个名称通过 CSS 逗号列表定义。 |
| `ScrollTimelineAxis` | `string` | 滚动时间轴方向：block、inline、x 或 y。 |
| `ViewTimelineName` | `string` | 声明以当前元素为观察对象的视图时间轴名称。 |
| `ViewTimelineAxis` | `string` | 视图时间轴方向：block、inline、x 或 y。 |
| `ViewTimelineInset` | `string` | 视图时间轴滚动区域内缩量，支持一个或两个 CSS 长度/百分比。 |
| `TimelineScope` | `string` | 将指定命名时间轴的可见范围扩展到当前元素子树；支持 none、all 或名称列表。 |
| `TransitionProperty` | `string` | 参与过渡的 CSS 属性，默认 all。 |
| `TransitionDuration` | `float` | 过渡时长，单位秒。 |
| `TransitionDelay` | `float` | 过渡延迟，单位秒，允许负数。 |
| `TransitionTimingFunction` | `string` | 过渡缓动函数，默认 ease。 |
| `Keyframes` | `string?` | 内联 keyframes 定义（直接赋值解析，不需要 @keyframes 前缀）。 |
| `Blur` | `UnitValue` | 模糊（像素） |
| `Brightness` | `float` | 亮度倍数（1 = 原始） |
| `Contrast` | `float` | 对比度倍数（1 = 原始） |
| `Saturate` | `float` | 饱和度倍数（1 = 原始） |
| `Grayscale` | `float` | 灰度（0 = 原始，1 = 完全灰度） |
| `Opacity` | `float` | 元素不透明度（0.0 - 1.0） |
| `Zoom` | `float` | 统一缩放系数（基于元素中心进行缩放），默认 1.0。 |
| `FlexDirection` | `string` | 主轴方向：'row' 或 'column' |
| `JustifyContent` | `string` | 主轴上的排列方式（justify-content） |
| `AlignItems` | `string` | 侧轴对齐（align-items） |
| `AlignContent` | `string` | 多行内容的侧轴对齐（align-content） |
| `AlignSelf` | `string` | 自对齐（align-self） |
| `FlexWrap` | `string` | 是否换行（wrap） |
| `FlexGrow` | `float` | 当行内分配剩余空间时的增长因子 |
| `FlexShrink` | `float` | 收缩因子 |
| `FlexBasis` | `UnitValue` | 基准尺寸（flex-basis） |
| `Gap` | `UnitValue` | 简写 gap（单值时，作为 row-gap/column-gap 的统一值） |
| `RowGap` | `UnitValue` | 行间距（row-gap） |
| `ColumnGap` | `UnitValue` | 列间距（column-gap） |
| `Hover` | `UIStyle?` | 悬停时应用的子样式（可为 DefaultUIStyle 的实例） |
| `Active` | `UIStyle?` | 指针按下时应用的子样式，对应 CSS <c>:active</c>。 |
| `Focus` | `UIStyle?` | 获得键盘焦点时应用的子样式，对应 CSS <c>:focus</c>。 |
| `Before` | `UIStyle?` | 伪元素 ::before 的样式块。 |
| `After` | `UIStyle?` | 伪元素 ::after 的样式块。 |
| `Content` | `string?` | 用于伪元素的内容文本（对应 CSS `content`）。 |
| `ZIndex` | `int` | 堆叠顺序（z-index），整数，默认为 0，值越大越靠上 |
| `AppRegion` | `string` | 应用窗口区域提示，例如设置为 "drag" 表示该区域可拖动窗口 |

## 方法

### GetPctTranslate(float, float)

```csharp
void GetPctTranslate(float pctX, float pctY)
```

一次性解析 TransformCss 中的百分比 translate（X、Y），渲染热路径用，避免重复扫描。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `pctX` | `float` |  |
| `pctY` | `float` |  |

### ApplyTo(UIElement)

```csharp
void ApplyTo(UIElement element)
```

将此样式应用到指定元素（例如转为像素并赋值）

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `element` | `UIElement` |  |

### MergeWith(UIStyle)

```csharp
void MergeWith(UIStyle other)
```

将另一个样式对象的属性合并到当前样式中。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `other` | `UIStyle` | 要合并的样式对象。 |

### UpdateStyle(UpdateUIStyle)

```csharp
UIStyle UpdateStyle(UpdateUIStyle other)
```

将另一个 UpdateUIStyle 对象的更新应用到当前样式中。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `other` | `UpdateUIStyle` | 样式 |

### ParseFromCss(string)

```csharp
void ParseFromCss(string cssText)
```

从 CSS 文本解析并写入当前样式（同时更新全局样式设置）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `cssText` | `string` | CSS 样式文本。 |
