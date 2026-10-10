# ChartSeriesFocusBlurPolicy

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个系列或数据项已经解析完成的 focus、blurScope 与指针禁用策略。

## 构造函数

### `ChartSeriesFocusBlurPolicy(TCYM.UI.Chart.Series.ChartSeriesFocus,TCYM.UI.Chart.Series.ChartSeriesBlurScope,Boolean)`

创建经过枚举范围验证的不可变交互策略。

| 参数 | 说明 |
| --- | --- |
| `focus` | 激活 emphasis 后要保留清晰的目标。 |
| `blurScope` | 允许被弱化的候选范围。 |
| `pointerEmphasisDisabled` | 是否只禁用指针产生的 emphasis。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `BlurScope` | 获取允许被弱化的候选范围。 |
| `Focus` | 获取 emphasis 激活后要保留清晰的目标。 |
| `PointerEmphasisDisabled` | 获取是否只禁用指针产生的 emphasis；action 不受影响。 |

## 方法

### `FromECharts(String,String,Boolean)`

把已由 option 校验的 ECharts 字符串转换为强类型策略。

| 参数 | 说明 |
| --- | --- |
| `focus` | 可选 `none`、`self` 或 `series`。 |
| `blurScope` | 可选 `coordinateSystem`、`series` 或 `global`。 |
| `pointerEmphasisDisabled` | 是否只禁用指针 emphasis。 |

**返回：** 空值已经应用 ECharts 默认值的强类型策略。
