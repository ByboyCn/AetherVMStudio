# ChartCandlestickModule

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

原子安装 Candlestick 的 Normalize、OHLC Data/schema、axis-band、四性能模式、
ordinary/compact Layout、ordinary/compact Visual、诚实诊断与 retained View。

## 字段

| 名称 | 说明 |
| --- | --- |
| `ModuleKey` | 获取 Candlestick 生产模块使用的稳定注册键。 |

## 方法

### `Register(TCYM.UI.Chart.Core.ChartRegistry)`

原子注册当前 Candlestick 契约；重复 module、processor、validator 或 View
冲突会使整批注册失败，不留下半模块。

| 参数 | 说明 |
| --- | --- |
| `registry` | 待安装的注册表。 |

**返回：** 同一个注册表实例。

**说明：** 自定义 Registry 必须同时安装 `ChartSeriesFoundationModule` 与
`ChartCartesianModule`。模块不注册旧式 renderer；普通 Candlestick 由 retained
View 消费同代次 Layout/Visual 制品。
