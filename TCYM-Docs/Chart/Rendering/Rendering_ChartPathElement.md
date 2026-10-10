# ChartPathElement

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Rendering`　**Chart 版本**：`0.1.1.25`

## 概述

绘制任意 Skia 路径，并支持填充区域与精确描边命中的场景元素。

## 构造函数

### `ChartPathElement(SkiaSharp.SKPath,Boolean)`

创建路径元素。

| 参数 | 说明 |
| --- | --- |
| `path` | 用于绘制和命中的 Skia 路径。 |
| `ownsPath` | 是否把路径所有权交给元素；为 `true` 时元素释放时也会释放路径。 |

### `ChartPathElement(TCYM.UI.Chart.Rendering.ChartStatefulPathSet)`

从已经完成唯一性与所有权审计的四状态路径集合创建元素。

## 属性

| 名称 | 说明 |
| --- | --- |
| `HitTestTolerance` | 获取或设置描边命中的额外容差（像素）。 |
| `OwnsPath` | 获取元素是否负责释放 `Path`。 |
| `Path` | 获取用于绘制的路径。 |

## 方法

### `ReplacePath(SkiaSharp.SKPath,Boolean)`

原子替换用于绘制与命中的路径；旧路径仅在此前由元素持有所有权时释放。

| 参数 | 说明 |
| --- | --- |
| `path` | 完整构建且尚未释放的新路径。 |
| `ownsPath` | 元素是否接管新路径的释放责任。 |
