# DisplayInfo

> **类型**：结构体　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

显示器信息。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Index` | `int` | SDL 显示器索引。 |
| `Width` | `int` | 显示器分辨率宽度（像素）。 |
| `Height` | `int` | 显示器分辨率高度（像素）。 |
| `UsableWidth` | `int` | 显示器可用区域宽度（像素，排除任务栏等系统区域）。 |
| `UsableHeight` | `int` | 显示器可用区域高度（像素，排除任务栏等系统区域）。 |
| `Dpi` | `float` | 对角线 DPI。 |
| `Hdpi` | `float` | 水平 DPI。 |
| `Vdpi` | `float` | 垂直 DPI。 |
| `Scale` | `float` | 缩放系数，1.25 表示 125%。 |
| `IsCurrent` | `bool` | 是否为当前窗口所在显示器。 |
