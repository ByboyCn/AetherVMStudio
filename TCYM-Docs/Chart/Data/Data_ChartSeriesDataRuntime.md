# ChartSeriesDataRuntime

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

单个系列的数据运行时。`RawStore` 永不改变；拥有有效 mutation authority 的
Data processor 可替换 processed store 或 `Data` 视图。引擎发布后的运行时只读。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Binding` | 获取解析后的数据绑定信息。 |
| `CanAppendToSeriesData` | 获取当前公共“追加行”API 对此绑定是否等价于追加逻辑数据项。Row 布局追加物理行会新增维度，<br />因而必须等待专门的横向/列追加契约。 |
| `Data` | 获取当前系列私有的排序/筛选视图。 |
| `IsDatasetBound` | 获取系列是否绑定到顶层 dataset。 |
| `Option` | 获取该运行时绑定的 effective 系列选项节点。 |
| `ProcessedStore` | 获取当前处理后 store；未执行 transform 时与 `RawStore` 相同。 |
| `ProjectionSource` | 当逻辑 RawStore 来自行布局投影时，获取物理选项来源 store；否则返回<br />`null`。 |
| `RawStore` | 获取系列的不可变逻辑 raw 数据。Row 布局下它是已验证的转置投影；如需查看物理表，<br />使用 `ProjectionSource`。 |
| `SeriesIndex` | 获取该运行时在 effective 系列列表中的索引。 |
| `SourceStore` | 获取选项级追加操作应扩展的物理来源 store。普通列布局返回 RawStore；行布局返回转置前来源。 |

## 方法

### `ResetProcessedData`

清除 transform 与筛选，恢复到完整 `RawStore`。

### `SetDataView(TCYM.UI.Chart.Data.ChartDataView)`

替换系列私有视图。视图必须建立在当前 `ProcessedStore` 上，并且调用方必须
持有当前 Data processor invocation 的 mutation authority。

| 参数 | 说明 |
| --- | --- |
| `view` | 新的排序/筛选视图。 |

### `SetProcessedStore(TCYM.UI.Chart.Data.ChartDataStore)`

安装 RawStore 本身，或由 `CreateDerived` 创建的一对一派生 store。
不相关 store 会被拒绝，确保 RawIndex 的含义不会静默改变。

### `ValidateAppend(TCYM.UI.Chart.Data.IChartDataSource)`

验证数据源能否通过当前系列的行追加语义加入。

| 参数 | 说明 |
| --- | --- |
| `source` | 待追加数据源。 |

**返回：** 验证结果及稳定诊断代码。
