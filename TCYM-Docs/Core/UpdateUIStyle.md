# UpdateUIStyle

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIStyle`

## 概述

用于增量更新样式的类，所有属性默认为 null（表示未设置）。 与 DefaultUIStyle 不同，UpdateUIStyle 不会有默认值干扰， 只有显式设置的属性才会被应用到目标元素。 使用场景： - element.UpdateStyle(new UpdateUIStyle { Opacity = 1, Transition = "all 0.5s" }); - 只会更新 Opacity 和 Transition，其他属性保持不变 属性跟踪： - 自动记录所有被设置的属性名 - 可通过 GetModifiedProperties() 获取被修改的属性列表

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Variables` | `Dictionary<string, string>?` | 按变量名增量更新本地 CSS 自定义属性；未提供的变量保持原值，名称区分大小写。 |
| `Width` | `UnitValue?` | 更新宽度（支持 px/%/calc）。未设置则不改变现有宽度。 |
| `Height` | `UnitValue?` | 更新高度（支持 px/%/calc）。未设置则不改变现有高度。 |
| `MinWidth` | `UnitValue?` | 更新最小宽度。 |
| `MinHeight` | `UnitValue?` | 更新最小高度。 |
| `MaxWidth` | `UnitValue?` | 更新最大宽度。 |
| `MaxHeight` | `UnitValue?` | 更新最大高度。 |
| `MarginTop` | `UnitValue?` | 更新外边距-上。 |
| `MarginRight` | `UnitValue?` | 更新外边距-右。 |
| `MarginBottom` | `UnitValue?` | 更新外边距-下。 |
| `MarginLeft` | `UnitValue?` | 更新外边距-左。 |
| `PaddingTop` | `UnitValue?` | 更新内边距-上。 |
| `PaddingRight` | `UnitValue?` | 更新内边距-右。 |
| `PaddingBottom` | `UnitValue?` | 更新内边距-下。 |
| `PaddingLeft` | `UnitValue?` | 更新内边距-左。 |
| `Padding` | `IReadOnlyList<UnitValue>?` | 获取或设置四方向内边距快照，索引顺序固定为上、右、下、左。 设置时接受 CSS 标准的一到四项简写；值只通过现有单边属性提交，以复用原有修改跟踪。 四个方向尚未全部设置时，获取结果为 null。 |
| `BackgroundColor` | `SKColor?` | 更新背景颜色。 |
| `BackgroundGradient` | `string?` | 更新背景渐变（CSS语法）。 |
| `BackgroundOpacity` | `float?` | 更新背景不透明度（0~1）。 |
| `BackgroundImage` | `string?` | 更新背景图片路径。 |
| `BackgroundRepeat` | `string?` | 更新背景平铺方式。 |
| `BackgroundSize` | `string?` | 更新背景尺寸。 |
| `BackgroundPosition` | `string?` | 更新背景位置。 |
| `BorderWidth` | `UnitValue?` | 更新边框宽度或四角圆角。 |
| `BorderColor` | `SKColor?` | 更新边框颜色。 |
| `BorderStyle` | `string?` | 更新边框样式（solid/dashed/dotted）。 |
| `BorderRadius` | `UnitValue?` | 更新统一圆角。 |
| `BorderTopLeftRadius` | `UnitValue?` | 更新左上角圆角。 |
| `BorderTopRightRadius` | `UnitValue?` | 更新右上角圆角。 |
| `BorderBottomRightRadius` | `UnitValue?` | 更新右下角圆角。 |
| `BorderBottomLeftRadius` | `UnitValue?` | 更新左下角圆角。 |
| `CornerCurve` | `string?` | 更新圆角曲线类型（circular/continuous）。 |
| `BorderTopWidth` | `UnitValue?` | 更新上边框宽度。 |
| `BorderRightWidth` | `UnitValue?` | 更新右边框宽度。 |
| `BorderBottomWidth` | `UnitValue?` | 更新下边框宽度。 |
| `BorderLeftWidth` | `UnitValue?` | 更新左边框宽度。 |
| `BorderTopColor` | `SKColor?` | 更新上边框颜色。 |
| `BorderRightColor` | `SKColor?` | 更新右边框颜色。 |
| `BorderBottomColor` | `SKColor?` | 更新下边框颜色。 |
| `BorderLeftColor` | `SKColor?` | 更新左边框颜色。 |
| `BorderTopStyle` | `string?` | 更新上边框样式。 |
| `BorderRightStyle` | `string?` | 更新右边框样式。 |
| `BorderBottomStyle` | `string?` | 更新下边框样式。 |
| `BorderLeftStyle` | `string?` | 更新左边框样式。 |
| `FontFamily` | `SKTypeface?` | 更新字体（SKTypeface）。 |
| `FontSize` | `UnitValue?` | 更新字号。 |
| `FontWeight` | `float?` | 更新字重。 |
| `Color` | `SKColor?` | 更新文本颜色。 |
| `TextGradient` | `string?` | 更新文本渐变（CSS）。 |
| `TextAlign` | `string?` | 更新文本对齐方式。 |
| `WhiteSpace` | `string?` | 更新空白与换行策略；null 清除当前声明并恢复标签原有行为。 |
| `TextOverflow` | `string?` | 更新内联文本溢出策略（clip / ellipsis）；竖排时作用于高度方向，null 清除声明。 |
| `Direction` | `string?` | 更新文本基础方向（ltr / rtl）；null 清除声明并恢复继承。 |
| `WritingMode` | `string?` | 更新横排或竖排模式；null 清除声明并恢复继承。 |
| `UserSelect` | `string?` | 更新用户选择策略；可显式设置 null 撤销旧的属性值，并重新按 auto 求值。 |
| `LineHeight` | `float?` | 更新行高。 |
| `LetterSpacing` | `float?` | 更新字间距。 |
| `BoxShadowOffsetX` | `UnitValue?` | 更新阴影 X 偏移。 |
| `BoxShadowOffsetY` | `UnitValue?` | 更新阴影 Y 偏移。 |
| `BoxShadowBlur` | `UnitValue?` | 更新阴影模糊半径。 |
| `BoxShadowSpread` | `UnitValue?` | 更新阴影扩散半径。 |
| `BoxShadowColor` | `SKColor?` | 更新阴影颜色。 |
| `Position` | `string?` | 更新定位方式（relative/absolute/fixed）。 |
| `Top` | `UnitValue?` | 更新 top。 |
| `Left` | `UnitValue?` | 更新 left。 |
| `Right` | `UnitValue?` | 更新 right。 |
| `Bottom` | `UnitValue?` | 更新 bottom。 |
| `ZIndex` | `int?` | 更新层级（z-index）。 |
| `Display` | `string?` | 更新显示类型（display）。 |
| `Overflow` | `string?` | 更新溢出控制（overflow）。 |
| `OverflowX` | `string?` | 更新水平方向溢出控制（overflow-x）。 |
| `OverflowY` | `string?` | 更新垂直方向溢出控制（overflow-y）。 |
| `FlexDirection` | `string?` | 更新主轴方向（flex-direction）。 |
| `FlexWrap` | `string?` | 更新换行（flex-wrap）。 |
| `JustifyContent` | `string?` | 更新主轴对齐（justify-content）。 |
| `AlignItems` | `string?` | 更新交叉轴对齐（align-items）。 |
| `AlignContent` | `string?` | 更新多行对齐（align-content）。 |
| `FlexGrow` | `float?` | 更新 flex-grow。 |
| `FlexShrink` | `float?` | 更新 flex-shrink。 |
| `FlexBasis` | `UnitValue?` | 更新 flex-basis。 |
| `Gap` | `UnitValue?` | 更新 gap（统一间隔）。 |
| `RowGap` | `UnitValue?` | 更新行间距（row-gap）。 |
| `ColumnGap` | `UnitValue?` | 更新列间距（column-gap）。 |
| `Cursor` | `UICursor?` | 更新鼠标指针样式（cursor）。 |
| `PointerEvents` | `string?` | 更新指针事件（pointer-events）。 |
| `Opacity` | `float?` | 更新整体透明度（opacity）。 |
| `Zoom` | `float?` | 更新统一视觉缩放系数（zoom）。 |
| `BackdropBlur` | `float?` | 更新背景虚化强度（backdrop-blur）。 |
| `BackdropSaturate` | `float?` | 更新背景饱和度（backdrop-filter: saturate）。 |
| `BackdropBrightness` | `float?` | 更新背景亮度（backdrop-filter: brightness）。 |
| `BackdropContrast` | `float?` | 更新背景对比度（backdrop-filter: contrast）。 |
| `BackdropGrayscale` | `float?` | 更新背景灰度（backdrop-filter: grayscale）。 |
| `BackdropOpacity` | `float?` | 更新被过滤背景的不透明度（backdrop-filter: opacity）。 |
| `BackdropRefraction` | `float?` | 更新液体玻璃边缘折射强度（-tcym-backdrop-refraction）。 |
| `TransformCss` | `string?` | 更新变换（transform）的 CSS 文本。 |
| `FilterCss` | `string?` | 更新标准元素滤镜链；非法声明不覆盖当前有效样式。 |
| `Transition` | `string?` | 更新过渡（transition）。 |
| `AnimationTimingFunction` | `string?` | 更新动画时间函数（animation-timing-function）。 |
| `AnimationDuration` | `float?` | 更新动画时长（秒）。 |
| `Animation` | `string?` | 更新 CSS animation 简写，支持逗号分隔的多动画。 |
| `AnimationName` | `string?` | 更新动画名称。 |
| `AnimationDelay` | `float?` | 更新动画延迟（秒）。 |
| `AnimationIterationCount` | `string?` | 更新动画迭代次数，允许小数或 infinite。 |
| `AnimationDirection` | `string?` | 更新动画播放方向。 |
| `AnimationFillMode` | `string?` | 更新动画填充模式。 |
| `AnimationPlayState` | `string?` | 更新动画播放状态。 |
| `AnimationTimeline` | `string?` | 增量更新 animation-timeline；空值表示不修改原声明。 |
| `AnimationRangeStart` | `string?` | 增量更新 animation-range-start；空值表示不修改原声明。 |
| `AnimationRangeEnd` | `string?` | 增量更新 animation-range-end；空值表示不修改原声明。 |
| `AnimationComposition` | `string?` | 增量更新 animation-composition；空值表示不修改原声明。 |
| `ScrollTimelineName` | `string?` | 增量更新 scroll-timeline-name；空值表示不修改原声明。 |
| `ScrollTimelineAxis` | `string?` | 增量更新 scroll-timeline-axis；空值表示不修改原声明。 |
| `ViewTimelineName` | `string?` | 增量更新 view-timeline-name；空值表示不修改原声明。 |
| `ViewTimelineAxis` | `string?` | 增量更新 view-timeline-axis；空值表示不修改原声明。 |
| `ViewTimelineInset` | `string?` | 增量更新 view-timeline-inset；空值表示不修改原声明。 |
| `TimelineScope` | `string?` | 增量更新 timeline-scope；空值表示不修改原声明。 |
| `TransitionProperty` | `string?` | 更新参与过渡的 CSS 属性。 |
| `TransitionDuration` | `float?` | 更新过渡时长（秒）。 |
| `TransitionDelay` | `float?` | 更新过渡延迟（秒）。 |
| `TransitionTimingFunction` | `string?` | 更新过渡缓动函数。 |
| `AppRegion` | `string?` | 更新窗口拖拽区域（app-region）。 |
| `Hover` | `UIStyle?` | 更新 Hover 样式（可显式设置为 null）。 |
| `Active` | `UIStyle?` | 更新 Active 样式（可显式设置为 null）。 |
| `Focus` | `UIStyle?` | 更新 Focus 样式（可显式设置为 null）。 |
| `Before` | `UIStyle?` | 更新 Before 样式（可显式设置为 null）。 |
| `After` | `UIStyle?` | 更新 After 样式（可显式设置为 null）。 |

