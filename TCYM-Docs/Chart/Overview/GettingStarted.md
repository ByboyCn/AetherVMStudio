# TCYM.UI.Chart API 文档

> **当前版本**：`0.1.1.25`

`TCYM.UI.Chart` 是面向 TCYM.UI 的原生 SkiaSharp 图表库。公共宿主 `UIChart` 继承
`UIElement`，可以直接加入现有 UI 树；图表内部使用独立的轻量场景树，不会把每个数据点、标签或
刻度创建成 `UIElement`。

当前可直接绘制 Line、Bar、Pie、Candlestick、Gauge、Radar、Graph、Tree 以及 Cartesian/Polar Scatter，并提供 Cartesian、Polar、Title、
Legend、Tooltip、inside/slider DataZoom、Brush、Label、Mark、选择与高亮、动画及大数据路径。不同系列支持的能力范围
并不完全相同，Scatter 的当前边界见“当前限制”。

## 引用项目

项目目标框架为 `net8.0` 和 `net10.0`。在同一解决方案中可直接添加项目引用：

```xml
<ProjectReference Include="..\TCYM.UI.Chart\TCYM.UI.Chart.csproj" />
```

常用命名空间：

```csharp
using SkiaSharp;
using TCYM.UI.Chart;
using TCYM.UI.Chart.Components.Mark;
using TCYM.UI.Chart.Components.Tooltip;
using TCYM.UI.Chart.Components.VisualMap;
using TCYM.UI.Chart.CoordinateSystems.Polar;
using TCYM.UI.Chart.Core;
using TCYM.UI.Chart.Data;
using TCYM.UI.Chart.Interaction;
using TCYM.UI.Chart.Model;
using TCYM.UI.Chart.Rendering;
using TCYM.UI.Chart.Series;
using TCYM.UI.Chart.Text;
```

## 快速开始

下面创建一个类目轴折线图，并把 `UIChart` 加入已有 UI 树：

```csharp
var chart = new UIChart
{
    Width = 800,
    Height = 480,
};

root.AddChild(chart);

chart.SetOption(new ChartOption
{
    Background = ChartBrush.Solid(SKColors.White),
    Animation = new()
    {
        Enabled = true,
        Duration = 600,
        UpdateDuration = 350,
    },
    Grid = new ChartGridOption
    {
        Left = "24px",
        Top = "24px",
        Right = "24px",
        Bottom = "32px",
        ContainLabel = true,
        OuterBoundsMode = ChartGridOuterBoundsMode.None,
    },
    XAxis = new ChartXAxisOption
    {
        Type = ChartAxisType.Category,
        BoundaryGap = false,
        Data = ["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"],
    },
    YAxis = new ChartYAxisOption
    {
        Type = ChartAxisType.Value,
        Scale = true,
    },
    Tooltip = new ChartTooltipOption
    {
        Trigger = ChartTooltipTrigger.Axis,
        Confine = true,
    },
    Series = new ChartLineSeriesOption
    {
        Id = "temperature",
        Name = "温度",
        Symbol = "circle",
        SymbolSize = 9f,
        DataSource = new ChartLineData(23d, 34d, 28d, 45d, 40d, 36d, 31d),
        LineStyle = new()
        {
            Color = ChartBrush.Solid(new SKColor(22, 96, 235)),
            Width = 2.5f,
        },
        ItemStyle = new()
        {
            Color = ChartBrush.Solid(new SKColor(22, 96, 235)),
        },
    },
});
```

`ChartOption.Series`、`XAxis`、`YAxis` 和 `DataZoom` 支持单项、数组或 collection expression。
`Title`、`Legend`、`Tooltip`、`Grid` 是首组件快捷属性；需要多个同类组件时使用
`Components` 或 `AddComponent`。单 Grid、单 X/Y 轴时，系列可以省略轴 ID，默认绑定索引 0。

## 数据与 encode

### 强类型 inline data

Line、Bar、Pie、Gauge 都有对应的强类型数据源：

```csharp
var lineData = new ChartLineData
{
    { 0d, 12d },
    { 1d, 18d },
    { 2d, 15d },
};

var barData = new ChartBarData(120d, 200d, 150d, 80d);

var pieData = new ChartPieData()
    .Add(1048d, "搜索引擎")
    .Add(735d, "服务")
    .Add(580d, "邮件");

var gaugeData = new ChartGaugeData()
    .Add(new ChartGaugeDataItem(72d, "CPU") { Key = "cpu" });
```

标量 Line/Bar 数据会使用类目索引作为另一维。二维或多维数据使用嵌套项。三类富数据项都可以配置
`Key`、`Name`、`Selected`、`ItemStyle`、`Label` 和状态样式；Line 富项还可覆盖 symbol。

### Dataset

多个系列可以共享 `ChartDataTable`，再通过 `Encode` 指定维度：

```csharp
var source = new ChartDataTable()
    .AddDimension("category")
    .AddDimension("sales")
    .AddDimension("cost")
    .AddRow("Mon", 120d, 80d)
    .AddRow("Tue", 200d, 130d)
    .AddRow("Wed", 150d, 100d);

var sales = new ChartBarSeriesOption
{
    Id = "sales",
    DatasetId = "business",
};
sales.Encode.Set("x", "category").Set("y", "sales");

var option = new ChartOption
{
    XAxis = new ChartXAxisOption { Type = ChartAxisType.Category },
    YAxis = new ChartYAxisOption { Type = ChartAxisType.Value },
    Series = sales,
};

option.Dataset.Add(new ChartDatasetOption
{
    Id = "business",
    Source = source,
});
```

Dataset 支持 Column/Row 投影。`DatasetId` 优先于 `DatasetIndex`；显式 `Encode` 优先于默认维度推断。

## Bar

Bar 支持纵向/横向布局、分组、stack、圆角、背景、Label、Tooltip、Legend、Mark、动画、
`realtimeSort`、sampling、Large、Progressive 和 Polar。

两个系列使用相同 `Stack` 即可累计：

```csharp
var option = new ChartOption
{
    XAxis = new ChartXAxisOption
    {
        Type = ChartAxisType.Category,
        Data = ["Mon", "Tue", "Wed", "Thu"],
    },
    YAxis = new ChartYAxisOption
    {
        Type = ChartAxisType.Value,
        Minimum = ChartAxisBound.Fixed(0d),
    },
    Legend = new ChartLegendOption { Show = true },
    Tooltip = new ChartTooltipOption
    {
        Trigger = ChartTooltipTrigger.Axis,
        AxisPointer = new()
        {
            Type = ChartTooltipAxisPointerType.Shadow,
        },
    },
    Series =
    [
        new ChartBarSeriesOption
        {
            Id = "direct",
            Name = "直接访问",
            Stack = "total",
            StackStrategy = ChartStackStrategy.SameSign,
            DataSource = new ChartBarData(120d, 132d, 101d, 134d),
        },
        new ChartBarSeriesOption
        {
            Id = "search",
            Name = "搜索引擎",
            Stack = "total",
            StackStrategy = ChartStackStrategy.SameSign,
            DataSource = new ChartBarData(220d, 182d, 191d, 234d),
        },
    ],
};
```

`StackStrategy` 可选 `SameSign`、`All`、`Positive` 或 `Negative`。需要精确控制累计顺序时设置
`StackOrder`。Large/Progressive 用于大数据紧凑渲染，但不会提供普通逐项节点的全部视觉与交互能力。

