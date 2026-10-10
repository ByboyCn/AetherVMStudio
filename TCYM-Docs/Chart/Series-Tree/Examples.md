# Tree 树图示例

> **Chart 版本**：`0.1.1.25`　**来源**：`TCYM.UI.Example/Page/Charts/Tree`

默认注册表已包含 Tree 模块。节点使用父子层级数据，不需要坐标轴；点击分支折叠/展开，Ctrl+滚轮缩放，拖动平移，普通滚轮滚动页面。

## 案例

| 案例 | 源码 | 配置 |
| --- | --- | --- |
| 公司树图 | `CompanyTreeChartDemo.cs` | 自适应组织结构、卡片节点与正交折线 |
| 从左到右 | `LeftToRightTreeChartDemo.cs` | LR 方向与正交折线 |
| 从右到左 | `RightToLeftTreeChartDemo.cs` | RL 方向与曲线连接 |
| 从上到下 | `TopToBottomTreeChartDemo.cs` | TB 方向与曲线连接 |

## 公司树图

````csharp CompanyTreeChartDemo.cs
using SkiaSharp;
using TCYM.UI.Chart.Components.Tooltip;
using TCYM.UI.Chart.Data;
using TCYM.UI.Chart.Model;
using TCYM.UI.Chart.Rendering;

namespace Page.Charts.Tree;

/// <summary>公司、五个部门和十个小组的组织架构，保留负责人和职位。</summary>
internal sealed class CompanyTreeChartDemo : TreeChartDemoPage
{
    private const string SeriesId = "company-organization";
    private const float SideMargin = 64;
    private readonly ChartTreeNode _root;

    // Value 携带不可变业务信息，提交后不会被外部修改影响。
    private sealed record OrganizationInfo(string Owner, string? Position) : IChartImmutableDataValue;

    internal CompanyTreeChartDemo() : base(
        "公司架构图",
        "星辰科技 → 五个职能部门 → 十个业务小组。",
        "卡片显示部门和负责人，根节点显示总经理职位；悬停查看完整信息。点击公司或部门折叠/展开，卡片宽度随容器调整，窄窗口中的小组名称自动分行。",
        CreateOption(out var root))
    {
        _root = root;
    }

    private static ChartOption CreateOption(out ChartTreeNode root)
    {
        // 1. 按用户提供的 JSON 原样保留 id、名称、负责人和层级关系。
        root = Node("company", "星辰科技", "王明",
        [
            Node("tech", "技术研发部", "赵宁",
            [
                Node("frontend", "前端开发组", "张晨"),
                Node("backend", "后端开发组", "林远"),
            ]),
            Node("product", "产品设计部", "李悦",
            [
                Node("planning", "产品规划组", "许欣"),
                Node("experience", "用户体验组", "苏晴"),
            ]),
            Node("sales", "市场销售部", "陈浩",
            [
                Node("marketing", "市场推广组", "杨帆"),
                Node("accounts", "客户销售组", "吴凯"),
            ]),
            Node("operations", "运营服务部", "刘敏",
            [
                Node("business", "业务运营组", "郑宇"),
                Node("support", "客户服务组", "何佳"),
            ]),
            Node("admin", "财务行政部", "周静",
            [
                Node("finance", "财务管理组", "孙琳"),
                Node("hr", "人事行政组", "徐婷"),
            ]),
        ], position: "总经理");

        // 2. 完整 Options 保留在本类，不把 Tree 配置放进公共页面。
        return new ChartOption
        {
            Background = ChartBrush.Solid(SKColors.White),
            Animation = new() { Enabled = true },
            Tooltip = new()
            {
                Trigger = ChartTooltipTrigger.Item,
                Confine = true,
                FormatterCallback = static (in ChartTooltipFormatterContext context) =>
                {
                    if (context.Parameters.Count == 0) return ChartTooltipContent.FromText("");
                    var item = context.Parameters[0];
                    if (item.Value.Primary.ToObject() is not OrganizationInfo info)
                        return ChartTooltipContent.FromText(item.Name);
                    return ChartTooltipContent.FromText(
                        $"{item.Name}\r\
负责人：{info.Owner}" +
                        (string.IsNullOrEmpty(info.Position) ? "" : $"\r\
职位：{info.Position}"));
                },
            },
            Series = new ChartTreeSeriesOption
            {
                Id = SeriesId, Name = "星辰科技组织架构",
                DataSource = new ChartTreeData().Add(root),
                Layout = ChartTreeLayout.Orthogonal,
                Orient = ChartTreeOrient.TB,
                EdgeShape = ChartTreeEdgeShape.Polyline,
                EdgeForkPosition = ChartLength.Percent(50),
                InitialTreeDepth = -1,
                ExpandAndCollapse = true,
                Roam = true,
                Left = ChartLength.Pixels(SideMargin), Right = ChartLength.Pixels(SideMargin),
                Top = ChartLength.Pixels(80), Bottom = ChartLength.Pixels(90),
                Symbol = "roundRect",
                SymbolSize = new ChartSymbolSize(140, 68),
                LineStyle = new() { Color = ChartBrush.Solid(new SKColor(138, 166, 200)), Width = 2 },
                Label = new() { Show = true, Position = "inside", Align = ChartTextAlign.Center },
                Emphasis = new()
                {
                    ItemStyle = new() { BorderColor = ChartBrush.Solid(new SKColor(255, 183, 77)), BorderWidth = 3 },
                },
            },
        };
    }

