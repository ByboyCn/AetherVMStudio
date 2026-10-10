# IChartArtifactSnapshot

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Core.Runtime`　**Chart 版本**：`0.1.1.25`

## 概述

可变引用类型制品的快照契约。候选事务在暴露已发布值前创建独立副本，
避免失败处理器就地污染最后一次成功制品。

## 方法

### `CreateArtifactSnapshot`

创建与当前对象不共享可变公开状态的快照。

**返回：** 类型兼容且独立的制品快照。