## Candlestick

Candlestick 的每个数据项按 `[open, close, lowest, highest]` 解释。默认使用类目 X 轴和值 Y 轴，
上涨、下跌与开收相等项分别绘制实体和上下影线；使用稳定数据 `Key` 更新时会复用对应图形身份。

```csharp
var xAxis = new ChartXAxisOption
{
    Type = ChartAxisType.Category,
    Data = ["Mon", "Tue", "Wed", "Thu"],
};

var option = new ChartOption
{
    Animation = new() { Enabled = false },
    XAxis = xAxis,
    YAxis = new ChartYAxisOption
    {
        Type = ChartAxisType.Value,
        Minimum = ChartAxisBound.Fixed(0d),
        Maximum = ChartAxisBound.Fixed(20d),
        Scale = true,
    },
    Series = new ChartCandlestickSeriesOption
    {
        Id = "daily-price",
        Name = "Daily price",
        DataSource = new ChartCandlestickData()
            .Add(new ChartCandlestickDataItem(6d, 13d, 3d, 16d)
            {
                Id = "Mon",
                Key = "Mon",
                Name = "Mon",
            })
            .Add(new ChartCandlestickDataItem(14d, 8d, 5d, 18d)
            {
                Id = "Tue",
                Key = "Tue",
                Name = "Tue",
            })
            .Add(new ChartCandlestickDataItem(10d, 10d, 4d, 15d)
            {
                Id = "Wed",
                Key = "Wed",
                Name = "Wed",
            }),
    },
};

chart.SetOption(option);
```

Candlestick 支持 Horizontal/Vertical、category/value/time/log 基础轴、value/time/log OHLC 值轴、
inverse、非零 Grid/轴与 ID 优先绑定。存在 category 轴时由 category 方向决定布局；两轴均连续时
可用 `Layout` 指定方向，省略时按 Y-time 优先级推断。

`BarWidth`、`BarMinWidth` 和 `BarMaxWidth` 支持逻辑像素与相对 band 的百分比。显式
`BarWidth` 不再套 min/max；自动宽度按默认半 band 计算。宽度不大于 1.3 时绘制一条完整
lowest-to-highest simple-box 线。设置 `ItemStyle.BorderColorDoji` 可启用独立 doji 描边；
未设置时，flat 项按当前处理顺序的前一项 close 选择正色或负色。

`Clip=false` 可保留 Grid 外图形；默认 clip 会区分完全位于 Grid 内、部分相交和完全裁掉，
并保持像素、命中与 Tooltip 查询一致。普通态和 `Emphasis`、`Blur`、`Select` 都支持独立
`ItemStyle` 与 Label；`Emphasis.Scale=true` 会围绕整根 candle 中心使用 1.1 倍状态几何。

Label 默认关闭；显式打开时默认显示 close，位置为 inside。下面同时配置 rich Label、Tooltip、
选择、光标和按 close 映射颜色的 VisualMap：

```csharp
var candle = (ChartCandlestickSeriesOption)option.Series[0];
candle.Label.Show = true;
candle.Label.Position = "top";
candle.Label.Formatter = "{value|{c}}";
candle.Label.Rich["value"] = new ChartTextStyle
{
    Color = ChartBrush.Solid(SKColors.White),
    FontSize = 13f,
    Padding = new ChartInsets(12f, 7f),
    BackgroundColor = ChartBrush.Solid(new SKColor(37, 36, 83)),
    BorderRadius = 16f,
};
candle.Emphasis.Scale = true;
candle.SelectedMode = ChartSeriesSelectedMode.Multiple;
candle.Cursor = "pointer";

var visualMap = new ChartVisualMapContinuousOption
{
    Show = false,
    SeriesId = ["daily-price"],
    Dimension = "close",
    Min = 0d,
    Max = 20d,
};
visualMap.InRange.Color.Add(ChartBrush.Solid(SKColors.MediumPurple));
visualMap.InRange.Opacity.Add(0.85f);
option.VisualMap.Add(visualMap);
chart.SetOption(option);
```

Legend、item/axis/manual Tooltip、MarkPoint/MarkLine/MarkArea、选择、focus/blur、cursor 和
`Silent` 使用公共组件与交互 API；series normal callback逐项调用，且它与Label/Tooltip formatter
参数会保留完整处理后维度、encode、稳定数据身份及不可变raw snapshot；事件参数发布稳定数据身份、
OCLH、primary close和不可变raw snapshot。
VisualMap 对 Candlestick 支持 color/opacity，
不支持 symbol/symbolSize；compound body/wick 不支持 `ItemStyle.BorderRadius`。

Candlestick 可在 category/value/time/log 基础轴上使用 DataZoom，也支持多 Candlestick、多 Grid、
slider、axisPointer shadow、Brush 和 `AppendData`。DataZoom、Brush 与 Legend action 都在完整构建成功后
原子发布状态和事件；失败时保留上一份可用场景。

Candlestick 支持 Normal、NormalProgressive、Large 和 LargeProgressive。模式按 DataZoom 后的数据量
决定；默认启用 Large，阈值与分块值对齐 ECharts：

```csharp
var candle = (ChartCandlestickSeriesOption)option.Series[0];

candle.Large = true;
candle.LargeThreshold = 600;
candle.Progressive = 3000;
candle.ProgressiveThreshold = 10_000;
candle.ProgressiveChunkMode = ChartCandlestickProgressiveChunkMode.Mod;

// 需要按连续数据段逐帧发布时：
candle.ProgressiveChunkMode =
    ChartCandlestickProgressiveChunkMode.Sequential;
```

`Large=false` 只关闭 compact 路径；数据达到 progressive 阈值后仍可进入 NormalProgressive。
`Progressive=0` 只关闭分帧，达到 large 阈值时仍使用同步 Large。两种 Large 模式使用方向中立的
批量 body/wick，因此 Horizontal 和 Vertical 都保留实体与影线；批量命中、Click、item/manual/axis
Tooltip、Legend、Mark、DataZoom、clip 以及 uniform solid VisualMap color/opacity 仍可使用。

Large/LargeProgressive 不创建逐项图形节点。逐项 `ItemStyle`、`ColorBy=Data`、颜色回调、Label、
emphasis/blur/select/focus、逐项选择和 Brush 选择/视觉会给出能力提示并使用 callback-free 的系列
正/负/doji 样式或空选择降级；非纯色/object-bounds gradient 及 varying VisualMap 会 fallback 并保留
unconsumed 提示，不会伪装成 uniform 映射。NormalProgressive 多于一个
分块时暂不跨帧追加 Label，单分块仍保留 Label。

Normal 模式支持 initial/update/add/remove 动画。首次绘制和新增项从各自 open 位置沿值轴展开；
保持稳定 `Key` 的更新会复用原图形，并连续插值 body 与上下影线。数据项删除、Legend 隐藏和整系列
删除使用静默退出，退出中的旧图形不会继续响应命中或事件。默认 initial 为 `300ms/linear`，
update 为 `500ms/cubicInOut`；可由全局动画配置或系列属性覆盖：

```csharp
var candle = (ChartCandlestickSeriesOption)option.Series[0];

option.Animation.Enabled = true;
candle.AnimationDuration = 450;
candle.AnimationEasing = "cubicOut";
candle.AnimationDurationUpdate = 700;
candle.AnimationEasingUpdate = "cubicInOut";
candle.AnimationThreshold = 2_000;

// Chart 不保留调用方 option；修改完后重新提交。
chart.SetOption(option);
```

