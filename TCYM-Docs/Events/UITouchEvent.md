# UITouchEvent

> **类型**：类　**分类**：Events　**框架版本**：`0.1.1.24`

## 概述

触摸事件（支持多点触控）

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Type` | `UITouchEventType` | 事件类型（开始、移动、结束、取消） |
| `TouchPoints` | `IReadOnlyList<UITouchPoint>` | 当前触摸点集合（多点触控） |
| `Primary` | `UITouchPoint` | 当前主要触摸点（通常为第一个） |
| `Timestamp` | `long` | 触摸时间戳 |
| `Handled` | `bool` | 子元素是否已处理此事件。设为 true 后，父级容器（如 UIScrollView）应跳过滚动等默认行为。 |
| `timestamp` | `UITouchEvent(UITouchEventType type, IReadOnlyList<UITouchPoint> touchPoints, long` | 构造函数，初始化触摸事件信息，包括事件类型、触摸点集合和时间戳。时间戳默认为当前时间的 Unix 时间戳（毫秒）。提供了一个方便的 ToString 方法用于调试输出。 |

## 方法

### ToString()

```csharp
string ToString()
```

返回触摸事件的字符串表示，包含事件类型、触摸点数量和时间戳等信息，方便调试和日志记录。

**返回：** 触摸事件的字符串表示
