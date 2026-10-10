# ChartSemanticEventArgs

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

表示 legendselectchanged、datazoom、selectchanged 等模块语义事件。
类型采用开放字符串，新增组件事件无需修改固定枚举。

## 构造函数

### `ChartSemanticEventArgs(String,Object)`

初始化语义事件。

| 参数 | 说明 |
| --- | --- |
| `type` | 非空的事件类型。 |
| `payload` | 事件携带的可选数据。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Handled` | 获取或设置事件是否已被订阅者处理。 |
| `Payload` | 获取事件负载。 |
| `Type` | 获取事件类型。 |
