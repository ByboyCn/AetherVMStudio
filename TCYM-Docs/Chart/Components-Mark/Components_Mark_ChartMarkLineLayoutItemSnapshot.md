# ChartMarkLineLayoutItemSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

保存一条已经完成二维坐标投影、但不附加坐标系裁剪的 markLine 布局项。

## 构造函数

### `ChartMarkLineLayoutItemSnapshot(TCYM.UI.Chart.Components.Mark.ChartMarkLineItemSnapshot,SkiaSharp.SKPoint,SkiaSharp.SKPoint,SkiaSharp.SKRect)`

创建一个与规范 Mark 制品和后续 option 更新深度隔离的线布局项。

| 参数 | 说明 |
| --- | --- |
| `item` | 一维轴线或二维端点线的规范快照。 |
| `start` | 最终图表本地像素起点。 |
| `end` | 最终图表本地像素终点。 |
| `gridBounds` | 宿主二维坐标系的最终有限粗边界；参数名为兼容已有 Cartesian 公共 ABI 保持不变，<br />只记录归属而不裁剪端点。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `CoordinateSystemBounds` | 获取宿主二维坐标系粗边界；屏幕端点允许位于该边界之外。 |
| `End` | 获取最终图表本地像素终点。 |
| `GridBounds` | 获取宿主坐标系粗边界；该兼容名称在 Polar 下返回外圆包围盒，不代表附加了 Grid 裁剪。 |
| `Item` | 获取当前布局独占的一维或二维规范项；一维 Number 已在投影前应用有效 precision。 |
| `Start` | 获取最终图表本地像素起点。 |