Normal Candlestick 也支持 Universal Transition。一个数据项始终作为一个逻辑 leaf 参与匹配，
body 与上下影线作为同一 leaf 的有序轮廓一起变形，不需要调用方把它们拆成多个系列。稳定的
series key、数据 `Id` 或 `GroupId`/`ChildGroupId` 可用于 Candlestick 自身以及与 Bar、
Line symbol、Scatter、Pie 的转换：

`Key` 保留同系列普通更新的图形身份；Universal Transition 的逐项匹配请设置 `Id`，
或使用 `GroupId`/`ChildGroupId` 表达分合关系。

```csharp
var sourceOption = option.Clone();
var sourceCandle =
    (ChartCandlestickSeriesOption)sourceOption.Series[0];
sourceOption.Animation.Enabled = true;
sourceCandle.UniversalTransitionEnabled = true;
sourceCandle.UniversalTransitionSeriesKey =
    new ChartUniversalTransitionSeriesKey("daily-price-shape");
sourceCandle.UniversalTransitionDivideShape =
    ChartUniversalTransitionDivideShape.Split;
chart.SetOption(sourceOption, new ChartSetOptionOptions { NotMerge = true });

// target 使用同一个 series key；一对一匹配项继续使用相同 Id。
var targetOption = sourceOption.Clone();
var targetCandle =
    (ChartCandlestickSeriesOption)targetOption.Series[0];
targetCandle.DataSource = new ChartCandlestickData()
    .Add(new ChartCandlestickDataItem(8d, 15d, 5d, 18d)
    {
        Id = "Mon",
        Key = "Mon",
        Name = "Mon",
    })
    .Add(new ChartCandlestickDataItem(16d, 9d, 6d, 19d)
    {
        Id = "Tue",
        Key = "Tue",
        Name = "Tue",
    });
targetOption.Animation.Enabled = true;
targetCandle.UniversalTransitionEnabled = true;
targetCandle.UniversalTransitionSeriesKey =
    new ChartUniversalTransitionSeriesKey("daily-price-shape");
targetCandle.UniversalTransitionDivideShape =
    ChartUniversalTransitionDivideShape.Split;
chart.SetOption(targetOption, new ChartSetOptionOptions { NotMerge = true });
```

一对多和多对一转换可在数据项上使用 `GroupId`/`ChildGroupId` 表达映射关系。

默认 divide shape 为 `Split`；可显式改为 `Clone`。Line 的整条折线/面积没有与单根 candle 等价的
compound leaf，会保留目标普通动画并给出明确降级提示。NormalProgressive、Large 和
LargeProgressive 不为动画或 Universal Transition 展开逐项 owner；显式请求会给出一次能力提示，
且不会调用逐项 timing callback。切回 Normal 后可重新使用上述能力。

## Pie 与 Donut

Pie 支持普通饼图、Donut、Rose、部分圆、圆角、内外标签、LabelLine、避让、Legend、Tooltip、
选择、高亮、动画和 Universal Transition。

```csharp
var option = new ChartOption
{
    Tooltip = new ChartTooltipOption
    {
        Trigger = ChartTooltipTrigger.Item,
        Confine = true,
    },
    Legend = new ChartLegendOption
    {
        Show = true,
        Top = "5%",
        Left = ChartLength.FromKeyword("center"),
    },
    Series = new ChartPieSeriesOption
    {
        Id = "income",
        Name = "收入",
        Radius = new ChartPieRadius(
            ChartLength.Percent(40f),
            ChartLength.Percent(70f)),
        PadAngle = 4f,
        ItemStyle = new()
        {
            BorderRadius = 10f,
        },
        Label = new()
        {
            Show = true,
            Formatter = "{b}: {d}%",
        },
        DataSource = new ChartPieData()
            .Add(1048d, "搜索引擎")
            .Add(735d, "服务")
            .Add(580d, "邮件"),
    },
};
```

`Radius` 的 inner 大于 0 时形成 Donut。`RoseType` 可以选择 radius 或 area 语义。Pie 没有
Cartesian/Polar 轴绑定。

## Gauge

Gauge 使用自己的 value→angle 线性刻度，不绑定 Cartesian/Polar 轴。下面的配置包含分段轴线、
进度环、指针、动态 detail、Legend/Tooltip、选择以及稳定更新：

```csharp
var data = new ChartGaugeData()
    .Add(new ChartGaugeDataItem(72d, "CPU")
    {
        Id = "cpu",
        Key = "cpu",
        GroupId = "system-load",
    });

var gauge = new ChartGaugeSeriesOption
{
    Id = "cpu-gauge",
    Name = "系统负载",
    Minimum = 0d,
    Maximum = 100d,
    DataSource = data,
    SelectedMode = ChartSeriesSelectedMode.Multiple,
    UniversalTransitionEnabled = true,
    UniversalTransitionSeriesKey = "system-load-gauge",
    DataGroupId = "system-load",
};

gauge.AxisLine.LineStyle.Width = 24f;
gauge.AxisLine.LineStyle.Color
    .Add(new ChartGaugeColorStop(
        0.6d,
        ChartBrush.Solid(new SKColor(82, 196, 26))));
gauge.AxisLine.LineStyle.Color
    .Add(new ChartGaugeColorStop(
        0.85d,
        ChartBrush.Solid(new SKColor(250, 173, 20))));
gauge.AxisLine.LineStyle.Color
    .Add(new ChartGaugeColorStop(
        1d,
        ChartBrush.Solid(new SKColor(245, 34, 45))));

gauge.Pointer.Icon = "triangle";
gauge.Pointer.Length = ChartLength.Percent(58f);
gauge.Pointer.Width = 10f;
gauge.Progress.Show = true;
gauge.Progress.Overlap = false;
gauge.Progress.RoundCap = true;
gauge.Detail.ValueAnimation = true;
gauge.Detail.Formatter = "{value}%";

chart.SetOption(new ChartOption
{
    Animation = new()
    {
        Enabled = true,
        Duration = 800,
        UpdateDuration = 500,
    },
    Legend = new ChartLegendOption { Show = true },
    Tooltip = new ChartTooltipOption
    {
        Trigger = ChartTooltipTrigger.Item,
        Confine = true,
    },
    Series = gauge,
});
```

`AxisLine.LineStyle.Color` 中的 stop 是闭区间 `[0, 1]` 比例，不是实际 value；按声明顺序使用，
不会自动排序。`Minimum`、`Maximum`、`StartAngle`、`EndAngle` 与 `Clockwise` 共同决定刻度和
指针方向。`SplitNumber`、`AxisTick`、`SplitLine`、`AxisLabel` 可控制静态刻度显示。

多值 Gauge 的每个数据项使用独立 pointer/progress/title/detail，但 pointer icon、长度、宽度和
progress 几何主要由系列级配置控制。`Progress.Overlap=false` 会按当前 inside order 创建同心环。
为数据项设置稳定且唯一的 `Key`，可以在更新、重排和动画打断时复用同一交互 owner；`Id`、`Key`、
`GroupId` 和 `ChildGroupId` 也用于 Universal Transition 身份匹配。

Gauge 的 pointer、progress 和 `Detail.ValueAnimation` 使用同一显示时间线。默认 detail 动画会按
起止值的十进制精度舍入；需要固定文本格式时可设置 `Detail.Formatter` 或强类型
`FormatterCallback`。点击、选择和 item Tooltip 只来自可命中的 pointer/progress；axis、title、
detail 和 anchor 保持静默。

