# ChartMarkSymbolRotatePair

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 markLine 两个端点的有限顺时针旋转角度。

## 构造函数

### `ChartMarkSymbolRotatePair(Single,Single)`

创建两个端点的旋转角度。

| 参数 | 说明 |
| --- | --- |
| `start` | 起点角度，单位为度。 |
| `end` | 终点角度，单位为度。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `End` | 获取终点旋转角度。 |
| `Start` | 获取起点旋转角度。 |

## 方法

### `Uniform(Single)`

把相同角度应用到两个端点。

| 参数 | 说明 |
| --- | --- |
| `rotation` | 两个端点共用的角度。 |

**返回：** 起终点相同的旋转对。
