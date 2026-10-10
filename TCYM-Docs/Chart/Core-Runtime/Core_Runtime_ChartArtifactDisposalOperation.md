# ChartArtifactDisposalOperation

> **类型**：enum　**命名空间**：`TCYM.UI.Chart.Core.Runtime`　**Chart 版本**：`0.1.1.25`

## 概述

定义拥有制品被释放时所处的存储操作。

## 枚举值

| 名称 | 说明 |
| --- | --- |
| `Clear` | 清空全部槽。 |
| `ClearFrom` | 按管线阶段清理槽。 |
| `Commit` | 提交候选事务并退休旧值。 |
| `Dispose` | 释放整个存储。 |
| `Remove` | 显式移除单个槽。 |
| `Replace` | 同一槽被新值替换。 |
| `Rollback` | 回滚候选事务并释放候选新增值。 |
