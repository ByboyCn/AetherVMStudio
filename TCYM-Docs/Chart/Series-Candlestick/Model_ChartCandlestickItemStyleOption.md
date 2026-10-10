# ChartCandlestickItemStyleOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Candlestick normal 或交互状态的图元样式。在公共填充、边框、阴影与透明度之上，
精确增加阴线填充、阴线边框和十字线边框；三个专用画刷均在 setter 阶段立即隔离。

## 属性

| 名称 | 说明 |
| --- | --- |
| `BorderColor0` | 获取或设置阴线边框画刷；赋值时立即创建安全快照。 |
| `BorderColorDoji` | 获取或设置开盘价等于收盘价时使用的边框画刷；空值是一次显式清除，布局阶段据此决定<br />是否启用独立 doji 符号。 |
| `Color0` | 获取或设置阴线实体填充画刷；赋值时立即创建安全快照。 |

## 方法

### `Clone`

创建公共与 Candlestick 专用画刷、值和 presence 均隔离的副本。

**返回：** 内容等价的新 Candlestick 图元样式。
