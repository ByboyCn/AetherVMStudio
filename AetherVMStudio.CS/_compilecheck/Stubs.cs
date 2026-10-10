// 编译验证用桩:模拟 TCYM.UI 真实命名空间布局。仅在 _compilecheck 中使用。
using SkiaSharp;

namespace TCYM.UI.Core
{
    public class UnitValue
    {
        public float Value;
        public string Unit = "px";
        public static UnitValue Pixels(float v) => new() { Value = v };
        public static UnitValue Percent(float v) => new() { Value = v, Unit = "%" };
        public static implicit operator UnitValue(float v) => Pixels(v);
    }

    public class UIStyle
    {
        public string Display = "";
        public string Position = "";
        public string Overflow = "";
        public string? OverflowX, OverflowY;
        public UnitValue? Width, Height, MinWidth, MaxWidth, MinHeight, MaxHeight;
        public UnitValue FlexBasis;
        public float FlexGrow, FlexShrink;
        public string FlexDirection = "", JustifyContent = "", AlignItems = "", AlignSelf = "", FlexWrap = "";
        public UnitValue Gap;
        public float PaddingTop, PaddingRight, PaddingBottom, PaddingLeft;
        public float MarginTop, MarginRight, MarginBottom, MarginLeft;
        public SKColor BackgroundColor = new();
        public SKColor Color;
        public UnitValue? FontSize;
        public float FontWeight;
        public string TextAlign = "";
        public float Opacity = 1f;
        public UnitValue BorderRadius;
        public float BorderWidth;
        public SKColor BorderColor = new();
        public string BorderStyle = "";
        public SKTypeface? FontFamily;
    }

    public class DefaultUIStyle : UIStyle { }

    public class UIElementCollection : System.Collections.Generic.IList<UIElement>
    {
        private readonly System.Collections.Generic.List<UIElement> _list = new();
        public int Count => _list.Count;
        public bool IsReadOnly => false;
        public UIElement this[int index] { get => _list[index]; set => _list[index] = value; }
        public void Add(UIElement item) => _list.Add(item);
        public void Clear() => _list.Clear();
        public bool Contains(UIElement item) => _list.Contains(item);
        public void CopyTo(UIElement[] array, int i) => _list.CopyTo(array, i);
        public System.Collections.Generic.IEnumerator<UIElement> GetEnumerator() => _list.GetEnumerator();
        public int IndexOf(UIElement item) => _list.IndexOf(item);
        public void Insert(int i, UIElement item) => _list.Insert(i, item);
        public bool Remove(UIElement item) => _list.Remove(item);
        public void RemoveAt(int i) => _list.RemoveAt(i);
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class UIMouseEvent { }
    public class UIKeyboardEvent { }
    public class UITouchEvent { }

    public abstract class UIElement
    {
        public UIElementCollection Children { get; } = new();
        public string Id = "";
        public UIStyle? Style { get; set; }
        public float X, Y, Width, Height;
        public string Display = "";
        public event System.Action<UIMouseEvent>? OnClick;
        public event System.Func<UIMouseEvent, System.Threading.Tasks.Task>? OnClickAsync;
        public void AddChild(UIElement child) => Children.Add(child);
        public void UpdateStyle(UIStyle updates) { }
        protected void RaiseClick() => OnClick?.Invoke(new UIMouseEvent());
        public void RequestLayout() { }
    }

    public class UIView : UIElement
    {
        public UIView() { }
    }

    public class UILabel : UIView
    {
        public string Text { get; set; } = "";
        public bool Wrap { get; set; }
        public int MaxLines { get; set; }
        public bool Ellipsize { get; set; }
    }

    public class UIButton : UILabel
    {
        public bool Disabled { get; set; }
    }

    public class UIInput : UIElement
    {
        public string Text { get; set; } = "";
        public string Placeholder { get; set; } = "";
        public bool ReadOnly { get; set; }
        public bool Disabled { get; set; }
        public event System.Action<string>? OnValuesChange;
        public void RaiseChange(string t) => OnValuesChange?.Invoke(t);
    }

    public class UITextArea : UIElement
    {
        public string Text { get; set; } = "";
        public string Placeholder { get; set; } = "";
        public int Rows { get; set; } = 4;
        public bool ReadOnly { get; set; }
        public bool Disabled { get; set; }
        public SKColor InputBackground { get; set; }
        public SKColor InputTextColor { get; set; }
        public SKColor InputBorderColor { get; set; }
        public SKColor InputFocusBorderColor { get; set; }
        public SKColor CursorColor { get; set; }
        public event System.Action<string>? OnValuesChange;
        public void RaiseChange(string t) => OnValuesChange?.Invoke(t);
    }

    public class UIManager
    {
        public UIElement Root { get; } = new UIView();
        public float DpiScale => 1f;
    }

    public class UIWindow
    {
        public UIManager Manager { get; } = new();
        public bool IsClosed { get; }
        public void Show() { }
        public void Close() { }
    }

    public class UIApp
    {
        public static void Run(System.Action<UIApp> initialize) { }
        public static void Run(System.Func<UIApp, System.Threading.Tasks.Task> initialize) { }
        public UIWindow CreateWindow(string title = "TCYM.UI", int width = 800, int height = 600,
            bool enableGpu = true, int targetFps = 60, bool autoShow = true, bool resizable = true)
            => new();
        public System.Collections.Generic.IReadOnlyCollection<UIWindow> Windows { get; } =
            new System.Collections.Generic.List<UIWindow>();
        public void Post(System.Action action) { }
    }
}

namespace SkiaSharp
{
    public struct SKColor
    {
        public SKColor(byte r, byte g, byte b, byte a = 255) { }
        public static SKColor Parse(string hex) => new();
    }
    public static class SKColors
    {
        public static readonly SKColor White = new();
    }
    public class SKCanvas { }
    public class SKTypeface { }
}

namespace TCYM.UI.Elements
{
    // 与真实包一致:组件位于 TCYM.UI.Elements 命名空间
    public class UIView : global::TCYM.UI.Core.UIView { }
    public class UILabel : global::TCYM.UI.Core.UILabel { }
    public class UIButton : global::TCYM.UI.Core.UIButton { }
}

namespace TCYM.UI.Elements.Input
{
    public class UIInput : global::TCYM.UI.Core.UIInput { }
    public class UITextArea : global::TCYM.UI.Core.UITextArea { }
}
