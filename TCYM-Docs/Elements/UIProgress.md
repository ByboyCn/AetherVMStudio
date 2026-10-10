# UIProgress

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIElement`

## 概述

进度组件，支持条形、圆形、仪表盘、分段、渐变、成功子进度与状态展示。 设计和属性模型参考 Ant Design Progress。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Percent` | `float` | 当前进度百分比，自动限制到 0 到 100。 |
| `Type` | `ProgressType` | 展示类型，默认为 Line。 |
| `Status` | `ProgressStatus` | 状态。Auto 会在 Percent 达到 100 时自动显示 Success。 |
| `ShowInfo` | `bool` | 是否显示百分比文字或状态图标，默认为 true。 |
| `RailColor` | `SKColor?` | 未完成轨道颜色。为空时使用 rgba(0,0,0,0.06)。 |
| `StrokeColor` | `SKColor?` | 已完成轨道颜色。为空时根据 Status 使用默认蓝色、成功色或异常色。 |
| `StrokeGradient` | `ProgressGradient?` | 已完成轨道渐变。设置后优先于 StrokeColor。 |
| `StepColors` | `IReadOnlyList<SKColor>?` | 分段模式下每一段的颜色。颜色数量不足时会重复使用最后一个颜色。 |
| `StrokeLinecap` | `ProgressStrokeLinecap` | 轨迹端点样式，默认为 Round。 |
| `Success` | `ProgressSuccess?` | 已成功完成的子进度配置。 |
| `Size` | `ProgressSize` | 组件尺寸。支持 Medium、Small、单值和宽高配置。 |
| `Steps` | `int` | 分段总数。大于 0 时启用分段模式。 |
| `StepGap` | `float` | 分段间距，单位为逻辑像素，默认为 2。 |
| `Rounding` | `Func<float, int>?` | 分段数量取整函数。为空时使用与 Math.Round 正数行为一致的取整方式。 |
| `Format` | `Func<float, float?, string>?` | 进度文字格式化函数，参数依次为 Percent 和 Success.Percent。 |
| `PercentPosition` | `ProgressPercentPosition` | 条形进度文字位置。 |
| `StrokeWidth` | `float` | Circle / Dashboard 轨迹宽度，占画布直径的百分比，默认为 6。 |
| `GapDegree` | `float` | Dashboard 缺口角度，范围 0 到 295，默认为 75。 |
| `GapPlacement` | `ProgressGapPlacement` | Dashboard 缺口位置，默认为 Bottom。 |
| `InfoFontSize` | `float` | 进度文字字号，单位为逻辑像素。0 表示根据类型和尺寸自动计算。 |
| `InfoColor` | `SKColor?` | 进度文字颜色。为空时外部文字使用 TextColor，内部文字使用白色。 |

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

### Update(float)

```csharp
void Update(float deltaSeconds)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaSeconds` | `float` |  |

## 相关类型

### ProgressGapPlacement

> **类型**：枚举

仪表盘缺口位置。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Top` | - | 顶部。 |
| `Bottom` | - | 底部。 |
| `Start` | - | 起始侧（从左到右布局时为左侧）。 |
| `End` | - | 结束侧（从左到右布局时为右侧）。 |

### ProgressGradient

> **类型**：类

进度轨迹渐变配置。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Colors` | `IReadOnlyList<SKColor>` | 渐变颜色，至少需要两个颜色。 |
| `Positions` | `IReadOnlyList<float>?` | 可选停止点，取值范围 0 到 1，数量应与 Colors 一致。 |
| `Direction` | `string` | 渐变方向，支持 to right、to left、to bottom、to top 以及角度值（如 135deg）。 |
| `direction` | `ProgressGradient(SKColor from, SKColor to, string` | 使用起止颜色快速创建渐变。 |

### ProgressPercentAlign

> **类型**：枚举

条形进度文字的水平对齐方式。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Start` | - | 起始位置。 |
| `Center` | - | 居中位置。 |
| `End` | - | 结束位置。 |

### ProgressPercentPosition

> **类型**：Record

条形进度文字位置配置。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Align` | `ProgressPercentAlign` | 水平对齐方式。 |
| `Type` | `ProgressPercentPositionType` | 相对于轨道的位置。 |
| `Default` | `ProgressPercentPosition` | 默认位置：轨道外侧末尾。 |

### ProgressPercentPositionType

> **类型**：枚举

条形进度文字相对于轨道的位置。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Outer` | - | 轨道外侧，与轨道同一行。 |
| `Inner` | - | 轨道内部。 |
| `Bottom` | - | 轨道下方。 |

### ProgressStatus

> **类型**：枚举

进度组件状态。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Auto` | - | 根据进度自动使用 Normal 或 Success。 |
| `Normal` | - | 普通状态。 |
| `Active` | - | 动态进行中状态，仅对 Line 类型显示动画。 |
| `Success` | - | 成功状态。 |
| `Exception` | - | 异常状态。 |

### ProgressStrokeLinecap

> **类型**：枚举

进度轨迹端点样式。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Round` | - | 圆形端点。 |
| `Butt` | - | 平直端点。 |
| `Square` | - | 方形端点。 |

### ProgressSuccess

> **类型**：类

已成功完成的子进度配置。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Percent` | `float` | 成功子进度百分比，范围 0 到 100。 |
| `StrokeColor` | `SKColor?` | 成功子进度颜色；为空时使用默认成功色。 |

### ProgressType

> **类型**：枚举

进度组件的展示类型。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Line` | - | 条形进度。 |
| `Circle` | - | 圆形进度。 |
| `Dashboard` | - | 带缺口的仪表盘进度。 |
