# ChartLabelStateDescriptor

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Label`　**Chart 版本**：`0.1.1.25`

## 概述

描述 emphasis、blur 或 select 对公共标签契约的差异补丁。
未赋值字段继承 normal；多个状态同时生效时由中央标签解析器按 Blur、Select、Emphasis 顺序合并。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Align` | 获取或设置该状态的水平对齐覆盖；空值表示继承。 |
| `DefaultContent` | 获取或设置该状态 formatter 失败、返回空或缺失时使用的默认内容；<br />单独赋非空值会声明完整内容覆盖，赋空且没有其他 formatter 声明时继续继承。 |
| `Distance` | 获取或设置该状态与 anchor 之间的有限非负像素距离；空值表示继承。 |
| `Formatter` | 获取或设置该状态的强类型 formatter。赋值会声明完整 formatter 覆盖；<br />与 `Template` 同时存在时 callback 具有更高优先级。 |
| `Offset` | 获取或设置该状态在 anchor 解析后应用的有限二维偏移；空值表示继承。 |
| `Position` | 获取或设置该状态的公共位置语义；空值表示继承。 |
| `Rich` | 获取该状态的 rich 样式差异字典；同名样式按 presence-aware 规则覆盖继承值。 |
| `Rotation` | 获取或设置该状态的有限顺时针旋转角度；空值表示继承。 |
| `Show` | 获取或设置该状态是否显示标签；空值表示继承较低优先级状态或 normal。 |
| `Template` | 获取或设置该状态已经编译的模板。赋值会声明完整 formatter 覆盖；<br />空 callback 与非空模板可替换 normal callback。 |
| `TextStyle` | 获取或设置该状态的 presence-aware 文本样式差异；空值表示不覆盖。 |
| `VerticalAlign` | 获取或设置该状态的垂直对齐覆盖；空值表示继承。 |
