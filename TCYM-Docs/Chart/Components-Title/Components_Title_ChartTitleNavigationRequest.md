# ChartTitleNavigationRequest

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Title`　**Chart 版本**：`0.1.1.25`

## 概述

Title 链接点击产生的不可变宿主导航请求。图表核心不会验证、启动或打开该地址；宿主必须按自身
安全策略处理 `Url`。

## 属性

| 名称 | 说明 |
| --- | --- |
| `ComponentId` | 获取 Title 显式 Id。 |
| `ComponentIndex` | 获取 Title 在同主类型组件中的索引。 |
| `Role` | 获取导航来自主标题还是副标题。 |
| `Target` | 获取宿主打开目标提示。 |
| `Url` | 获取未经图表核心净化或打开的原始地址。 |
