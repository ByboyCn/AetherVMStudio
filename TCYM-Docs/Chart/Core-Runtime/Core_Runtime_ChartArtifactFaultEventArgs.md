# ChartArtifactFaultEventArgs

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core.Runtime`　**Chart 版本**：`0.1.1.25`

## 概述

提供拥有制品在清理期间抛出异常的信息。

## 构造函数

### `ChartArtifactFaultEventArgs(TCYM.UI.Chart.Core.Runtime.ChartArtifactDisposalOperation,Type,Exception)`

初始化制品清理故障事件。

| 参数 | 说明 |
| --- | --- |
| `operation` | 触发释放的存储操作。 |
| `artifactType` | 可识别时为制品运行时类型。 |
| `exception` | 释放时抛出的异常。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `ArtifactType` | 获取制品运行时类型；无法识别时为 `null`。 |
| `Exception` | 获取释放时抛出的异常。 |
| `Operation` | 获取触发释放的存储操作。 |