    private static ChartTreeNode Node(string id, string name, string owner,
        ChartTreeNode[]? children = null, string? position = null)
    {
        var isRoot = id == "company";
        var isTeam = children is null || children.Length == 0;
        var textColor = isTeam ? new SKColor(35, 63, 98) : SKColors.White;
        var node = new ChartTreeNode
        {
            Id = id, Name = name,
            Value = ChartValue.FromObject(new OrganizationInfo(owner, position)),
            SymbolSize = isRoot ? new ChartSymbolSize(188, 84)
                : isTeam ? new ChartSymbolSize(116, 64) : new ChartSymbolSize(144, 68),
            ItemStyle = new()
            {
                Color = ChartBrush.Solid(isRoot ? new SKColor(38, 70, 116)
                    : isTeam ? new SKColor(240, 246, 253) : new SKColor(40, 111, 199)),
                BorderColor = ChartBrush.Solid(isTeam ? new SKColor(166, 192, 224) : SKColors.White),
                BorderWidth = 1.5f,
                ShadowBlur = 5,
                ShadowColor = ChartBrush.Solid(new SKColor(67, 106, 155, 35)),
            },
            Label = new()
            {
                Show = true, Position = "inside", Align = ChartTextAlign.Center,
                Formatter = $"{{title|{name}}}\
{{owner|{owner}{(position is null ? "" : " · " + position)}}}",
                Rich = new()
                {
                    ["title"] = new ChartTextStyle
                    {
                        Color = ChartBrush.Solid(textColor), FontSize = isRoot ? 20 : 14,
                        FontWeight = 600, LineHeight = isRoot ? 28 : 22, Align = ChartTextAlign.Center,
                    },
                    ["owner"] = new ChartTextStyle
                    {
                        Color = ChartBrush.Solid(textColor), FontSize = isRoot ? 14 : 12,
                        LineHeight = 20, Align = ChartTextAlign.Center,
                    },
                },
            },
        };
        foreach (var child in children ?? []) node.Children.Add(child);
        return node;
    }

    protected override void OnChartSizeChanged(SKSize size)
    {
        // 十个小组占十个叶槽。限制卡片宽度，避免窄窗口内相邻卡片重叠。
        var slot = MathF.Max(1, (size.Width - SideMargin * 2) / 9);
        var teamWidth = Math.Clamp(slot - 8, 44, 116);
        var departmentWidth = Math.Clamp(slot * 2 - 12, 72, 144);
        var compact = teamWidth < 96;
        foreach (var department in _root.Children)
        {
            department.SymbolSize = new ChartSymbolSize(departmentWidth, 68);
            department.Label.Rich["title"].FontSize = Math.Clamp((departmentWidth - 12) / 5, 11, 14);
            foreach (var team in department.Children)
            {
                team.SymbolSize = new ChartSymbolSize(teamWidth, compact ? 80 : 64);
                var info = (OrganizationInfo)team.Value.ToObject()!;
                var name = team.Name!;
                // 仅改变显示换行；Tooltip 和业务 Name 始终保留完整名称。
                var title = compact ? $"{{title|{name[..2]}}}\
{{title|{name[2..]}}}" : $"{{title|{name}}}";
                team.Label.Formatter = title + $"\
{{owner|{info.Owner}}}";
                team.Label.Rich["title"].FontSize = compact ? Math.Clamp((teamWidth - 12) / 3, 10, 14) : 14;
            }
        }
        Chart.SetOption(new ChartOption
        {
            Series = new ChartTreeSeriesOption { Id = SeriesId, DataSource = new ChartTreeData().Add(_root) },
        }, new ChartSetOptionOptions { LazyUpdate = true });
    }
}
````

