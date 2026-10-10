# UIJoystickEvent

> **类型**：类　**分类**：Events　**框架版本**：`0.1.1.24`

## 概述

HID 摇杆 / 手柄事件。 同时支持 SDL3 Joystick（原始轴 / 按钮编号）和 Gamepad（标准映射）两种数据模型。 轴值范围：-32768 ~ 32767（Int16），可按需归一化到 -1.0 ~ 1.0。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Type` | `UIJoystickEventType` | 事件类型。 |
| `DeviceType` | `UIHIDDeviceType` | 设备类型（Joystick / Gamepad）。 |
| `DeviceId` | `int` | 设备实例 ID（SDL_JoystickID，同一设备 Joystick 和 Gamepad 共享此 ID）。 |
| `Axis` | `int` | 轴编号（仅 AxisMotion 有效；Gamepad 时为 SDL_GamepadAxis 值）。 |
| `AxisValue` | `short` | 轴值（-32768~32767，仅 AxisMotion 有效）。 |
| `AxisNormalized` | `float` | 归一化轴值（-1.0~1.0，仅 AxisMotion 有效，便于上层直接使用）。 |
| `Hat` | `int` | 帽子编号（仅 HatMotion 有效）。 |
| `HatState` | `UIJoystickHatState` | 帽子状态（仅 HatMotion 有效）。 |
| `Button` | `int` | 按钮编号（仅 ButtonDown / ButtonUp 有效；Gamepad 时为 SDL_GamepadButton 值）。 |
| `Timestamp` | `long` | 事件时间戳（Unix 毫秒）。 |
| `Handled` | `bool` | 是否已被处理。 |
| `axis` | `UIJoystickEvent(             UIJoystickEventType type,             UIHIDDeviceType deviceType,             int deviceId,             int` | 创建摇杆 / 手柄事件。 |

## 方法

### ToString()

```csharp
string ToString()
```

返回事件的字符串表示，便于调试。
