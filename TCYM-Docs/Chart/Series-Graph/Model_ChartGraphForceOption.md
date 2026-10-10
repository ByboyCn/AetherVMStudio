# ChartGraphForceOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

力导向的 presence-aware 参数。显式赋空恢复默认值。

## 属性

| 名称 | 说明 |
| --- | --- |
| `EdgeLength` | 边的理想逻辑像素长度，默认 60，范围 1 到 1000000。 |
| `FrameInterval` | 动画帧发布的最小间隔，单位毫秒，默认 16，范围 1 到 1000。 |
| `Friction` | 速度保留比例，默认 0.6，范围 0 到 1。 |
| `Gravity` | 回归视口中心的引力，默认 0.1，范围 0 到 10。 |
| `Iterations` | 最大迭代次数，默认 120，范围 1 到 2000。 |
| `IterationsPerFrame` | 每个动画帧包含的求解迭代数，默认 8，范围 1 到 200。 |
| `LayoutAnimation` | 逐帧显示真实力导向迭代；默认 false，保持计算完成后一次发布。 |
| `Repulsion` | 节点排斥强度，默认 200，范围 0 到 1000000。 |
| `Seed` | 重合点扰动的确定性种子，默认 0。 |

## 方法

### `Clone`

复制所有字段及 presence 信息。

### `Reset`

显式恢复全部默认参数。
