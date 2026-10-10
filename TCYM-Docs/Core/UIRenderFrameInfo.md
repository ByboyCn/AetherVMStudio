# UIRenderFrameInfo

> **类型**：Record　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

最近一次成功绘制/提交的帧（包含离屏导出），请在 UI 线程读取。 不表示窗口已呈现或 GPU 已完成；UsesGpuApi 也不保证驱动使用硬件而非软件实现。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Engine` | `string` | 实际绘制引擎。 |
| `GraphicsApi` | `string` | 实际图形 API。 |
| `UsesGpuApi` | `bool` | 是否通过 GPU API 提交。 |
| `Target` | `string` | RasterBuffer、RasterImage 或 OpenGLFramebuffer。 |
| `PixelWidth` | `int` | 目标物理像素宽度。 |
| `PixelHeight` | `int` | 目标物理像素高度。 |
