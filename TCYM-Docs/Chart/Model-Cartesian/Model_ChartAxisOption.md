# ChartAxisOption

> **类型**：abstract class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示绑定到 Cartesian grid 的公共轴补丁；保留既有公开类型，同时把 Polar 轴从
`GridId` 和 `GridIndex` 等无效字段中隔离。

## 属性

| 名称 | 说明 |
| --- | --- |
| `GridId` | 获取或设置所属 grid 的业务 ID；显式赋空可恢复按索引绑定，单 Grid 时可与<br />`GridIndex` 一起省略并默认绑定索引 0。 |
| `GridIndex` | 获取或设置所属 grid 的同主类型索引；`GridId` 非空时由解析器优先采用 ID，<br />ID 和索引均省略时默认绑定索引 0。 |
