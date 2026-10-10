# ChartTextContent

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Text`　**Chart 版本**：`0.1.1.25`

## 概述

保存 formatter 的不可变文本结果；测量、渲染和命中测试应共享同一实例。

## 构造函数

### `ChartTextContent(String)`

初始化普通文本内容。

| 参数 | 说明 |
| --- | --- |
| `text` | 文本；空引用规范化为空字符串。 |

### `ChartTextContent(TCYM.UI.Chart.Text.ChartTextRun[])`

使用已经规范化且归当前对象独占的数组初始化内容。

| 参数 | 说明 |
| --- | --- |
| `runs` | 不可再修改的分段数组。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Empty` | 获取共享的空文本实例。 |
| `IsEmpty` | 获取内容是否不包含任何字符。 |
| `Runs` | 获取按源文本顺序排列的不可变分段。 |
| `Text` | 获取忽略 rich 样式后拼接得到的完整文本。 |

## 方法

### `FromRuns(Collections.Generic.IEnumerable{TCYM.UI.Chart.Text.ChartTextRun})`

从分段序列创建防御复制后的不可变内容。

| 参数 | 说明 |
| --- | --- |
| `runs` | 待复制分段；相邻同样式分段会被合并。 |

**返回：** 规范化后的不可变文本内容。

### `ToString`
