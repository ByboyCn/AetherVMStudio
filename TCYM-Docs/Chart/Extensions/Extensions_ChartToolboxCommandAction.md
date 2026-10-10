# ChartToolboxCommandAction

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Extensions`　**Chart 版本**：`0.1.1.25`

## 概述

通过唯一固定 action 类型携带一个强类型 toolbox 命令。

## 构造函数

### `ChartToolboxCommandAction(TCYM.UI.Chart.Extensions.IChartToolboxCommand)`

创建 toolbox 命令 action。

| 参数 | 说明 |
| --- | --- |
| `command` | 要在目标 Engine action 事务中执行的强类型命令。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Command` | 获取强类型命令。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `ActionType` | 内置 toolbox 命令桥使用的固定 action 类型。 |
