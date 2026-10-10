# DPIHelper

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

DPI/缩放辅助类。用于在逻辑设备无关像素（dp）与实际像素（px）之间进行转换。 通过调整 <see cref="Scale"/> 可以适配不同屏幕缩放。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Scale` | `float` | 布局缩放系数。在 Per-Monitor V2 模式下保持 1.0（布局使用逻辑像素）， 物理像素映射由渲染层的 canvas.Scale 处理。 |
| `DevicePixelRatio` | `float` | 设备像素比（物理像素 / 逻辑像素）。 保存实际检测到的 DPI 缩放值，用于需要知道真实缩放比例的场景 （如图片分辨率选择、触摸阈值等）。 |

## 方法

### ToPixels(float)

```csharp
float ToPixels(float dp)
```

将 dp（设备无关像素）转换为实际像素（px）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `dp` | `float` |  |

### ToDp(float)

```csharp
float ToDp(float px)
```

将实际像素（px）转换为 dp（设备无关像素）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `px` | `float` |  |
