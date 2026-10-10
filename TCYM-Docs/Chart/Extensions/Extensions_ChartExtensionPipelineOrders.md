# ChartExtensionPipelineOrders

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Extensions`　**Chart 版本**：`0.1.1.25`

## 概述

冻结 M1.7 扩展协议在 Data 与 Visual 阶段中的公共顺序锚点。
未来 dataZoom、visualMap 和具体系列应围绕这些锚点选择顺序，避免依赖模块注册先后。

## 字段

| 名称 | 说明 |
| --- | --- |
| `DataWindowConsumer` | 消费实际窗口并修改 `DataView` 的处理器应使用的最小推荐顺序。<br />该值仍早于公共 series extent collector。 |
| `DataWindowRequestBridge` | Data 阶段最早建立空 dataZoom 请求快照的桥接顺序。 |
| `DataWindowRequestProducer` | 未来 dataZoom 请求 producer 的推荐顺序；此时请求快照已经存在。 |
| `DataWindowResolutionProducer` | 未来 dataZoom 解析请求并发布实际窗口的推荐顺序。 |
| `DataWindowResolvedBridge` | 在普通数据变换前保证实际窗口快照存在的桥接顺序。 |
| `VisualEncodingAfterBoundary` | Visual 阶段建立“系列视觉编码后”边界制品的顺序。<br />该值严格位于后置 visualMap producer 之后、Tooltip consumer 之前，不与现有公共锚点共用顺序。 |
| `VisualEncodingAfterProducer` | future visualMap 在全部合法 series producer 与 Legend 聚合之后发布后置编码的固定推荐顺序。<br />该值与 series 的排他上界 800、Legend consumer 的 800 以及 Tooltip consumer 的 900<br />均严格不相等，不依赖同顺序注册先后。 |
| `VisualEncodingBeforeBoundary` | Visual 阶段建立“系列视觉编码前”边界制品的顺序。 |
| `VisualEncodingProducer` | 未来 visualMap 发布系列消费前编码结果的推荐顺序。 |
