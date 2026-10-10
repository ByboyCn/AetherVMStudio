# ChartArtifactTransaction

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core.Runtime`　**Chart 版本**：`0.1.1.25`

## 概述

表示一个 `ChartArtifactStore` 候选事务的提交或回滚句柄。

## 属性

| 名称 | 说明 |
| --- | --- |
| `IsActive` | 获取此句柄是否仍代表存储的当前活动事务。 |

## 方法

### `Commit`

原子发布候选字典，并释放被候选淘汰的拥有制品。

### `Dispose`

若尚未提交，则回滚事务。

### `Rollback`

放弃候选，并释放仅由候选引入的拥有制品。

**说明：** 事务已结束时重复调用不执行任何操作。