Universal Transition 每个数据项最多选择一个 primary 图形：可变形的非 image pointer 优先作为
Symbol；否则单圈且 `RoundCap=false` 的 progress 可作为 Sector。`image://` pointer、圆头进度和
不可表示的多圈路径会保留普通 Gauge 动画，不承诺路径 morph。

## Radar 雷达图

Radar 使用独立的指标坐标：每个指标有自己的数值范围，每条数据是一个完整向量。
默认注册表同时包含 Radar 坐标和系列模块。

```csharp
var option = new ChartOption
{
    Radar = new ChartRadarOption
    {
        Id = "skills",
        Shape = ChartRadarShape.Polygon, // 也可使用 Circle
        SplitNumber = 5,
        Indicator =
        [
            new() { Name = "设计", Min = 0, Max = 100 },
            new() { Name = "开发", Min = 0, Max = 100 },
            new() { Name = "测试", Min = 0, Max = 100 },
            new() { Name = "交付", Min = 0, Max = 100 },
        ],
    },
    Legend = new ChartLegendOption(),
    Tooltip = new ChartTooltipOption { Trigger = ChartTooltipTrigger.Item },
    Series = new ChartRadarSeriesOption
    {
        Id = "team",
        RadarId = "skills",
        Symbol = "circle",
        SymbolSize = 8,
        AreaStyle = new() { Opacity = 0.2f },
        DataSource = new ChartRadarData()
            .Add(new ChartRadarDataItem([80, 90, 70, 85]) { Id = "a", Name = "团队 A" })
            .Add(new ChartRadarDataItem([65, 75, 95, 80]) { Id = "b", Name = "团队 B" }),
    },
};
chart.SetOption(option);
```

多 Radar 使用 `option.Components.Add(...)`，系列按 `RadarId` 优先绑定，未指定时使用
`RadarIndex`（默认 0）。`Center` 与 `Radius` 复用 `ChartPolarCenter` / `ChartPolarRadius`
强类型值，百分比按布局区域及短边一半计算；默认中心为 50%/50%，外半径为 50%。
`StartAngle` 默认 90 度，`Clockwise` 默认 false。

`LineStyle` 控制轮廓，`ItemStyle` 控制符号，`AreaStyle` 控制填面。
未提交 `AreaStyle` 时不填面，赋空对象启用默认面积，赋 null 关闭。
`AxisName`、`AxisLabel` 分别控制指标名和数值刻度文本；系列 `Label` 表示各指标顶点的值标签。
Legend 按数据项名称显示，Item Tooltip 按指标名称列出整条向量。

`ConnectNulls` 是本库扩展：默认 false，只连接相邻有效指标；设为 true 后跨缺口连接有效点。
缺失或 NaN 值不会被伪造成 0，不生成对应符号或标签；不足两个有效点不画线，不足三个不画面。
通用坐标转换使用 `ChartCoordinateValue(X: 指标索引, Y: 指标值)`；反向转换选取最近指标轴。
Radar 不使用 Cartesian X/Y 或 Polar radius/angle 作为其数据维度。

`Scale = true` 可让自动指标范围不强制包含零；显式 `Min` / `Max` 优先。
系列需要至少三个指标。每个系列最多 10,000 条处理后数据，数据条数乘指标数最多 100,000 个顶点；超限会拒绝候选，
不会静默截断。`ChartRadarData` 通过 `SetOption` 更新；需要 `AppendData` 时使用公共
`ChartDataTable` 数据入口，保留既有追加契约。

Radar 支持逐顶点入场与更新动画，由 `option.Animation` 的 `Enabled`、`Duration`、
`UpdateDuration`、`Delay`、`UpdateDelay`、`Easing`、`UpdateEasing` 控制。
入场从雷达中心展开；更新从当前已呈现位置补间，轮廓、面积、符号与标签同步运动。
悬停重绘不重播；动画中的 Tooltip/Click 仍返回原始目标数据。`Enabled = false` 或时长为 0 时直接呈现终态。
数值滚动动画、Universal Transition 与数据移除退场动画仍不支持。
Mark 附件、Cartesian/Polar 轴绑定和折线面积的 `Origin` 不适用于 Radar，显式请求会诊断。
Radar 暂不消费 VisualMap 编码；针对它的 VisualMap 配置会提示未支持。Brush 使用公共未消费提示，
DataZoom 不提供 Radar 指标轴选择器。指标使用线性比例尺，不支持 log 指标轴。
轴装饰当前使用静态颜色，不消费动态 ColorSource 回调或轴端箭头等扩展字段。
指标缺失值和 NaN 可形成缺口，正负 Infinity 会拒绝候选，保留上一份可用结果。
`IChartRadarCoordinateSystem` 提供查询接口；替换坐标工厂需要返回权威
`ChartRadar2D` 的独立副本，可以自定义坐标 ID，但不能改写已经确定的轴与布局几何。

## Graph 关系图

Graph 用节点和边描述关系，支持显式坐标、环形排列和后台力导向布局。
节点与边的事件和 Tooltip 使用独立的 `DataType`（`node` / `edge`）。

```csharp
var data = new ChartGraphData()
    .Add(new ChartGraphNode { Id = "a", Name = "入口", X = 80, Y = 100, Value = 1 })
    .Add(new ChartGraphNode { Id = "b", Name = "处理", X = 220, Y = 80, Value = 2 })
    .Add(new ChartGraphNode { Id = "c", Name = "输出", X = 220, Y = 220, Value = 3 })
    .AddLink(new ChartGraphEdge("a", "b") { Id = "ab", Value = 10 })
    .AddLink(new ChartGraphEdge("b", "c") { Id = "bc", Value = 20 });

chart.SetOption(new ChartOption
{
    Tooltip = new ChartTooltipOption { Trigger = ChartTooltipTrigger.Item },
    Series = new ChartGraphSeriesOption
    {
        Id = "workflow",
        DataSource = data,
        Layout = ChartGraphLayout.None,
        Roam = true,
        Draggable = true,
        FocusNodeAdjacency = true,
        SymbolSize = 24,
        Label = new() { Show = true, Formatter = "{b}" },
        EdgeLabel = new() { Show = true, Formatter = "{c}" },
    },
});
```

`None` 的 X/Y 是图表视口内的逻辑像素坐标；缺失坐标用圆周位置初始化。
`Circular` 使用环形排列。`Force` 先显示初始位置，在后台用纯数值副本计算，
默认完成后由 UI 线程验证当前数据代次再提交；更新、隐藏、清空或销毁会取消不再适用的任务。
`Force.Repulsion/Gravity/EdgeLength/Friction/Iterations/Seed` 控制本库有界求解器，
默认分别为200/0.1/60/0.6/120/0；不保证与其他力导向实现逐点相同。

边端点可以是节点索引或字符串，字符串优先按Id、其次按唯一Name解析；
重复Id、歧义名称或缺失端点会拒绝候选，不会连到错误节点。
`Categories` 声明分类，节点用 `Category` 或 `CategoryIndex` 选择；分类Legend隐藏节点及关联边。
`LineStyle` 控制边，`Curveness` 设置弯曲程度，`Label` 与 `EdgeLabel` 分别控制节点和边标签。
普通布局最多10000节点/50000边，force最多1000节点；超限明确拒绝。