## 从左到右

````csharp LeftToRightTreeChartDemo.cs
using SkiaSharp;
using TCYM.UI.Chart.Components.Common;
using TCYM.UI.Chart.Model;
using TCYM.UI.Chart.Rendering;

namespace Page.Charts.Tree;

/// <summary>从左到右树状图；完整 Options 和数据均在本类中创建。</summary>
internal sealed class LeftToRightTreeChartDemo : TreeChartDemoPage
{
    internal LeftToRightTreeChartDemo() : base(
        "从左到右树状图",
        "展示 ROOT、ALPHA、BETA、GAMMA 的层级关系，以及最深层的 DEEP。",
        "蓝色分支配深蓝标签，橙色叶子配浅黄色标签；采用直角折线，在父子节点中间分叉。初始全部展开，点击分支可折叠/展开。",
        CreateOption()) { }

    private static ChartOption CreateOption()
    {
        // 本类保留完整原始数据，便于单独复制这个案例。
        var root = new ChartTreeNode
        {
            Id = "root", Name = "ROOT",
            Children =
            {
                new ChartTreeNode
                {
                    Id = "alpha", Name = "ALPHA",
                    Children =
                    {
                        new ChartTreeNode { Id = "a-one", Name = "A ONE" },
                        new ChartTreeNode { Id = "a-two", Name = "A TWO" },
                    },
                },
                new ChartTreeNode
                {
                    Id = "beta", Name = "BETA",
                    Children =
                    {
                        new ChartTreeNode
                        {
                            Id = "b-one", Name = "B ONE",
                            Children = { new ChartTreeNode { Id = "deep", Name = "DEEP" } },
                        },
                        new ChartTreeNode { Id = "b-two", Name = "B TWO" },
                    },
                },
                new ChartTreeNode { Id = "gamma", Name = "GAMMA" },
            },
        };
        return new ChartOption
        {
            Background = ChartBrush.Solid(SKColors.White),
            Animation = new() { Enabled = true },
            Tooltip = new() { Trigger = ChartTooltipTrigger.Item, Formatter = "{b}", Confine = true },
            Series = new ChartTreeSeriesOption
            {
                Id = "tree-lr", Name = "从左到右树状图",
                DataSource = new ChartTreeData().Add(root),
                Layout = ChartTreeLayout.Orthogonal,
                Orient = ChartTreeOrient.LR,
                EdgeShape = ChartTreeEdgeShape.Polyline,
                EdgeForkPosition = ChartLength.Percent(50),
                InitialTreeDepth = -1,
                ExpandAndCollapse = true,
                Roam = true,
                Left = ChartLength.Pixels(80), Right = ChartLength.Pixels(120),
                Top = ChartLength.Pixels(65), Bottom = ChartLength.Pixels(65),
                Symbol = "circle", SymbolSize = 22,
                ItemStyle = new()
                {
                    Color = ChartBrush.Solid(new SKColor(40, 111, 199)),
                    BorderColor = ChartBrush.Solid(SKColors.White), BorderWidth = 2,
                },
                LineStyle = new() { Color = ChartBrush.Solid(new SKColor(116, 143, 172)), Width = 2 },
                Label = new()
                {
                    Show = true, Position = "top", Distance = 10, FontSize = 16,
                    Color = ChartBrush.Solid(new SKColor(35, 49, 68)),
                    Formatter = "{branch|{b}}",
                    Rich = new()
                    {
                        ["branch"] = new ChartTextStyle
                        {
                            FontSize = 15, Color = ChartBrush.Solid(SKColors.White),
                            BackgroundColor = ChartBrush.Solid(new SKColor(38, 70, 116)),
                            Padding = new ChartInsets(4, 6, 4, 6), BorderRadius = 4,
                        },
                    },
                },
                Leaves = new()
                {
                    ItemStyle = new() { Color = ChartBrush.Solid(new SKColor(224, 135, 39)) },
                    Label = new()
                    {
                        Show = true, Position = "right", Distance = 10, FontSize = 16,
                        Color = ChartBrush.Solid(new SKColor(35, 49, 68)),
                        Formatter = "{leaf|{b}}",
                        Rich = new()
                        {
                            ["leaf"] = new ChartTextStyle
                            {
                                FontSize = 15, Color = ChartBrush.Solid(new SKColor(79, 49, 11)),
                                BackgroundColor = ChartBrush.Solid(new SKColor(255, 231, 188)),
                                Padding = new ChartInsets(3, 6, 3, 6), BorderRadius = 3,
                            },
                        },
                    },
                },
            },
        };
    }
}
````

