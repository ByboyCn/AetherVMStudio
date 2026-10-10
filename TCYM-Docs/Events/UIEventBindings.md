# UIEventBindings

> **类型**：类　**分类**：Events　**框架版本**：`0.1.1.24`

## 概述

声明式事件绑定，用于通过对象初始化器为 <see cref="UIElement"/> 绑定事件处理器。 可与 <see cref="UIElement.Events"/> 属性配合使用。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `AnimationStart` | `Action<UIAnimationEvent>?` | CSS 动画开始事件回调，支持向父元素冒泡。 |
| `AnimationStartAsync` | `Func<UIAnimationEvent, Task>?` | CSS 动画开始的异步通知，不阻塞绘制。 |
| `AnimationIteration` | `Action<UIAnimationEvent>?` | CSS 动画迭代事件回调，支持向父元素冒泡。 |
| `AnimationIterationAsync` | `Func<UIAnimationEvent, Task>?` | CSS 动画迭代的异步通知，不阻塞绘制。 |
| `AnimationEnd` | `Action<UIAnimationEvent>?` | CSS 动画结束事件回调，支持向父元素冒泡。 |
| `AnimationEndAsync` | `Func<UIAnimationEvent, Task>?` | CSS 动画结束的异步通知，不阻塞绘制。 |
| `AnimationCancel` | `Action<UIAnimationEvent>?` | CSS 动画取消事件回调，支持向父元素冒泡。 |
| `AnimationCancelAsync` | `Func<UIAnimationEvent, Task>?` | CSS 动画取消的异步通知，不阻塞绘制。 |
| `PointerEvent` | `Action<UIPointerEvent>?` | 统一指针事件回调，同时覆盖鼠标与触摸输入。 |
| `PointerEventAsync` | `Func<UIPointerEvent, Task>?` | 统一指针事件的异步回调，同时覆盖鼠标与触摸输入。 |
| `PointerPressed` | `Action<UIPointerEvent>?` | 统一指针按下事件回调。 |
| `PointerPressedAsync` | `Func<UIPointerEvent, Task>?` | 统一指针按下事件的异步回调。 |
| `PointerReleased` | `Action<UIPointerEvent>?` | 统一指针抬起事件回调。 |
| `PointerReleasedAsync` | `Func<UIPointerEvent, Task>?` | 统一指针抬起事件的异步回调。 |
| `PointerMoved` | `Action<UIPointerEvent>?` | 统一指针移动事件回调。 |
| `PointerMovedAsync` | `Func<UIPointerEvent, Task>?` | 统一指针移动事件的异步回调。 |
| `PointerEntered` | `Action<UIPointerEvent>?` | 统一指针进入事件回调。 |
| `PointerEnteredAsync` | `Func<UIPointerEvent, Task>?` | 统一指针进入事件的异步回调。 |
| `PointerExited` | `Action<UIPointerEvent>?` | 统一指针离开事件回调。 |
| `PointerExitedAsync` | `Func<UIPointerEvent, Task>?` | 统一指针离开事件的异步回调。 |
| `PointerCanceled` | `Action<UIPointerEvent>?` | 统一指针取消事件回调。 |
| `PointerCanceledAsync` | `Func<UIPointerEvent, Task>?` | 统一指针取消事件的异步回调。 |
| `Click` | `Action<UIMouseEvent>?` | 鼠标点击事件回调。 |
| `ClickAsync` | `Func<UIMouseEvent, Task>?` | 鼠标点击事件的异步回调。 |
| `MouseDown` | `Action<UIMouseEvent>?` | 鼠标按下事件回调。 |
| `MouseDownAsync` | `Func<UIMouseEvent, Task>?` | 鼠标按下事件的异步回调。 |
| `MouseUp` | `Action<UIMouseEvent>?` | 鼠标抬起事件回调。 |
| `MouseUpAsync` | `Func<UIMouseEvent, Task>?` | 鼠标抬起事件的异步回调。 |
| `MouseMove` | `Action<UIMouseEvent>?` | 鼠标移动事件回调。 |
| `MouseMoveAsync` | `Func<UIMouseEvent, Task>?` | 鼠标移动事件的异步回调。 |
| `MouseEnter` | `Action<UIMouseEvent>?` | 鼠标进入元素区域事件回调。 |
| `MouseEnterAsync` | `Func<UIMouseEvent, Task>?` | 鼠标进入元素区域事件的异步回调。 |
| `MouseLeave` | `Action<UIMouseEvent>?` | 鼠标离开元素区域事件回调。 |
| `MouseLeaveAsync` | `Func<UIMouseEvent, Task>?` | 鼠标离开元素区域事件的异步回调。 |
| `TouchStart` | `Action<UITouchEvent>?` | 触摸开始事件回调。 |
| `TouchStartAsync` | `Func<UITouchEvent, Task>?` | 触摸开始事件的异步回调。 |
| `TouchMove` | `Action<UITouchEvent>?` | 触摸移动事件回调。 |
| `TouchMoveAsync` | `Func<UITouchEvent, Task>?` | 触摸移动事件的异步回调。 |
| `TouchEnd` | `Action<UITouchEvent>?` | 触摸结束事件回调。 |
| `TouchEndAsync` | `Func<UITouchEvent, Task>?` | 触摸结束事件的异步回调。 |
| `TouchCancel` | `Action<UITouchEvent>?` | 触摸取消事件回调。 |
| `TouchCancelAsync` | `Func<UITouchEvent, Task>?` | 触摸取消事件的异步回调。 |
| `Pen` | `Action<UIPenEvent>?` | 笔（触控笔）事件回调（带压力 / 倾斜 / 橡皮擦 / 笔身按钮）。 |
| `PenAsync` | `Func<UIPenEvent, Task>?` | 笔（触控笔）事件的异步回调。 |
| `FileDrop` | `Action<UIFileDropEvent>?` | 文件 / 文本拖放事件回调。 |
| `FileDropAsync` | `Func<UIFileDropEvent, Task>?` | 文件 / 文本拖放事件的异步回调。 |
| `KeyDown` | `Action<UIKeyboardEvent>?` | 键盘按下事件回调。 |
| `KeyDownAsync` | `Func<UIKeyboardEvent, Task>?` | 键盘按下事件的异步回调。 |
| `KeyUp` | `Action<UIKeyboardEvent>?` | 键盘抬起事件回调。 |
| `KeyUpAsync` | `Func<UIKeyboardEvent, Task>?` | 键盘抬起事件的异步回调。 |
| `Focus` | `Action?` | 获得焦点事件回调（仅对输入控件有效）。 |
| `FocusAsync` | `Func<Task>?` | 获得焦点事件的异步回调（仅对输入控件有效）。 |
| `Blur` | `Action?` | 失去焦点事件回调（仅对输入控件有效）。 |
| `BlurAsync` | `Func<Task>?` | 失去焦点事件的异步回调（仅对输入控件有效）。 |

## 方法

### AttachTo(UIElement)

```csharp
void AttachTo(UIElement target)
```

将所有非空的事件处理器附加到目标元素的对应事件上。 目标可以是派生类型（例如 <see cref="UIInput"/>），此时会附加额外的焦点类事件。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `target` | `UIElement` | 要附加事件的目标 UI 元素。 |

### DetachFrom(UIElement)

```csharp
void DetachFrom(UIElement target)
```

将所有非空的事件处理器从目标元素上移除。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `target` | `UIElement` | 要移除事件的目标 UI 元素。 |
