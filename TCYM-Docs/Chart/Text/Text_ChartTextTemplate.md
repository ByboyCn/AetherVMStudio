# ChartTextTemplate

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Text`　**Chart 版本**：`0.1.1.25`

## 概述

表示一次编译、可重复求值的 ECharts 风格文本模板。

## 说明

未知表达式、未闭合表达式及空 rich 样式名按原文输出；缺失维度输出空字符串。
`{{` 与 `}}` 分别转义为普通左右花括号，rich payload 可以继续包含受支持 token。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Source` | 获取用于编译当前实例的原始模板。 |

## 方法

### `Compile(String)`

把模板编译成可重复使用的 token 节点。

| 参数 | 说明 |
| --- | --- |
| `template` | 模板文本。 |

**返回：** 不再重复扫描模板语法的编译结果。

### `Format(TCYM.UI.Chart.Text.ChartFormatterParameters@)`

使用强类型参数求值，并生成不可变的普通或 rich 分段。

| 参数 | 说明 |
| --- | --- |
| `parameters` | formatter 参数快照。 |

**返回：** 可供测量和渲染共享的不可变内容。

### `ToString`