原生边端符号支持 `None`、`Circle`、`Arrow`，两端分别配置；默认两端不显示：

```csharp
series.EdgeSymbol = new ChartGraphEdgeSymbolPair(
    ChartGraphEdgeSymbol.Circle, ChartGraphEdgeSymbol.Arrow);
series.EdgeSymbolSize = new ChartGraphEdgeSymbolSizePair(8, 14);

// 单条边覆盖系列配置；null 表示继承，显式 None 表示不显示。
data.Links[0].Symbol = new ChartGraphEdgeSymbolPair(
    ChartGraphEdgeSymbol.None, ChartGraphEdgeSymbol.Arrow);
data.Links[0].SymbolSize = new ChartGraphEdgeSymbolSizePair(0, 18);
```

箭头沿实际直线、曲线或自环的切线指向对应端节点；按旋转后的名义节点矩形保守避让，
不对自定义path/image节点逐像素裁切。空间不足的短边或重叠节点会隐藏端符号。
尺寸范围0～1024，单位为屏幕逻辑像素，不随漫游放大；位置仍跟随缩放、拖动和force。
端符号与边共享颜色/透明度状态、选择、Tooltip和点击身份，不形成额外数据行。

需要观察力导向的实际迭代过程时，显式开启分帧呈现：

```csharp
series.Layout = ChartGraphLayout.Force;
series.Force.LayoutAnimation = true;
series.Force.IterationsPerFrame = 8; // 每批物理迭代次数，范围 1～200
series.Force.FrameInterval = 16;    // UI帧最小间隔（毫秒），范围 1～1000
```

`LayoutAnimation` 默认false。开启后后台发布真实迭代快照，UI一次提交一批；
队列容量为1，慢UI会让生产者等待，不无限缓存中间帧。`Iterations` 仍为总迭代次数，
从相同初始位置和物理参数出发，最终结果与默认求解路径一致。
该选项独立控制force迭代呈现，不是通用动画或UT开关。
拖点会取消旧求解并在结束后从当前点位继续；样式重建保留同输入的队列和进度。

`Roam=true` 开放鼠标拖拽平移、Ctrl＋滚轮缩放和触屏双指缩放，`Draggable=true` 开放节点拖动；
缩放围绕鼠标位置进行，默认节点图片、节点标签（含富文本）和边标签同步缩放。
`NodeScaleRatio=0` 保持节点及节点标签大小，节点位置和连线仍正常缩放；0 到 1 之间为部分缩放，默认 1 保留旧行为。
PC普通滚轮始终不缩放Graph，留给滚动容器；必须按住Ctrl再滚轮缩放。
Windows触屏由Chart优先使用原生触点，不让同一次触摸产生的兼容鼠标抢占手势；
无需全局关闭Touch-to-Mouse，其他普通控件和真实鼠标保留原有输入行为。
触屏单指空白滑动留给页面滚动，双指按距离和中点缩放/平移图表；
双指结束后需全部抬起再开始新的单指操作，避免退指时误拖图或触发点击。
连续缩放期间自动 Tooltip 暂停，停止滚轮约150ms后再次移动鼠标即可恢复；显式 showTip 操作仍可立即执行。
`FocusNodeAdjacency=true` 保留当前节点、相邻节点和关联边的清晰状态。
程序选择/高亮沿用公共action，以 `DataType = ChartSeriesDataType.Edge` 区分边；
手动提示框可用 `new ChartShowTipAction(seriesId: "workflow", dataIndex: 0) { DataType = "edge" }`。

`SelectedMode.Single` 在整张Graph中保留一个节点或边；`Series` 按目标DataType选择整个集合，
`Main` 是节点集合的兼容别名。分类目录属于节点，边仅在其两端仍可见时保留。
高亮按来源独立管理，整体高亮后的单项downplay只排除该来源，不清除其他来源的强调。

本实现提供本地逻辑像素布局，不接入Cartesian/Polar、Row-oriented节点表、Mark、UT或数值标签动画。
force使用有界迭代，默认提交最终结果，也可显式开启迭代分帧；最多1000节点/2000迭代并不代表大图毫秒级或实时承诺。
追加或重排 force 节点时，未修改 X/Y 的既有节点按稳定键延续当前已呈现位置；显式修改坐标仍优先使用新值。
扩展绘制可注册带场景装饰回调的 `ChartGraphSeriesViewFactory`：回调接收当前构建上下文、Graph 选项与已提交 Root，
可添加自有图元并通过 `context.FrameScheduler` 安排 owner 帧任务，不替换原生 force/回滚生命周期。
重复回调应复用或更新自己的图元；不要保存构建上下文或改写原生节点。隐藏与销毁会取消这些帧任务。
节点坐标限于正负10000000逻辑像素，force工作输入限于正负1000000000。
任意path/image边端符号、自动重边曲率和外部坐标系等未暴露选项不从通用series能力推断为已支持。

## Tree 树图

Tree 使用父子层级，不需要声明坐标轴。节点和节点标签共享真实点击身份，
点击分支可折叠/展开；连接线不产生数据点击。默认注册表已经安装 Tree 模块。

```csharp
var root = new ChartTreeNode { Id = "root", Name = "总部" };
var branch = new ChartTreeNode { Id = "design", Name = "设计部" };
branch.Children.Add(new ChartTreeNode { Id = "ui", Name = "UI", Value = 12 });
branch.Children.Add(new ChartTreeNode { Id = "ux", Name = "UX", Value = 8 });
root.Children.Add(branch);
root.Children.Add(new ChartTreeNode { Id = "dev", Name = "研发部", Value = 24 });

var series = new ChartTreeSeriesOption
{
    Id = "organization",
    Name = "组织",
    DataSource = new ChartTreeData().Add(root),
    Layout = ChartTreeLayout.Orthogonal,
    Orient = ChartTreeOrient.LR,
    InitialTreeDepth = 2, // 根深度为 0；-1 表示全部展开
    ExpandAndCollapse = true,
    Roam = true,
    SymbolSize = 12f,
    Label = new() { Show = true, Formatter = "{b}", Position = "left" },
    Leaves = new()
    {
        Label = new() { Show = true, Position = "right" }
    }
};
series.LineStyle.Width = 1.5f;
chart.SetOption(new ChartOption { Series = series });
```

正交方向有 LR/RL/TB/BT；Layout.Radial 使用同心深度环。
EdgeShape.Curve 支持两种布局；EdgeShape.Polyline 仅支持正交布局，
EdgeForkPosition 默认 50%，也可设置像素距离。Left/Right/Top/Bottom 默认 12%，
Width/Height 可约束布局 box。径向自动标签保持可读朝向，显式 Label.Rotate 可覆盖。

节点可配置 ItemStyle、LineStyle、Label、Symbol、SymbolSize、SymbolRotate、
Emphasis/Blur/Select；Leaves 补丁作用于真实叶节点及折叠分支，节点补丁优先级更高。
Label 和 Leaves.Label 复用公共 formatter、Rich、状态样式及 LabelLayout。
Select.Disabled 在节点、Leaves 和系列层级统一生效。

初始深度只作为未明确配置 Collapsed 的分支种子。ExpandAndCollapse=false
禁止点击切换并取消初始深度限制，但仍尊重节点显式 Collapsed。
运行时折叠状态和视角在同系列 ID 的普通 merge/resize 中保留，
notMerge、系列移除、Clear、Dispose 会退休状态；GetOption 返回输入配置，不写入交互状态。

