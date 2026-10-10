# ChartPointerCancelReason

> **类型**：enum　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

说明 Cancel 指针事件来自宿主还是引擎生命周期边界。

## 枚举值

| 名称 | 说明 |
| --- | --- |
| `Clear` | 引擎 Clear 正在清除配置和运行时状态。 |
| `Dispose` | 引擎正在最终释放。 |
| `Host` | 宿主报告触点取消、窗口失焦或捕获丢失。 |
| `None` | 当前事件不是 Cancel。 |
| `Rebuild` | 引擎正在替换已发布布局；可跨布局延续的 roam 会话不应因此结束。 |
