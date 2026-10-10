# ChartCartesianQueryIndex

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

对不可变直角布局建立只读坐标轴查询索引。构造阶段复制轴引用、复制并排序每根轴的主刻度；
查询阶段仅执行数组遍历、二分和数值运算，不创建集合、闭包或临时托管对象。

## 构造函数

### `ChartCartesianQueryIndex(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartCartesianLayoutSnapshot)`

从一次深度不可变布局创建查询索引。

| 参数 | 说明 |
| --- | --- |
| `layout` | 已经完成网格引用和轴身份验证的聚合布局。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `AxisCount` | 获取当前索引包含的坐标轴数量；没有主刻度的轴仍计入该数量。 |

## 方法

### `Query(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisQueryRequest@,Span{TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisQueryResult})`

按稳定轴顺序将匹配结果写入调用方提供的 Span。

| 参数 | 说明 |
| --- | --- |
| `request` | 只读查询条件。 |
| `destination` | 由调用方预先分配的结果缓冲区。 |

**返回：** 实际写入数量；缓冲区容量不足时返回其容量。

### `TryQuery(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisQueryRequest@,TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisQueryResult@)`

遍历稳定轴数组并返回到有限轴线距离最小的匹配结果。

| 参数 | 说明 |
| --- | --- |
| `request` | 只读查询条件。 |
| `result` | 成功时得到最近轴结果；失败时为默认值。 |

**返回：** 存在满足过滤、范围、投影和吸附约束的坐标轴时返回 `true`。
