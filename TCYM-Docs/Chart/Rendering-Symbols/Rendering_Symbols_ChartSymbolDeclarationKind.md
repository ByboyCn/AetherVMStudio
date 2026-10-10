# ChartSymbolDeclarationKind

> **类型**：enum　**命名空间**：`TCYM.UI.Chart.Rendering.Symbols`　**Chart 版本**：`0.1.1.25`

## 概述

区分内置几何、SVG 路径、外部图片与不绘制四类符号声明。

## 枚举值

| 名称 | 说明 |
| --- | --- |
| `BuiltIn` | 使用图表库内置的轻量几何。 |
| `Image` | 使用 `image://` 后携带的图片源标识。 |
| `None` | 不创建任何场景元素。 |
| `Path` | 使用 `path://` 后携带的 SVG path data。 |
