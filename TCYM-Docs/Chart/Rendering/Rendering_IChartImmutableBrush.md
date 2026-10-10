# IChartImmutableBrush

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Rendering`　**Chart 版本**：`0.1.1.25`

## 概述

标记自定义画刷的全部可达渲染状态均为深度不可变。实现该接口的非托管资源画刷
不得实现 `IDisposable`，因为配置快照与场景样式会安全共享同一实例。
