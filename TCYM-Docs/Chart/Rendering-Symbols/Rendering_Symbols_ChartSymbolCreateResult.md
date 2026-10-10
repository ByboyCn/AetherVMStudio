# ChartSymbolCreateResult

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Rendering.Symbols`　**Chart 版本**：`0.1.1.25`

## 概述

表示一次符号场景元素创建的结果。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Declaration` | 获取本次使用的强类型声明；文本解析失败时为 `null`。 |
| `Diagnostic` | 获取失败诊断；成功时为 `null`。 |
| `Element` | 获取新建且由调用方独占的场景元素；失败或 `none` 声明时为<br />`null`。 |
| `IsSuccess` | 获取创建是否成功；`none` 成功时仍不会产生元素。 |
