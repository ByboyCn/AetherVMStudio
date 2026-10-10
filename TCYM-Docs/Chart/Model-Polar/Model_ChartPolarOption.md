# ChartPolarOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts `polar` 公共组件选项。中心和半径使用强类型二元值，避免把单值半径、
内外半径和任意布局字符串混为一个运行时联合类型。

## 说明

Left/Top/Right/Bottom/Width/Height 是 TCYM 为统一公共组件布局提供的 box-layout 扩展，
不是 ECharts 6.1 Polar 原生字段；它们先解析 reference box，再由 `Center` 和
`Radius` 在该 box 内解析。calendar/matrix 容器协调仍留给对应公共底座。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Center` | 获取或设置相对最终 reference box 解析的 Polar 中心；空值恢复 ECharts 默认中心。 |
| `ComponentType` | 获取组件注册与合并所使用的类型名。 |
| `Radius` | 获取或设置相对最终 reference box 短边一半解析的内外半径；空值恢复 ECharts 默认<br />`[0, '80%']`。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。
