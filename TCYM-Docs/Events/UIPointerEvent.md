# UIPointerEvent

> **类型**：类　**分类**：Events　**框架版本**：`0.1.1.24`

## 概述

对外暴露的统一指针事件对象，类似 Avalonia 的 PointerEventArgs。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Type` | `UIPointerEventType` | 事件类型。 |
| `DeviceType` | `UIPointerDeviceType` | 输入设备类型。 |
| `Position` | `SKPoint` | 指针全局位置（窗口坐标系）。 |
| `LocalPosition` | `SKPoint` | 指针局部位置（元素坐标系）。 |
| `X` | `float` | 全局 X 坐标。 |
| `Y` | `float` | 全局 Y 坐标。 |
| `LocalX` | `float` | 局部 X 坐标。 |
| `LocalY` | `float` | 局部 Y 坐标。 |
| `PointerId` | `long` | 统一指针 Id。鼠标固定为 0，触摸为触点 Id。 |
| `IsPrimary` | `bool` | 是否为主指针。 |
| `Pressure` | `float` | 压力值。鼠标默认为 0，触摸透传原始压力。 |
| `Button` | `UIMouseButton` | 鼠标按钮；非鼠标事件时为 None。 |
| `Modifiers` | `UIKeyModifiers` | 键盘修饰键；触摸事件当前固定为 None。 |
| `Timestamp` | `long` | 原始时间戳（毫秒）。 |
| `Element` | `UIElement?` | 当前目标元素。 |
| `Handled` | `bool` | 是否已处理当前指针事件。 对触摸事件会同步回写到底层 UITouchEvent.Handled，避免祖先滚动等默认行为继续执行。 |
| `TouchPoints` | `IReadOnlyList<UITouchPoint>` | 触摸点快照；鼠标事件时为空数组。 |
| `MouseEvent` | `UIMouseEvent?` | 原始鼠标事件；触摸事件时为 null。 |
| `TouchEvent` | `UITouchEvent?` | 原始触摸事件；鼠标事件时为 null。 |
| `element` | `UIPointerEvent(             UIPointerEventType type,             UIPointerDeviceType deviceType,             SKPoint position,             SKPoint localPosition,             UIElement?` | 构造统一指针事件。 |
