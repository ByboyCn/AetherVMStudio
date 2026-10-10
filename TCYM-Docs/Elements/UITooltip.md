# UITooltip

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView, IDisposable, IUIElementDisposalPreflight`

## 概述

Tooltip 文字提示组件，支持 hover/click、12 向定位、任意内容与受控显示。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Open` | `bool?` | 受控打开状态。为 null 时走非受控模式。 |
| `DefaultOpen` | `bool` | 非受控模式下的默认打开状态。 |
| `Title` | `string?` | Tooltip 标题文本。 |
| `TooltipContent` | `UIElement?` | 自定义 Tooltip 内容。 |
| `Trigger` | `List<TooltipTrigger>` | Tooltip 触发方式。 |
| `Placement` | `TooltipPlacement` | 弹层位置。 |
| `Arrow` | `bool` | 是否显示箭头。 |
| `Color` | `SKColor` | 背景色。 |
| `PopupTextColor` | `SKColor` | 文本颜色。 |
| `MouseEnterDelay` | `float` | 鼠标移入延迟，单位秒。 |
| `MouseLeaveDelay` | `float` | 鼠标移出延迟，单位秒。 |
| `Offset` | `float` | 气泡与触发器间距。 |
| `OffsetX` | `float` | X 方向额外偏移。 |
| `OffsetY` | `float` | Y 方向额外偏移。 |
| `ArrowSize` | `float` | 箭头尺寸。 |
| `AutoAdjustOverflow` | `bool` | 自动调整弹层位置。 |
| `DestroyOnHidden` | `bool` | 隐藏时销毁弹层。 |
| `MaxPopupWidth` | `float` | 文本内容最大宽度。 |
| `MinPopupWidth` | `float` | 文本内容最小宽度。 |
| `PopupStyle` | `UIStyle?` | 自定义气泡样式。 |
| `ArrowStyle` | `UIStyle?` | 自定义箭头样式。 |
| `OnOpenChange` | `Action<bool>?` | 显示状态变化时触发。 |
| `OnOpenChangeAsync` | `Func<bool, Task>?` | 提示框打开状态变化时触发的异步回调。 |
| `ShowPredicate` | `Func<bool>?` | 可选的显示条件判断。返回 false 时阻止 Tooltip 打开。 |

## 方法

### Update(float)

```csharp
void Update(float deltaTime)
```

每帧更新 Tooltip 的延迟状态、显隐动画与定位。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaTime` | `float` | 距离上一帧的时间间隔（秒）。 |

### VerifyCanDispose()

```csharp
void VerifyCanDispose()
```

释放挂载到 Root 的提示弹层，并解除 UIManager 保存的 outside-click 闭包。
无副作用地验证挂载在 Root 上的提示子树允许拥有型释放。

### Dispose()

```csharp
void Dispose()
```

## 相关类型

### TooltipPlacement

> **类型**：枚举

Tooltip 弹层位置。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Top` | - | 上方居中。 |
| `TopLeft` | - | 上方左对齐。 |
| `TopRight` | - | 上方右对齐。 |
| `Bottom` | - | 下方居中。 |
| `BottomLeft` | - | 下方左对齐。 |
| `BottomRight` | - | 下方右对齐。 |
| `Left` | - | 左侧居中。 |
| `LeftTop` | - | 左侧顶部对齐。 |
| `LeftBottom` | - | 左侧底部对齐。 |
| `Right` | - | 右侧居中。 |
| `RightTop` | - | 右侧顶部对齐。 |
| `RightBottom` | - | 右侧底部对齐。 |

### TooltipTrigger

> **类型**：枚举

Tooltip 触发方式。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Hover` | - | 鼠标悬停触发。 |
| `Click` | - | 点击触发。 |
