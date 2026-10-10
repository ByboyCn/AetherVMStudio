# UIPenEvent

> **类型**：类　**分类**：Events　**框架版本**：`0.1.1.24`

## 概述

笔（触控笔）事件。相较鼠标 / 触摸，额外携带压力、倾斜、橡皮擦端与笔身按钮等真实笔数据。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Type` | `UIPenEventType` | 事件类型。 |
| `Position` | `SKPoint` | 笔位置（渲染坐标）。 |
| `Pressure` | `float` | 笔尖压力（0~1，非压感设备落笔时通常为 1）。 |
| `TiltX` | `float` | X 方向倾斜角（度，约 -90~90）。 |
| `TiltY` | `float` | Y 方向倾斜角（度，约 -90~90）。 |
| `IsEraser` | `bool` | 是否正在使用橡皮擦端。 |
| `IsTipDown` | `bool` | 笔尖是否接触屏幕。 |
| `Button` | `int` | 触发的笔身按钮编号（仅 ButtonDown / ButtonUp 有效，其它为 0）。 |
| `PenId` | `long` | 笔设备 ID（区分多支笔）。 |
| `Timestamp` | `long` | 事件时间戳（Unix 毫秒）。 |
| `Handled` | `bool` | 是否已被处理；置 true 后可阻止父级容器的默认行为。 |
| `pressure` | `UIPenEvent(             UIPenEventType type,             SKPoint position,             float` | 创建笔事件。 |

## 方法

### ToString()

```csharp
string ToString()
```

返回笔事件的字符串表示，便于调试。

**返回：** 笔事件的字符串表示。
