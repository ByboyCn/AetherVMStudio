# ChartVisualMapContinuousOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

定义线性 continuous VisualMap 的选择范围和交互行为。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Calculable` | 获取或设置是否显示可拖动范围手柄。 |
| `Range` | 获取或设置当前选择范围；运行时会排序并裁剪到 min/max。 |
| `Realtime` | 获取或设置拖动过程中是否实时提交选择范围。 |
| `SubType` | 获取 `MainType` 下的具体子类型。系列使用 `line`、`bar` 等值；<br />多数组件不需要子类型。 |
| `UnboundedRange` | 获取或设置范围触达 min/max 时是否向对应无穷端扩展。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。