```csharp
// collapsed=false 展开；true 折叠；省略该参数切换。
chart.DispatchAction(new ChartTreeExpandAndCollapseAction(
    seriesId: "organization", dataName: "设计部", collapsed: false));
```

数据选择器也可用 dataKey、dataIndex（前序原始索引）或 dataIndexInside（当前可见索引），
每次只能指定一种；名称选择可能匹配多个同名分支。普通叶节点 action 不改变状态。
稳定业务节点建议设置唯一 Id 或 Key，避免插入/重排时失去身份。

PC 漫游只使用 Ctrl+滚轮缩放，普通滚轮留给外层滚动条；鼠标拖动平移不会误触折叠。
Windows 原生双指触控使用触点距离缩放及中点平移，单指空白仍可滚动父容器。
Roam=false 不接管缩放；节点、标签、命中和 item Tooltip 使用同一视角。

ChartTreeData 支持多个根，Count 为全部节点数。SetOption 会一次性冻结整个森林，
之后修改源节点应重新提交 DataSource。也可提交具有 ParentChild 关系的
Hierarchical Dataset；不支持破坏层级的逐行过滤。环、多父、共享节点引用、
重复 ID、无效端点和超过 10,000 节点的数据会被拒绝，不替换 last-good 场景。
该数量是输入安全上限，不代表满展开的帧率保证。大型树建议保留 InitialTreeDepth 限制，
按需展开分支，减少同时显示的节点和标签。

```csharp
var forest = new ChartTreeData().Add(root);
var option = new ChartOption();
option.Dataset.Add(new ChartDatasetOption { Id = "forest", DataSource = forest });
series.DataSource = null; // series inline 来源优先于 Dataset，需取消该来源
series.DatasetId = "forest";
option.Series.Add(series);
chart.SetOption(option);
```

Dataset.DataSource 接受通用 IChartDataSource；旧 Dataset.Source 仍保持 ChartDataTable
签名，非表格来源时该 getter 返回 null。两个入口表示同一来源，最后赋值生效。
系列 ItemStyle.ColorCallback 与 Label.FormatterCallback 可用于动态样式/内容；
节点快照不接受回调或借用 Typeface，应使用系列配置或 Theme 字体。

Tree 读取全局 Animation，支持节点、连接线和标签的入场、更新、重排及折叠/展开过渡：

```csharp
chart.SetOption(new ChartOption
{
    Animation = new()
    {
        Enabled = true,
        Duration = 700,
        Delay = 0,
        Easing = "cubicOut",
        UpdateDuration = 500,
        UpdateDelay = 0,
        UpdateEasing = "cubicInOut"
    },
    Series = series
});
```

首次及显隐恢复使用 Duration/Delay/Easing；后续更新使用对应的 Update 字段。
只设置 `Animation = new() { Enabled = true }` 也会生效，未指定的时间参数使用全局默认值。
展开后代从最近存活祖先展开，折叠/删除后代向祖先收拢并淡出；退出画面不参与点击或 Tooltip。
快速反向更新从当前呈现接力，同目标重绘不重启动画；漫游与动画叠加，标签/命中同步。
Tooltip 的位置跟随当前动画几何，内容仍是已提交的目标值。

series.AnimationThreshold 默认 2000，按新旧可见节点的稳定键并集计数，包含退出节点。
超过上限、Enabled=false、时长为 0 或视口为空时直接应用最终布局；设置阈值 0 可只关闭 Tree 动画。
大树仍建议限制 InitialTreeDepth，避免同时展开大量节点。

Tree 不支持 Universal Transition、数字标签 valueAnimation、
Cartesian/Polar 外部坐标系、Mark、axis Tooltip、DataZoom 或 Brush。
径向折线组合会明确报错；不是浏览器 ECharts 的逐像素复刻。

## Polar

Polar 是显式模块。先注册 `ChartPolarModule`，再创建 Polar 与 Radius/Angle 轴：

```csharp
var registry = ChartModules.CreateDefaultRegistry();
ChartPolarModule.Register(registry);

var chart = new UIChart(registry)
{
    Width = 800,
    Height = 480,
};

var option = new ChartOption();
option.AddComponent(new ChartPolarOption
{
    Id = "main-polar",
    Radius = new ChartPolarRadius(20f, 180f),
});
option.AddComponent(new ChartRadiusAxisOption
{
    Id = "main-radius",
    PolarId = "main-polar",
    Type = ChartAxisType.Value,
    Minimum = ChartAxisBound.Fixed(0d),
    Maximum = ChartAxisBound.Fixed(100d),
    Scale = true,
});
option.AddComponent(new ChartAngleAxisOption
{
    Id = "main-angle",
    PolarId = "main-polar",
    Type = ChartAxisType.Value,
    Minimum = ChartAxisBound.Fixed(0d),
    Maximum = ChartAxisBound.Fixed(360d),
    Clockwise = false,
    Scale = true,
});
option.Series.Add(new ChartLineSeriesOption
{
    Id = "polar-line",
    CoordinateSystem = ChartPolar2D.CoordinateSystemType,
    PolarId = "main-polar",
    DataSource = new ChartLineData
    {
        { 30d, 0d },
        { 70d, 90d },
        { 45d, 180d },
        { 85d, 270d },
    },
});

chart.SetOption(option);
```

Polar Line 与 Polar Bar 共用同一套 Polar/轴组件。保持组件和系列 ID 不变再次调用 `SetOption` 会进行
稳定更新；更换坐标系或绑定身份时会重建不兼容的图形。

## DataZoom

`ChartDataZoomInsideOption` 支持在 Cartesian 连续轴上缩放和平移；Candlestick 也支持 category 轴：

```csharp
var option = new ChartOption
{
    DataZoom = new ChartDataZoomInsideOption
    {
        Id = "main-window",
        XAxisIndex = 0,
        Start = 0d,
        End = 100d,
        MinSpan = 1d,
        FilterMode = ChartDataWindowFilterMode.Filter,
        ZoomOnMouseWheel = ChartDataZoomInteractionTrigger.Ctrl,
        MoveOnMouseMove = ChartDataZoomInteractionTrigger.Enabled,
        MoveOnMouseWheel = ChartDataZoomInteractionTrigger.Disabled,
        ResetOnDoubleClick = true,
    },
    XAxis = new ChartXAxisOption
    {
        Type = ChartAxisType.Value,
        Scale = true,
    },
    YAxis = new ChartYAxisOption
    {
        Type = ChartAxisType.Value,
        Scale = true,
    },
    Series = new ChartLineSeriesOption
    {
        ShowSymbol = false,
        DataSource = new ChartLineData
        {
            { 0d, 12d },
            { 1d, 18d },
            { 2d, 15d },
        },
    },
};
```

Ctrl+滚轮按指针位置缩放，绘图区内拖动平移，双击恢复。`FilterMode.Filter` 会改变当前 DataView；
`FilterMode.None` 只更新轴窗口。交互不会改写调用方提供的原始 option 或 raw data。

`ChartDataZoomSliderOption` 使用同一百分比窗口和轴目标，可以与 inside DataZoom 联动：

