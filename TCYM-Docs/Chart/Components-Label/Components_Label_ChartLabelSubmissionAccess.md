# ChartLabelSubmissionAccess

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Label`　**Chart 版本**：`0.1.1.25`

## 概述

view 回调中用于创建 label host 和提交不可变 descriptor 的窄门面；离开原始 owner/调用代次后拒绝写入。

## 方法

### `BindInteractionPeer(String,TCYM.UI.Chart.Rendering.ChartElement,TCYM.UI.Chart.Rendering.ChartInteractionState)`

把调用方拥有的场景元素登记为指定稳定标签的交互 peer，使它与中央创建的文本和引导线共享状态，
但不向调用方暴露内部 binding。登记会随当前 owner 更新原子提交或回滚。

| 参数 | 说明 |
| --- | --- |
| `descriptorId` | 当前 owner 更新内将要提交或已经提交的非空稳定 descriptor Id。 |
| `element` | 由调用方继续拥有、且尚未参加其他标签 binding 的场景元素。 |
| `initialState` | 本轮要写入稳定 binding 的基础状态；具名来源持有的悬停、动作等状态位会继续保留。 |

### `CreateHost(String)`

在当前 view render target 中创建只由中央 pass 管理子元素的标签 host。

| 参数 | 说明 |
| --- | --- |
| `id` | 可选稳定调试标识。 |

**返回：** 可用于本轮多次 `Submit` 的不透明 host 门面。

### `Submit(TCYM.UI.Chart.Components.Label.ChartLabelHost,TCYM.UI.Chart.Components.Label.ChartLabelDescriptor)`

向指定 host 提交一个会立即深度快照的标签 descriptor。

| 参数 | 说明 |
| --- | --- |
| `host` | 由当前门面本轮创建的标签 host。 |
| `descriptor` | formatter、样式、anchor、优先级和 metadata 描述。 |
