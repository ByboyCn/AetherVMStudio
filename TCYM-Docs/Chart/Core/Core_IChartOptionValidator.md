# IChartOptionValidator

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

定义无反射、NativeAOT 安全的 option 校验扩展；实现只读取当前 Normalize 候选，
并通过 `ChartOptionValidationContext` 提交结构化诊断。

## 说明

同一校验器实例可能被共享 Registry 中的多个 Engine 使用；框架会按实例串行执行
`Validate`，并拒绝该实例在回调内同步重入。校验器仍不得保留或异步使用
回调上下文，也不得在回调中驱动会再次调用自身的 Engine 构建。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Name` | 获取用于异常诊断和确定性排序的稳定校验器名称。 |
| `Order` | 获取校验器顺序；数值较小者先执行，同值时保留注册顺序。 |

## 方法

### `Validate(TCYM.UI.Chart.Core.ChartOptionValidationContext)`

校验当前有效 option 候选。

| 参数 | 说明 |
| --- | --- |
| `context` | 只在本次回调内有效的诊断候选上下文。 |
