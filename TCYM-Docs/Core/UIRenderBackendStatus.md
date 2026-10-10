# UIRenderBackendStatus

> **类型**：Record　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

窗口后端实际选择；不表示已在显示器上呈现，也不代替每帧线程诊断。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Requested` | `UIRenderBackendPreference` | 请求的后端偏好。 |
| `GraphicsApi` | `string` | 实际窗口路径：D3D12、OpenGL、CPU；所有候选失败时为 Unavailable。 |
| `FallbackReason` | `string` | 能力拒绝或回退原因；未发生回退时为空。 |
| `RequestedMultisampleCount` | `int` | 本窗口初始化时请求的 MSAA 数；0 表示关闭。 |
| `ActualMultisampleCount` | `int` | 实际 GPU 绘制 MSAA 数；0 表示关闭或当前使用 CPU，不等同于 D3D12 交换链纹理样本数。 |