## 从右到左

````csharp RightToLeftTreeChartDemo.cs
using SkiaSharp;
using TCYM.UI.Chart.Model;
using TCYM.UI.Chart.Rendering;

namespace Page.Charts.Tree;

/// <summary>从右到左树状图；完整 Options 和数据均在本类中创建。</summary>
internal sealed class RightToLeftTreeChartDemo : TreeChartDemoPage
{
    internal RightToLeftTreeChartDemo() : base(
        "从右到左树状图",
        "展示 ROOT、ALPHA、BETA、GAMMA 的层级关系，以及最深层的 DEEP。",
        "蓝色表示分支，橙色表示叶子，使用平滑曲线连接。初始全部展开，点击分支可折叠/展开。",
        CreateOption()) { }

    private static ChartOption CreateOption()
    {
        // 本类保留完整原始数据，便于单独复制这个案例。
        var root = new ChartTreeNode
        {
            Id = "root", Name = "ROOT",
            Children =
            {
                new ChartTreeNode
                {
                    Id = "alpha", Name = "ALPHA",
                    Children =
                    {
                        new ChartTreeNode { Id = "a-one", Name = "A ONE" },
                        new ChartTreeNode { Id = "a-two", Name = "A TWO" },
                    },
                },
                new ChartTreeNode
                {
                    Id = "beta", Name = "BETA",
                    Children =
                    {
                        new ChartTreeNode
                        {
                            Id = "b-one", Name = "B ONE",
                            Children = { new ChartTreeNode { Id = "deep", Name = "DEEP" } },
                        },
                        new ChartTreeNode { Id = "b-two", Name = "B TWO" },
                    },
                },
                new ChartTreeNode { Id = "gamma", Name = "GAMMA" },
            },
        };
        return new ChartOption
        {
            Background = ChartBrush.Solid(SKColors.White),
            Animation = new() { Enabled = true },
            Tooltip = new() { Trigger = ChartTooltipTrigger.Item, Formatter = "{b}", Confine = true },
            Series = new ChartTreeSeriesOption
            {
                Id = "tree-rl", Name = "从右到左树状图",
                DataSource = new ChartTreeData().Add(root),
                Layout = ChartTreeLayout.Orthogonal,
                Orient = ChartTreeOrient.RL,
                EdgeShape = ChartTreeEdgeShape.Curve,
                InitialTreeDepth = -1,
                ExpandAndCollapse = true,
                Roam = true,
                Left = ChartLength.Pixels(120), Right = ChartLength.Pixels(80),
                Top = ChartLength.Pixels(65), Bottom = ChartLength.Pixels(65),
                Symbol = "circle", SymbolSize = 22,
                ItemStyle = new()
                {
                    Color = ChartBrush.Solid(new SKColor(40, 111, 199)),
                    BorderColor = ChartBrush.Solid(SKColors.White), BorderWidth = 2,
                },
                LineStyle = new() { Color = ChartBrush.Solid(new SKColor(116, 143, 172)), Width = 2 },
                Label = new()
                {
                    Show = true, Position = "top", Distance = 10, FontSize = 16,
                    Color = ChartBrush.Solid(new SKColor(35, 49, 68)),
                    Formatter = "{b}",
                },
                Leaves = new()
                {
                    ItemStyle = new() { Color = ChartBrush.Solid(new SKColor(224, 135, 39)) },
                    Label = new()
                    {
                        Show = true, Position = "left", Distance = 10, FontSize = 16,
                        Color = ChartBrush.Solid(new SKColor(35, 49, 68)),
                        Formatter = "{b}",
                    },
                },
            },
        };
    }
}
````

## 从上到下

````csharp TopToBottomTreeChartDemo.cs
using SkiaSharp;
using TCYM.UI.Chart.Model;
using TCYM.UI.Chart.Rendering;

namespace Page.Charts.Tree;

