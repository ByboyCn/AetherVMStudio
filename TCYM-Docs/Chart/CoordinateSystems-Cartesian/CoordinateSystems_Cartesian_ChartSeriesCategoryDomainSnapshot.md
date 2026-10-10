# ChartSeriesCategoryDomainSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

保存当前 Layout 候选中全部 category 轴的系列数据分类域。

## 构造函数

### `ChartSeriesCategoryDomainSnapshot(Collections.Generic.IEnumerable{TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisSeriesCategoryDomain})`

创建与调用方集合隔离的 category 轴分类域快照。

| 参数 | 说明 |
| --- | --- |
| `axes` | 不含重复轴身份的分类域。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取由可见系列治理的 category 轴数量。 |

## 方法

### `TryGet(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisIdentity,TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisSeriesCategoryDomain@)`

尝试按规范轴身份读取系列分类域。

| 参数 | 说明 |
| --- | --- |
| `axis` | 目标 category 轴。 |
| `domain` | 成功时返回该轴的不可变分类域。 |

**返回：** 至少一个可见系列绑定并治理该 category 轴时为 `true`。
