# UICarouselDotContext

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

## 概述

自定义 Carousel 指示点模板的上下文。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Index` | `int` | 当前指示点索引。 |
| `ActiveIndex` | `int` | 当前激活轮播项索引。 |
| `Count` | `int` | 轮播项总数。 |
| `IsActive` | `bool` | 当前指示点是否处于激活态。 |
| `AutoplayProgress` | `float` | 当前自动播放进度，范围为 0 到 1。 |
| `DotColor` | `SKColor` | 默认指示点颜色。 |
| `ActiveDotColor` | `SKColor` | 激活指示点颜色。 |
| `GoTo` | `Action` | 切换到当前指示点对应轮播项的方法。 |
