# ChartArtifactOwnership

> **类型**：enum　**命名空间**：`TCYM.UI.Chart.Core.Runtime`　**Chart 版本**：`0.1.1.25`

## 概述

指定制品条目离开活动集合时由谁负责释放。

## 枚举值

| 名称 | 说明 |
| --- | --- |
| `Borrowed` | 调用方保留生命周期责任；存储不会释放原对象。 |
| `Owned` | 存储取得独占所有权，并在条目退休时保证至多释放一次。 |
