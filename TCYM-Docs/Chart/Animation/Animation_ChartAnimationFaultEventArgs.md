# ChartAnimationFaultEventArgs

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Animation`　**Chart 版本**：`0.1.1.25`

## 概述

描述一个补间在用户回调中发生的故障。

## 构造函数

### `ChartAnimationFaultEventArgs(TCYM.UI.Chart.Animation.ChartTween,Exception)`

描述一个补间在用户回调中发生的故障。

| 参数 | 说明 |
| --- | --- |
| `tween` | 发生故障并已被取消的补间。 |
| `exception` | 用户回调抛出的异常。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Exception` | 获取用户回调抛出的异常。 |
| `Tween` | 获取发生故障的补间。 |
