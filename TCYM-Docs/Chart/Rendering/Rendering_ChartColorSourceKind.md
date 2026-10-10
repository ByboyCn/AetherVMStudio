# ChartColorSourceKind

> **类型**：enum　**命名空间**：`TCYM.UI.Chart.Rendering`　**Chart 版本**：`0.1.1.25`

## 概述

指定颜色由固定画刷、当前上下文自动颜色或继承颜色提供。

## 枚举值

| 名称 | 说明 |
| --- | --- |
| `Auto` | 由消费组件按当前位置和主题解析自动颜色。 |
| `Inherit` | 继承消费组件已经解析的父级颜色。 |
| `Static` | 使用 `Brush` 中的固定画刷。 |
