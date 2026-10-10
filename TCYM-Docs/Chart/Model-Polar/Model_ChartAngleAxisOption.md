# ChartAngleAxisOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示绑定到一个 Polar 组件的环向角度轴。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Clockwise` | 获取或设置角度轴是否按顺时针方向增长；空值恢复 ECharts 默认真。 |
| `ComponentType` | 获取组件注册与合并所使用的类型名。 |
| `EndAngle` | 获取或设置有限结束角；空值表示按起始角、逆序和顺时针选项生成完整 360 度范围。 |
| `StartAngle` | 获取或设置从右侧零度方向起算的有限起始角；空值恢复 90 度。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。
