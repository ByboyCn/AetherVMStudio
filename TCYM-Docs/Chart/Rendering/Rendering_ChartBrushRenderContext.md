# ChartBrushRenderContext

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Rendering`　**Chart 版本**：`0.1.1.25`

## 概述

为画刷提供当前图形包围盒、累计透明度以及图元局部坐标到
`ChartScene` 视口坐标的变换。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Bounds` | 获取待绘图形的元素局部包围盒。 |
| `LocalToSceneMatrix` | 获取元素局部坐标到图表场景视口坐标的矩阵。 |
| `Opacity` | 获取已经规范到 0..1 的累计透明度。 |

## 方法

### `TryGetSceneToLocalMatrix(SkiaSharp.SKMatrix@)`

尝试取得抵消图元局部变换、使 shader 固定在场景视口坐标中的矩阵。

| 参数 | 说明 |
| --- | --- |
| `sceneToLocalMatrix` | 成功时接收场景视口坐标到元素局部坐标的矩阵。 |

**返回：** 当前局部变换可逆时为 `true`。
