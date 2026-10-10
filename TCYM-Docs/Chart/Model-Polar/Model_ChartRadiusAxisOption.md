# ChartRadiusAxisOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示绑定到一个 Polar 组件的径向半径轴。

## 属性

| 名称 | 说明 |
| --- | --- |
| `ComponentType` | 获取组件注册与合并所使用的类型名。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。
