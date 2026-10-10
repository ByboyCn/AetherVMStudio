# ChartSymbolFactory

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Rendering.Symbols`　**Chart 版本**：`0.1.1.25`

## 概述

把强类型符号声明实例化为独立、可释放的场景元素；工厂本身无状态，可安全跨 Engine 共享。

## 方法

### `Create(String,SkiaSharp.SKRect,TCYM.UI.Chart.Rendering.ChartStyle,Boolean,TCYM.UI.Chart.Rendering.Symbols.IChartImageResolver)`

从 ECharts 风格文本创建符号元素。

| 参数 | 说明 |
| --- | --- |
| `symbol` | 内置名称、`emptyXxx`、`path://...` 或 `image://...`。 |
| `bounds` | 元素局部坐标中的名义布局边界；`pin` 按 ECharts 以矩形中心为尖端锚点，<br />实际路径主要向该锚点上方延伸。 |
| `style` | 可选的基础样式；赋给元素前会创建隔离副本。 |
| `keepAspect` | 路径或图片是否保持原始宽高比并在目标边界内居中。 |
| `imageResolver` | 图片解析器；仅 `image://` 使用，工厂不会自行执行文件或网络 I/O。 |

**返回：** 成功时携带调用方独占的元素；`none` 成功但元素为空。

### `Create(TCYM.UI.Chart.Rendering.Symbols.ChartSymbolDeclaration,SkiaSharp.SKRect,TCYM.UI.Chart.Rendering.ChartStyle,Boolean,TCYM.UI.Chart.Rendering.Symbols.IChartImageResolver)`

从已经解析的强类型声明创建符号元素。

| 参数 | 说明 |
| --- | --- |
| `declaration` | 不可变符号声明。 |
| `bounds` | 元素局部坐标中的名义布局边界；`pin` 按 ECharts 以矩形中心为尖端锚点，<br />实际路径主要向该锚点上方延伸。 |
| `style` | 可选的基础样式；赋给元素前会创建隔离副本。 |
| `keepAspect` | 路径或图片是否保持原始宽高比并在目标边界内居中。 |
| `imageResolver` | 图片解析器；仅图片声明使用，工厂不会自行执行文件或网络 I/O。 |

**返回：** 成功时携带调用方独占的元素；失败时仅携带稳定诊断。
