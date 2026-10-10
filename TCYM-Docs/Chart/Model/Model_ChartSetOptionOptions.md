# ChartSetOptionOptions

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

控制一次选项补丁如何按 ECharts `setOption` 语义应用。

## 属性

| 名称 | 说明 |
| --- | --- |
| `LazyUpdate` | 获取或设置是否可将 effective 模型构建推迟到下一次渲染。 |
| `NotMerge` | 获取或设置是否先丢弃现有 canonical 选项，再以本次输入重新建立状态。 |
| `ReplaceMerge` | 获取采用 replace-merge 语义的主类型集合，例如 `series`、`legend` 或<br />`dataset`。同 ID 的旧节点继续合并；该主类型下未被本次补丁匹配的旧节点会被移除。<br />为兼容 M0，`series.line` 会被视作 `series` 的别名。 |
| `Silent` | 获取或设置是否抑制本次更新产生的完成事件。 |