/// <summary>从上到下树状图；完整 Options 和数据均在本类中创建。</summary>
internal sealed class TopToBottomTreeChartDemo : TreeChartDemoPage
{
    internal TopToBottomTreeChartDemo() : base(
        "从上到下树状图",
        "展示 ROOT、ALPHA、BETA、GAMMA 的层级关系，以及最深层的 DEEP。",
        "蓝色表示分支，橙色表示叶子，使用平滑曲线连接。初始全部展开，点击分支可折叠/展开。",
        CreateOption()) { }

    private static ChartOption CreateOption()
    {
        // 本类保留完整原始数据，便于单独复制这个案例。
        var root = new ChartTreeNode
        {
            Id = "root", Name = "ROOT",
            Children =
            {
                new ChartTreeNode
                {
                    Id = "alpha", Name = "ALPHA",
                    Children =
                    {
                        new ChartTreeNode { Id = "a-one", Name = "A ONE" },
                        new ChartTreeNode { Id = "a-two", Name = "A TWO" },
                    },
                },
                new ChartTreeNode
                {
                    Id = "beta", Name = "BETA",
                    Children =
                    {
                        new ChartTreeNode
                        {
                            Id = "b-one", Name = "B ONE",
                            Children = { new ChartTreeNode { Id = "deep", Name = "DEEP" } },
                        },
                        new ChartTreeNode { Id = "b-two", Name = "B TWO" },
                    },
                },
                new ChartTreeNode { Id = "gamma", Name = "GAMMA" },
            },
        };
        return new ChartOption
        {
            Background = ChartBrush.Solid(SKColors.White),
            Animation = new() { Enabled = true },
            Tooltip = new() { Trigger = ChartTooltipTrigger.Item, Formatter = "{b}", Confine = true },
            Series = new ChartTreeSeriesOption
            {
                Id = "tree-tb", Name = "从上到下树状图",
                DataSource = new ChartTreeData().Add(root),
                Layout = ChartTreeLayout.Orthogonal,
                Orient = ChartTreeOrient.TB,
                EdgeShape = ChartTreeEdgeShape.Curve,
                InitialTreeDepth = -1,
                ExpandAndCollapse = true,
                Roam = true,
                Left = ChartLength.Pixels(80), Right = ChartLength.Pixels(80),
                Top = ChartLength.Pixels(65), Bottom = ChartLength.Pixels(65),
                Symbol = "circle", SymbolSize = 22,
                ItemStyle = new()
                {
                    Color = ChartBrush.Solid(new SKColor(40, 111, 199)),
                    BorderColor = ChartBrush.Solid(SKColors.White), BorderWidth = 2,
                },
                LineStyle = new() { Color = ChartBrush.Solid(new SKColor(116, 143, 172)), Width = 2 },
                Label = new()
                {
                    Show = true, Position = "left", Distance = 10, FontSize = 16,
                    Color = ChartBrush.Solid(new SKColor(35, 49, 68)),
                    Formatter = "{b}",
                },
                Leaves = new()
                {
                    ItemStyle = new() { Color = ChartBrush.Solid(new SKColor(224, 135, 39)) },
                    Label = new()
                    {
                        Show = true, Position = "bottom", Distance = 10, FontSize = 16,
                        Color = ChartBrush.Solid(new SKColor(35, 49, 68)),
                        Formatter = "{b}",
                    },
                },
            },
        };
    }
}
````

## 页面容器与释放

````csharp TreeChartDemoPage.cs
using SkiaSharp;
using TCYM.UI.Chart;
using TCYM.UI.Chart.Core;
using TCYM.UI.Chart.Model;
using TCYM.UI.Core;
using TCYM.UI.Core.Routing;
using TCYM.UI.Elements;

namespace Page.Charts.Tree;

/// <summary>沿用 Lines 的页面结构；各具体案例自己创建完整 Options 和数据。</summary>
internal abstract class TreeChartDemoPage : UIScrollView, IUIRouteLifecycle
{
    private bool _disposed;
    private SKSize _chartSize;
    protected UIChart Chart { get; }

