# UIJoystickEventType

> **类型**：枚举　**分类**：Events　**框架版本**：`0.1.1.24`

## 概述

HID 摇杆 / 手柄事件类型。 涵盖 SDL3 Joystick（底层原始摇杆）与 Gamepad（标准映射手柄）两类事件。

## 枚举值

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `DeviceAdded` | - | 设备已连接。 |
| `DeviceRemoved` | - | 设备已断开。 |
| `AxisMotion` | - | 轴变化（摇杆 / 扳机移动）。 |
| `HatMotion` | - | 帽子（方向键）变化。 |
| `ButtonDown` | - | 按钮按下。 |
| `ButtonUp` | - | 按钮抬起。 |