## 方法

### GetModifiedProperties()

```csharp
IReadOnlyCollection<string> GetModifiedProperties()
```

获取所有被显式设置的属性名列表。

### IsPropertyModified(string)

```csharp
bool IsPropertyModified(string propertyName)
```

检查指定属性是否被设置。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `propertyName` | `string` |  |

### ClearModifiedProperties()

```csharp
void ClearModifiedProperties()
```

清空修改记录（用于重置跟踪状态）。

### ToDefaultStyle()

```csharp
DefaultUIStyle ToDefaultStyle()
```

将当前 UpdateUIStyle 转换为 DefaultUIStyle。 只有被跟踪（被设置）的非 null 属性才会被设置到 DefaultUIStyle。

### UpdateStyle(DefaultUIStyle?)

```csharp
DefaultUIStyle UpdateStyle(DefaultUIStyle? style)
```

将当前 UpdateUIStyle 中被显式设置的属性更新到 DefaultUIStyle 中。 只复制被跟踪的非 null 属性。 如果 style 为 null，则创建新的 DefaultUIStyle。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `style` | `DefaultUIStyle?` |  |

### CloneStyle(UpdateUIStyle)

```csharp
UpdateUIStyle CloneStyle(UpdateUIStyle original)
```

创建 UpdateUIStyle 的深拷贝。 只复制被修改（设置）的属性。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `original` | `UpdateUIStyle` | 要复制的原始样式 |

**返回：** 新的 UpdateUIStyle 实例
