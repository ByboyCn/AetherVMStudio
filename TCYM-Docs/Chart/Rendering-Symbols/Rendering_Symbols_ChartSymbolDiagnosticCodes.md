# ChartSymbolDiagnosticCodes

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Rendering.Symbols`　**Chart 版本**：`0.1.1.25`

## 概述

通用符号底座的稳定诊断代码。

## 字段

| 名称 | 说明 |
| --- | --- |
| `CreationFailed` | 声明有效，但场景元素或样式实例化失败。 |
| `EmptyDeclaration` | 符号文本为空。 |
| `EmptyPathGeometry` | SVG path data 没有可缩放的几何范围。 |
| `EmptyPayload` | `path://` 或 `image://` 后没有载荷。 |
| `ImageResolutionFailed` | 图片解析器明确报告解析失败。 |
| `ImageResolverFailed` | 图片解析器抛出异常。 |
| `ImageResolverRequired` | 创建图片符号时没有提供图片解析器。 |
| `InvalidBounds` | 目标边界包含非有限值或非正尺寸。 |
| `InvalidImage` | 图片解析器返回了无效图片。 |
| `InvalidPathData` | SVG path data 无法被 Skia 解析。 |
| `UnsupportedDeclaration` | 符号名称或协议不受支持。 |
