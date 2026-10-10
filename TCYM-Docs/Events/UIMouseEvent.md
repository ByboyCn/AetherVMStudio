# UIMouseEvent

> **类型**：类　**分类**：Events　**框架版本**：`0.1.1.24`

## 概述

鼠标事件对象，封装事件数据（坐标、按钮、滚轮等）

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Type` | `UIMouseEventType` | 事件类型 |
| `X` | `int` | 鼠标 X 坐标（窗口坐标系） |
| `Y` | `int` | 鼠标 Y 坐标（窗口坐标系） |
| `Button` | `UIMouseButton` | 鼠标按键 |
| `WheelDelta` | `int` | 鼠标滚轮滚动量（仅 Wheel 事件有效） |
| `Modifiers` | `UIKeyModifiers` | 事件发生时的键盘修饰键状态。 |
| `Timestamp` | `long` | 事件发生时间戳（毫秒） |
| `Element` | `UIElement?` | 事件目标元素（触发事件的 UI 元素） |
| `button` | `UIMouseEvent(             UIMouseEventType type,             int x,             int y,             UIMouseButton` | 构造一个鼠标事件 |

## 方法

### CloneWith(UIMouseEventType)

```csharp
UIMouseEvent CloneWith(UIMouseEventType newType)
```

便捷复制（例如在UI层派发新的事件时）

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `newType` | `UIMouseEventType` |  |

### CloneWithElement(UIElement?)

```csharp
UIMouseEvent CloneWithElement(UIElement? element)
```

便捷复制并设置新的目标元素

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `element` | `UIElement?` |  |

### ToString()

```csharp
string ToString()
```

重写String