    protected TreeChartDemoPage(string title, string subtitle, string description, ChartOption option)
    {
        UISystem.LoadStyleFile("res://TCYM.UI.Example/Page.Charts.Tree.style.css");
        ShowScrollbar = false;
        Chart = new UIChart(ChartModules.CreateDefaultRegistry()) { ClassName = "tree-chart-canvas" };
        ClassName = "tree-chart-demo";
        Children =
        [
            new UILabel { Text = title, ClassName = "tree-chart-demo-title" },
            new UILabel { Text = subtitle, ClassName = "tree-chart-demo-subtitle" },
            new UILabel { Text = description, ClassName = "tree-chart-demo-description" },
            new UIView
            {
                ClassName = "tree-chart-preview-card",
                Children =
                [
                    new UILabel { Text = "效果预览", ClassName = "tree-chart-card-title" },
                    new UILabel
                    {
                        Text = "预览画布为 100% × 590；点击分支折叠/展开。Ctrl＋滚轮或触屏双指缩放，拖动平移；普通滚轮滚动页面。",
                        ClassName = "tree-chart-preview-help",
                    },
                    new UIScrollView
                    {
                        ClassName = "tree-chart-preview-scroll",
                        ShowScrollbar = false,
                        Children = [Chart],
                    },
                ],
            },
        ];
        Chart.SetOption(option, new ChartSetOptionOptions { NotMerge = true, LazyUpdate = true });
    }

    protected override void RenderContent(SKCanvas canvas)
    {
        if (!_disposed)
        {
            var inset = MathF.Max(0, Chart.BorderWidth);
            var size = new SKSize(
                MathF.Max(0, Chart.Width - inset * 2 - Chart.PaddingLeft - Chart.PaddingRight) / EffectiveLayoutDpiScale,
                MathF.Max(0, Chart.Height - inset * 2 - Chart.PaddingTop - Chart.PaddingBottom) / EffectiveLayoutDpiScale);
            if (size.Width > 0 && size.Height > 0 && size != _chartSize)
            {
                _chartSize = size;
                OnChartSizeChanged(size);
            }
        }
        base.RenderContent(canvas);
    }

    /// <summary>普通 Tree 由原生布局自动适应；公司案例在这里按可用宽度调整卡片。</summary>
    protected virtual void OnChartSizeChanged(SKSize size) { }

    public void OnRouteEnter(string? fromPath) { }
    public void OnRouteLeave(string? toPath)
    {
        if (_disposed) return;
        _disposed = true;
        Chart.Clear();
        Chart.Dispose();
    }

    internal static TreeChartDemoPage CreateCompany() => new CompanyTreeChartDemo();
    internal static TreeChartDemoPage CreateLeftToRight() => new LeftToRightTreeChartDemo();
    internal static TreeChartDemoPage CreateTopToBottom() => new TopToBottomTreeChartDemo();
    internal static TreeChartDemoPage CreateRightToLeft() => new RightToLeftTreeChartDemo();
}
````

## 示例样式

````css style.css
/* 各 Tree 页面沿用组件 Demo 的标题、说明和白色预览卡片布局。 */
.tree-chart-demo {
    width: 100%;
    height: 100%;
    overflow-x: hidden;
    padding-right: 8px;
    padding-bottom: 22px;
}

.tree-chart-demo-title {
    width: 100%;
    min-height: 38px;
    display: flex;
    align-items: center;
    font-size: 30px;
    font-weight: bold;
    color: rgba(0, 0, 0, 0.9);
}

.tree-chart-demo-subtitle {
    width: 100%;
    min-height: 24px;
    margin-top: 4px;
    font-size: 14px;
    color: rgba(0, 0, 0, 0.72);
}

.tree-chart-demo-description {
    width: 100%;
    min-height: 42px;
    margin-top: 10px;
    padding: 10px 14px;
    border: 1px solid #bae0ff;
    border-radius: 7px;
    background: #e6f4ff;
    color: #0958d9;
    font-size: 13px;
}

.tree-chart-preview-card {
    width: 100%;
    margin-top: 12px;
    padding: 14px 16px 16px 16px;
    border: 1px solid rgba(0, 0, 0, 0.1);
    border-radius: 8px;
    background: #ffffff;
}

.tree-chart-card-title {
    width: 100%;
    min-height: 24px;
    font-size: 15px;
    font-weight: bold;
    color: rgba(0, 0, 0, 0.86);
}

.tree-chart-preview-help {
    width: 100%;
    min-height: 22px;
    margin-bottom: 8px;
    font-size: 12px;
    color: rgba(0, 0, 0, 0.58);
}

.tree-chart-preview-scroll {
    width: 100%;
    min-height: 600px;
    display: flex;
    align-items: center;
    justify-content: center;
    overflow-x: auto;
    overflow-y: hidden;
}

.tree-chart-canvas {
    width: 100%;
    height: 590px;
}
````
