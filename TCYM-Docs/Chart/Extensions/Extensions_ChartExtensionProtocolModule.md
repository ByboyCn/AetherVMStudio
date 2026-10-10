# ChartExtensionProtocolModule

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Extensions`　**Chart 版本**：`0.1.1.25`

## 概述

装配 M1.7 dataZoom、visualMap 与 toolbox 的无业务协议底座。
本模块只建立空快照、阶段边界和固定命令桥，不筛选数据、不产生视觉编码也不创建 UI。

## 字段

| 名称 | 说明 |
| --- | --- |
| `ModuleKey` | 获取空业务扩展协议底座在注册表中的稳定模块键。 |

## 方法

### `Register(TCYM.UI.Chart.Core.ChartRegistry)`

把扩展协议桥接器注册到指定注册表。

| 参数 | 说明 |
| --- | --- |
| `registry` | 接收处理器和 action 桥的注册表。 |

**返回：** 传入的注册表，便于链式装配。

**说明：** 写入前会预检全部内置处理器类型和稳定 action 键，避免冲突留下部分协议桥。
