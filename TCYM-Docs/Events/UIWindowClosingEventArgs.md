# UIWindowClosingEventArgs

> **类型**：类　**分类**：Events　**框架版本**：`0.1.1.24`

**继承 / 实现**：`EventArgs`

## 概述

窗口即将关闭时触发的事件参数，类似 Avalonia 的 <c>WindowClosingEventArgs</c>。 <para> 在 <c>Closing</c> 事件处理器中将 <see cref="Cancel"/> 设为 <see langword="true"/>， 即可阻止窗口关闭（例如弹出“确定要退出吗？”的确认对话框）。 </para>

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Cancel` | `bool` | 是否取消本次关闭。设为 <see langword="true"/> 时窗口保持打开。 同一次关闭请求中取消状态是单调的：任一处理器请求取消后，后续处理器不能重新放行。 |
| `Reason` | `UIWindowCloseReason` | 本次关闭请求的来源。 |
| `IsProgrammatic` | `bool` | 是否为代码主动发起的关闭（<see cref="UIWindowCloseReason.Programmatic"/>）。 |