```csharp
option.DataZoom.Add(new ChartDataZoomSliderOption
{
    Id = "price-slider",
    XAxisIndex = 0,
    YAxisIndex = [],
    Start = 20d,
    End = 80d,
    FilterMode = ChartDataWindowFilterMode.Filter,
    Bottom = ChartLength.Pixels(12f),
    Height = ChartLength.Pixels(32f),
    ShowDataShadow = ChartDataZoomDataShadowMode.Auto,
    Realtime = true,
    Detail =
    {
        Show = true,
        Precision = 0,
        Formatter = "{value}%",
    },
    MoveHandle =
    {
        Size = 10f,
    },
    BrushSelect =
    {
        Enabled = true,
    },
});
```

slider 支持横向/纵向、inverse、两端 handle、filler/moveHandle 平移、面板框选、min/max span、
zoomLock、实时更新或抬起后提交，并从目标系列的原始数据生成 data shadow；Candlestick 的 shadow
读取 `open`，不会把当前窗口裁剪后的 DataView 当成完整来源。detail formatter 是只替换
`{value}` 的 AOT-safe 模板，当前不接受委托或自定义 handle 图标。Candlestick 只接受
`Filter` 和 `None`；`WeakFilter`、`Empty` 及 Polar DataZoom 会明确诊断。
`Disabled = true` 是显式 no-op，不会因未支持的过滤模式或缺少 DataZoom module 拒绝 Candlestick。
多个 inside/slider 组件命中同一轴时形成传递联动闭包，并按有效 option 顺序发布最终窗口。

超大数据量频繁拖动时，可将slider的`Realtime`设为`false`：移动期间只更新滑块预览，
抬起后提交数据窗口。Large与Progressive降低图元数量并分帧发布，窗口提交仍需同步计算可见数据、
坐标和查询索引，不代表全量数据下的缩放完全无延迟。

高密度成交量柱等纯色矩形批次，还可显式启用纹理缓存：

```csharp
chart.Engine.EnableLargeBatchRasterCache = true;
```

默认关闭。启用后，满足条件且连续两次绘制状态相同的批次会保存为纹理，后续稳定帧复用。
数据、样式、透明度、缩放、平移或裁剪范围变化时自动失效；关闭开关或释放图表会释放缓存。
这主要减少稳定画面的重复绘制，不消除 DataZoom 数据计算和纹理首次重建的成本。

缓存使用透明中间纹理合成，抗锯齿、半透明及裁剪边缘可能与逐项绘制存在颜色差异；
要求逐像素一致时保持关闭。当前仅缓存至少 16,384 个无描边、圆角、阴影及逐项状态的纯色矩形，
支持轴对齐正缩放，已知 Chart 路径裁剪、其他画面格式或资源不足时回退直接绘制。
单批最多 1,048,576 设备像素、单边最多 4,096 像素，每个图表的纹理预算为 64 MiB；
高 DPI 下超出预算的批次也会回退。

## Brush

`ChartBrushOption` 在 Cartesian Grid 内提供 Rect、LineX、LineY 和 Polygon 选择。区域保存在
Engine-local 运行态中，通过 action 设置或清除，不会回写调用方的 option：

```csharp
var brush = new ChartBrushOption
{
    Id = "price-brush",
    BrushType = ChartBrushType.Rect,
    BrushMode = ChartBrushMode.Multiple,
    Transformable = true,
    RemoveOnClick = true,
    SeriesIndex = ChartBrushSeriesSelection.All,
    BrushLink = [0, 1],
    ThrottleType = ChartBrushThrottleType.FixedRate,
    ThrottleDelay = 16,
};
brush.InBrush.Opacity = 1f;
brush.OutOfBrush.Opacity = 0.2f;
option.Brush.Add(brush);
chart.SetOption(option);

var target = new ChartBrushCartesianTarget(
    gridIndex: 0,
    xAxisIndex: 0,
    yAxisIndex: 0);
chart.DispatchAction(new ChartBrushAction(
[
    new ChartBrushRectArea((0d, 2d), (10d, 20d))
    {
        Id = "initial-range",
        Target = target,
    },
],
new ChartBrushComponentSelector(id: "price-brush")));

// 让用户在绘图区继续创建矩形区域；传 null 可释放 Brush 光标。
chart.DispatchAction(new ChartBrushTakeGlobalCursorAction(
    ChartBrushType.Rect,
    ChartBrushMode.Multiple,
    new ChartBrushComponentSelector(id: "price-brush")));

chart.SemanticEvent += (_, args) =>
{
    if (args.Type == "brushselected"
        && args.Payload is ChartBrushSelectedEventPayload selected)
    {
        var rawIndices = selected.Batch
            .SelectMany(batch => batch.Selected)
            .SelectMany(series => series.DataIndices);
        // 使用稳定的原始数据索引处理选择结果。
    }
};
```

`SeriesIndex` 决定哪些系列执行空间相交；`BrushLink` 只把已选择的稳定原始数据身份投影到其他系列。
Normal/NormalProgressive Candlestick、Bar 和 Scatter 支持空间选择，Line 与 Pie 可接收 BrushLink。
Large/LargeProgressive Candlestick 会明确降级为空选择。区域和目标使用闭区间；
Rect/LineX/LineY 可整体移动及边缘缩放，Polygon 支持套索创建和整体移动。FixedRate 与 Debounce
用于合并高频 `brushselected`；Brush 与 inside/slider DataZoom 对同一 pointer 互斥。
当前不支持 Polar/Geo/SingleAxis/Calendar/Matrix Brush、全局像素区域、Polygon 顶点编辑、自定义
cover handle 图标或未声明的视觉通道。

## Tooltip、Legend 与 Mark

- `ChartTooltipOption` 支持 item/axis trigger、axisPointer、show/hide delay、同步/异步 formatter 和
  手动 show/hide action。
- `ChartLegendOption` 支持横向/纵向布局、分页、选择模式与 selector；系列上的
  `LegendHoverLink` 控制图例悬停联动。
- `ChartMarkModule` 为显式模块。注册后可使用 `MarkPoint`、`MarkLine` 和 `MarkArea`：

```csharp
var registry = ChartModules.CreateDefaultRegistry();
ChartMarkModule.Register(registry);

var series = new ChartLineSeriesOption
{
    DataSource = new ChartLineData(23d, 34d, 28d, 45d),
};
series.MarkLine.Data.Add(
    new ChartMarkLineAxisDataItem(new ChartMarkLineAxisPositionOption
    {
        Statistic = ChartMarkStatisticType.Average,
    })
    {
        Name = "平均值",
    });
```

Tooltip 是原生 C#/Skia 内容，不执行 HTML、CSS 或 JavaScript。`Formatter` 可设置文本模板；
`FormatterCallback` 与异步 formatter 返回 `ChartTooltipContent`，纯文本使用
`ChartTooltipContent.FromText(...)`。

## 事件与 action

`UIChart.ChartEvent` 只在真实图形元素命中时发布系列事件。空白绘图区点击不会伪造成数据项点击：

```csharp
chart.ChartEvent += (_, args) =>
{
    if (args.Type == ChartEventType.Click
        && args.ComponentType == "series"
        && args.PrimaryValue.TryGetDouble(out var value))
    {
        Console.WriteLine($"{args.SeriesId} / {args.Name}: {value}");
    }
};
```

可以通过 action 控制高亮和选择：

```csharp
chart.DispatchAction(new ChartHighlightAction(
    seriesId: "temperature",
    dataIndex: 2,
    sourceKey: "external-hover"));

chart.DispatchAction(new ChartDownplayAction(
    seriesId: "temperature",
    dataIndex: 2,
    sourceKey: "external-hover"));
```

