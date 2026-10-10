# UIRenderBackendPreference

> **类型**：枚举　**分类**：Enums　**框架版本**：`0.1.1.24`

## 概述

新窗口的后端偏好；不可用时允许回退，实际选择见管理器诊断。

## 枚举值

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Auto` | - | Windows 优先 D3D12，再 OpenGL/CPU；Linux/macOS 使用 OpenGL，不可用时回退 CPU。 |
| `Direct3D12` | - | 优先 Windows D3D12，缺失能力时回退 OpenGL/CPU。 |
| `OpenGL` | - | 保留 OpenGL 优先路径。 |
| `CPU` | - | 强制 CPU，不创建设备或 GL 上下文。 |
