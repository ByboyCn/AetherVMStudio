# UITouchPoint

> **类型**：类　**分类**：Events　**框架版本**：`0.1.1.24`

## 概述

单个触摸点的信息

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Id` | `long` | 唯一触摸 ID（系统提供） |
| `DeviceId` | `long` | 产生该触点的设备 ID。SDL 的笔兼容触摸事件使用固定的设备 ID， 可据此与普通手指触摸区分。 |
| `Position` | `SKPoint` | 触摸位置（相对于窗口坐标） |
| `Pressure` | `float` | 触摸压力值（0~1） |
| `IsPrimary` | `bool` | 是否为主要触摸点（第一根手指） |
| `pressure` | `UITouchPoint(             long id,             SKPoint position,             float` | 构造函数，初始化触摸点信息 |

## 方法

### ToString()

```csharp
string ToString()
```

返回触摸点的字符串表示，包含 ID、位置、压力值和是否为主要触摸点等信息，方便调试和日志记录。

**返回：** 触摸点的字符串表示
