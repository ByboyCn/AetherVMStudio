# AnimationHelper

> **类型**：类　**分类**：Helpers　**框架版本**：`0.1.1.24`

## 概述

动画辅助类：负责所有与样式过渡/动画相关的逻辑。 - 将原来散落在 UIElement 中的动画状态和动画推进逻辑集中到这里，便于维护与测试。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `AppearanceSnapshot` | `class` | 外观快照：表示一组可动画的样式属性。 作为类以便在外部保存引用（避免频繁装箱/复制）。 |
| `AnimationState` | `class` | 表示一个元素当前的动画状态（可在元素上存储一份）。 包括是否正在动画、已用时、持续时长、起始/目标快照、是否正在反向等。 |
| `UpdateResult` | `struct` | Update 返回结果，告诉调用方动画是否在此次调用中完成，以及是否需设置/清除 hover 快照等。 |

## 方法

### SnapshotFromElement(UIElement)

```csharp
AppearanceSnapshot SnapshotFromElement(UIElement el)
```

将指定元素的当前视觉属性采样为一个 AppearanceSnapshot（供启动动画时作为起始快照使用）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `el` | `UIElement` |  |

### ApplySnapshotToElement(UIElement, AppearanceSnapshot, AnimationState?)

```csharp
void ApplySnapshotToElement(UIElement el, AppearanceSnapshot s, AnimationState? state = null)
```

将快照应用到元素（立即生效，不带过渡）。 恢复元素的完整状态，包括背景色（即使是透明的）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `el` | `UIElement` |  |
| `s` | `AppearanceSnapshot` |  |
| `state` | `AnimationState?` |  |

### StartTransition(AnimationState, UIElement, AppearanceSnapshot, float, bool, bool, string?, IReadOnlyList<CssTransitionSpec>?, IReadOnlyCollection<string>?)

```csharp
bool StartTransition(AnimationState state, UIElement el, AppearanceSnapshot target, float duration, bool reversing, bool setHoverAppliedAtEnd, string? timingFunction = null, IReadOnlyList<CssTransitionSpec>? transitions = null, IReadOnlyCollection<string>? animatedProperties = null)
```

启动一次样式过渡动画：将 state 设置为动画目标并记录起始快照。 - 如果 duration 小于等于 0 则直接应用目标并返回 false 表示没有异步动画进行。 - 返回 true 表示状态已置为 Animating，且需要在后续帧调用 UpdateAnimation 推进。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `state` | `AnimationState` |  |
| `el` | `UIElement` |  |
| `target` | `AppearanceSnapshot` |  |
| `duration` | `float` |  |
| `reversing` | `bool` |  |
| `setHoverAppliedAtEnd` | `bool` |  |
| `timingFunction` | `string?` |  |
| `transitions` | `IReadOnlyList<CssTransitionSpec>?` |  |
| `animatedProperties` | `IReadOnlyCollection<string>?` |  |

### UpdateAnimation(AnimationState, UIElement, float)

```csharp
UpdateResult UpdateAnimation(AnimationState state, UIElement el, float deltaSeconds)
```

每帧推进动画状态，并将插值结果应用到元素上。 返回 UpdateResult 告诉调用者动画是否完成以及是否需要处理 hover 标志/快照。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `state` | `AnimationState` |  |
| `el` | `UIElement` |  |
| `deltaSeconds` | `float` |  |


---

# AnimationHelper

> **类型**：类　**分类**：Helpers　**框架版本**：`0.1.1.24`