同一状态可由多个 `sourceKey` 独立持有，移除一个来源不会清除其他来源的状态。

## 更新、替换与追加数据

普通 `SetOption` 会按 ID 和类型合并：

```csharp
chart.SetOption(new ChartOption
{
    Series = new ChartLineSeriesOption
    {
        Id = "temperature",
        SymbolSize = 12f,
    },
});
```

完整替换：

```csharp
chart.SetOption(
    replacement,
    new ChartSetOptionOptions
    {
        NotMerge = true,
        Silent = true,
    });
```

按组件桶替换：

```csharp
var options = new ChartSetOptionOptions();
options.ReplaceMerge.Add("series");
chart.SetOption(replacement, options);
```

向指定系列追加二维表数据：

```csharp
var chunk = new ChartDataTable()
    .AddDimension("x")
    .AddDimension("y")
    .AddRow(3d, 21d)
    .AddRow(4d, 19d);

chart.AppendData(seriesIndex: 0, chunk);
```

稳定 ID 会保留兼容 View、交互状态和动画连续性；更换系列类型、坐标系或关键绑定时会进行确定性重建。

## Registry 与模块

默认 Registry 包含常用 Cartesian、Line、Bar、Pie、Candlestick、Gauge、Scatter、Title、Legend、Tooltip 等模块：

```csharp
var registry = ChartModules.CreateDefaultRegistry();
```

可按需显式添加模块：

```csharp
ChartPolarModule.Register(registry);
ChartMarkModule.Register(registry);
```

默认Registry已经注册Scatter。使用自定义Registry时，先注册`ChartSeriesFoundationModule`，再注册
`ChartScatterModule`以安装完整Scatter管线；Cartesian系列还需`ChartCartesianModule`，Polar系列则需
显式`ChartPolarModule`。若还要使用Mark、VisualMap等组件，再按需注册对应公共模块。

下面创建一个关闭动画的基础二维散点图。每一项按 `[x, y]` 解释；省略 symbol 配置时使用
10×10 的默认圆形和系列调色板颜色：

```csharp
var option = new ChartOption
{
    Animation = new() { Enabled = false },
    Grid = new ChartGridOption
    {
        Left = "48px",
        Top = "24px",
        Right = "24px",
        Bottom = "40px",
    },
    XAxis = new ChartXAxisOption
    {
        Type = ChartAxisType.Value,
        Minimum = ChartAxisBound.Fixed(0d),
        Maximum = ChartAxisBound.Fixed(20d),
    },
    YAxis = new ChartYAxisOption
    {
        Type = ChartAxisType.Value,
        Minimum = ChartAxisBound.Fixed(0d),
        Maximum = ChartAxisBound.Fixed(40d),
    },
    Series = new ChartScatterSeriesOption
    {
        Id = "measurements",
        Name = "Measurements",
        DataSource = new ChartScatterData
        {
            { 10d, 20d },
            { 15d, 32d },
            { 18d, 12d },
        },
    },
};

chart.SetOption(option);
```

`ChartScatterData`也支持标量/向量、富数据项以及公共`Dataset`/`Encode`数据路径。Scatter支持
内置/path/image/none symbol、尺寸/旋转/偏移回调、逐项样式、Label、四状态、Legend、Tooltip、
选择/焦点、Mark、VisualMap以及Normal/NormalProgressive/Large/LargeProgressive四种数据路径。
Cartesian使用X/Y轴并可消费DataZoom；Polar使用Radius/Angle轴，创建registry后需先调用
`ChartPolarModule.Register(registry)`，再把系列`CoordinateSystem`设为`"polar"`，必要时指定
`PolarId`或`PolarIndex`。Polar DataZoom和Polar markArea不在当前支持范围。

Normal Scatter支持首次、更新、添加、删除、重排和中断续播。可用
`AnimationDuration`/`AnimationDelay`配置首次动画，用对应的`Update`字段配置更新动画；也可设置
逐项timing回调。需要跨系列形状过渡时，开启`UniversalTransitionEnabled`并设置稳定系列ID、
`UniversalTransitionSeriesKey`以及数据项`Id`/`GroupId`/`ChildGroupId`。Scatter可与Scatter、Line、
Bar、Pie通过共享Symbol handoff进行一对一、一对多或多对一过渡，`UniversalTransitionDivideShape`
控制`Clone`或`Split`。

若需要检查配置问题，可读取：

```csharp
foreach (var diagnostic in chart.Engine.Diagnostics.Items)
{
    Console.WriteLine($"{diagnostic.Severity}: {diagnostic.Code} @ {diagnostic.OptionPath}");
}
```

## 生命周期与线程

`UIChart` 拥有内部 `ChartEngine`、场景与 Registry 订阅：

```csharp
// 临时从树上移除，之后仍可重新挂载。
root.RemoveChild(chart);

// 永久移除并释放图表。
root.RemoveChildAndDispose(chart);

// 或由调用方直接释放。
chart.Dispose();
```

`SetOption`、`DispatchAction`、`Render` 和释放操作应在图表 owner/UI 线程调用。后台线程可以提交
Registry 注册；宿主会请求 UI dispatcher 在 owner 线程应用变更。

`SKTypeface` 在 Theme、Label 和 TextStyle 中是借用资源，图表的 clone/snapshot 不会释放它；
调用方必须保证字体在整个使用期间存活。

## 当前限制

- Candlestick 支持完整静态 Cartesian 视觉、四状态、Label/Legend/Tooltip/VisualMap/Mark、选择、
  focus/blur、cursor、silent、category/连续轴 DataZoom、slider、Brush、多系列/多 Grid、AppendData
  以及四种性能模式。Large/LargeProgressive 的逐项样式、Label、状态、选择、Brush、非纯色渐变与
  varying VisualMap 按上文明确降级；逐项动画和 Universal Transition 只在 Normal 模式启用。
  Candlestick DataZoom 仅支持 `Filter`/`None`，Brush 仅支持上述 Cartesian 类型和视觉通道。
- Gauge 不使用 Cartesian/Polar axis、axisPointer、DataZoom、stack、large、progressive 或 sampling，
  也不支持拖动指针改值。Gauge axisLabel 只使用固定 min/max 的线性刻度，不提供 time/log/category
  scale。title formatter/valueAnimation 与逐项 pointer icon/show/showAbove、progress 几何覆盖按
  官方 GaugeView 语义保持惰性；这些配置会产生明确提示，而不会伪装成已生效。
- Scatter当前支持Cartesian与显式Polar、完整symbol/visual/Label/交互/VisualMap、Normal动画与
  Universal Transition以及large/progressive。NormalProgressive、Large和LargeProgressive不会为动画或
  UT展开逐项owner；Geo、SingleAxis、Calendar、Matrix、Polar DataZoom和Polar markArea也不支持。
  无法在compact PointBatch中逐项表达的回调、Label或状态会给出明确能力提示。
- Tooltip 不执行 HTML、CSS 或 JavaScript。
- Polar MarkArea 尚不支持；Polar Line 的 step、endLabel 和 sampling 也不适用。
- 基础 Skia 文本不承诺浏览器 Canvas 像素一致性，也不承诺完整复杂脚本 shaping 与双向排版。
- 透明画刷默认按几何参与命中。需要仅命中可见画刷时，应为图形选择
  `ChartBrushHitTestMode.VisiblePaint`。
- `ChartPathElement.Path` 允许调用方原位修改；修改后应确保相关布局、命中和重绘由调用方同步更新。
