# ChartTooltipTargetIdentity

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Interaction`　**Chart 版本**：`0.1.1.25`

## 概述

保存 tooltip 命中的不可变稳定身份。对象只快照字符串、索引、值类型数据键和 canonical
RuntimeUid，不持有可变 Option 或业务负载，适合 NativeAOT 与跨帧查询。

## 属性

| 名称 | 说明 |
| --- | --- |
| `ComponentItemKey` | 获取组件内部项的稳定键；系列数据项为 `null`。 |
| `DataIndex` | 获取系列数据项的 lineage 根 raw 索引；组件项为 -1。 |
| `DataIndexInside` | 获取系列当前公开 presentation 中的 inside 索引；组件项为 -1。 |
| `DataItemComponentType` | 获取系列数据项所属的 descriptor 组件类型；普通宿主数据固定为 `series`，系列 attachment<br />可使用自身组件类型。旧工厂创建的兼容身份为 `null`，表示不约束<br />descriptor 组件作用域；组件项也为 `null`。 |
| `DataItemInstanceKey` | 获取系列私有 presentation 中可选的稳定实例键；当前代优先精确匹配该实例，跨代不存在时<br />回退到同一 descriptor 组件作用域内的稳定 `DataKey`；旧工厂身份保留历史全局<br />descriptor 稳定键语义。同一源数据只产生一个输出时通常为空。 |
| `DataKey` | 获取系列数据项的稳定键；组件项为 `null`。 |
| `DataType` | 获取可选数据类型约束；旧身份为空，关系数据可指定node或edge。 |
| `Id` | 获取创建身份时快照的显式业务 ID。 |
| `Kind` | 获取目标种类；实例存在即表示该命中项允许参与 item tooltip。 |
| `MainType` | 获取组件主类型；系列目标固定为 `series`。 |
| `Name` | 获取创建身份时快照的显示名称。 |
| `OwnerIndex` | 获取组件或系列在当前规范配置中的索引。 |
| `SubType` | 获取系列子类型；组件目标为 `null`。 |

## 方法

### `Equals(Object)`

### `Equals(TCYM.UI.Chart.Interaction.ChartTooltipTargetIdentity)`

判断两个快照是否指向同一 canonical owner 下的同一稳定项。

### `ForComponentItem(TCYM.UI.Chart.Model.ChartComponentOption,Int32,String)`

为明确允许触发 item tooltip 的组件内部项创建稳定身份。

| 参数 | 说明 |
| --- | --- |
| `component` | 当前 canonical Option 或保留同一 RuntimeUid 的回调副本。 |
| `componentIndex` | 组件在当前规范配置中的索引。 |
| `itemKey` | 组件内部项在组件生命周期内稳定且非空白的键。 |

**返回：** 与组件 RuntimeUid 和内部项键绑定的不可变身份。

### `ForSeriesDataItem(TCYM.UI.Chart.Model.ChartSeriesOption,Int32,TCYM.UI.Chart.Data.ChartDataKey,Int32,Int32,String,String,String)`

为多数据集合系列创建带数据类型约束的稳定Tooltip身份。

| 参数 | 说明 |
| --- | --- |
| `series` | 规范系列。 |
| `seriesIndex` | 系列索引。 |
| `dataKey` | 集合内稳定键。 |
| `dataIndex` | 原始索引。 |
| `dataIndexInside` | 呈现索引。 |
| `dataItemInstanceKey` | 呈现实例键。 |
| `dataItemComponentType` | 描述符组件类型。 |
| `dataType` | 非空数据类型。 |

### `ForSeriesDataItem(TCYM.UI.Chart.Model.ChartSeriesOption,Int32,TCYM.UI.Chart.Data.ChartDataKey,Int32,Int32,String,String)`

为系列 attachment 数据项创建同时约束 descriptor 组件类型的稳定身份。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前 canonical Option 或保留同一 RuntimeUid 的回调副本。 |
| `seriesIndex` | 系列在当前规范配置中的索引。 |
| `dataKey` | 数据项用于 diff 与跨帧匹配的稳定键。 |
| `dataIndex` | 数据项的 lineage 根 raw 索引。 |
| `dataIndexInside` | 数据项在当前公开 presentation 中的 inside 索引。 |
| `dataItemInstanceKey` | 可选 presentation 实例键。 |
| `dataItemComponentType` | descriptor formatter 参数使用的非空组件类型。 |

**返回：** 不会跨 descriptor 组件类型回退的系列数据项身份。

### `ForSeriesDataItem(TCYM.UI.Chart.Model.ChartSeriesOption,Int32,TCYM.UI.Chart.Data.ChartDataKey,Int32,Int32,String)`

为可能从同一源数据产生多个输出的系列数据项创建带 presentation 实例键的兼容身份。
为保留旧扩展行为，该 overload 不约束 descriptor 组件类型。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前 canonical Option 或保留同一 RuntimeUid 的回调副本。 |
| `seriesIndex` | 系列在当前规范配置中的索引。 |
| `dataKey` | 数据项用于 diff 与跨帧匹配的稳定键。 |
| `dataIndex` | 数据项的 lineage 根 raw 索引。 |
| `dataIndexInside` | 数据项在当前公开 presentation 中的 inside 索引。 |
| `dataItemInstanceKey` | 可选 presentation 实例键，用于区分同一源数据产生的多个可查询输出。 |

**返回：** 与系列 RuntimeUid 和稳定数据键绑定、且兼容任意 descriptor 组件类型的不可变身份。

### `ForSeriesDataItem(TCYM.UI.Chart.Model.ChartSeriesOption,Int32,TCYM.UI.Chart.Data.ChartDataKey,Int32,Int32)`

为系列数据项创建绑定 canonical RuntimeUid 与稳定数据键的兼容身份。
为保留旧扩展行为，该 overload 不约束 descriptor 组件类型。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前 canonical Option 或保留同一 RuntimeUid 的回调副本。 |
| `seriesIndex` | 系列在当前规范配置中的索引。 |
| `dataKey` | 数据项用于 diff 与跨帧匹配的稳定键。 |
| `dataIndex` | 数据项的 lineage 根 raw 索引。 |
| `dataIndexInside` | 数据项在当前公开 presentation 中的 inside 索引。 |

**返回：** 与系列 RuntimeUid 和稳定数据键绑定、且兼容任意 descriptor 组件类型的不可变身份。

### `GetHashCode`
