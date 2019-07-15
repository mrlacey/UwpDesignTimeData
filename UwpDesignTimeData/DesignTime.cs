using System;
using System.Reflection;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace UwpDesignTimeData
{
    public class DesignTime : DependencyObject
    {
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty DescriptionProperty =
                    DependencyProperty.Register("Description", typeof(object), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty HeaderProperty =
                    DependencyProperty.Register("Header", typeof(object), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty PlaceholderTextProperty =
                    DependencyProperty.Register("PlaceholderText", typeof(string), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty ContentProperty =
                    DependencyProperty.Register("Content", typeof(object), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty IsCheckedProperty =
                    DependencyProperty.Register("IsChecked", typeof(bool), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty FooterProperty =
                    DependencyProperty.Register("Footer", typeof(object), typeof(DesignTime), new PropertyMetadata(null));

        // Some controls have a Title property that is a string and some an object. Use object as a catch-all
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(object), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty PaneFooterProperty =
                    DependencyProperty.Register("PaneFooter", typeof(object), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty PaneHeaderProperty =
                    DependencyProperty.Register("PaneHeader", typeof(object), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty PaneTitleProperty =
            DependencyProperty.Register("PaneTitle", typeof(string), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty PasswordCharProperty =
            DependencyProperty.Register("PasswordChar", typeof(string), typeof(DesignTime), new PropertyMetadata(null));


        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty MinimumProperty =
            DependencyProperty.Register("Minimum", typeof(double), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty MaximumProperty =
            DependencyProperty.Register("Maximum", typeof(double), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty PlaceholderValueProperty =
            DependencyProperty.Register("PlaceholderValue", typeof(double), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty MaxRatingProperty =
            DependencyProperty.Register("MaxRating", typeof(int), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty CaptionProperty =
            DependencyProperty.Register("Caption", typeof(string), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty QueryTextProperty =
            DependencyProperty.Register("QueryText", typeof(string), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty IsOnProperty =
            DependencyProperty.Register("IsOn", typeof(bool), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty OnContentProperty =
            DependencyProperty.Register("OnContent", typeof(object), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty OffContentProperty =
            DependencyProperty.Register("OffContent", typeof(object), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(IconElement), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty SymbolProperty =
            DependencyProperty.Register("Symbol", typeof(Symbol), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty TimeProperty =
            DependencyProperty.Register("Time", typeof(string), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty DateProperty =
            DependencyProperty.Register("Date", typeof(string), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(ImageSource), typeof(DesignTime), new PropertyMetadata(null));

        public static readonly DependencyProperty FlowDirectionProperty =
            DependencyProperty.Register("FlowDirection", typeof(FlowDirection), typeof(DesignTime), new PropertyMetadata(null));

        private static void SetInDesigner(string propertyName, UIElement element, object value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                var dprop = element.GetType().GetProperty(propertyName);
                if (dprop != null)
                {
                    element.SetValue((DependencyProperty)dprop.GetValue(element), value);
                }
            }
        }

        private static void SetInDesigner(Type elementType, DependencyProperty dependencyProperty, UIElement element, object value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (elementType.IsAssignableFrom(element.GetType()))
                {
                    element.SetValue(dependencyProperty, value);
                }
            }
        }

        public static void SetText(UIElement element, string value)
        {
            element.SetValue(DesignTime.TextProperty, value);
            SetInDesigner(nameof(TextProperty), element, value);
        }

        public static string GetText(UIElement element)
        {
            return (string)element.GetValue(DesignTime.TextProperty);
        }

        public static void SetDescription(UIElement element, object value)
        {
            element.SetValue(DesignTime.DescriptionProperty, value);
            SetInDesigner(nameof(DescriptionProperty), element, value);
        }

        public static object GetDescription(UIElement element)
        {
            return (object)element.GetValue(DesignTime.DescriptionProperty);
        }

        public static void SetHeader(UIElement element, object value)
        {
            element.SetValue(DesignTime.HeaderProperty, value);
            SetInDesigner(nameof(HeaderProperty), element, value);
        }

        public static object GetHeader(UIElement element)
        {
            return (object)element.GetValue(DesignTime.HeaderProperty);
        }

        public static void SetPlaceholderText(UIElement element, string value)
        {
            element.SetValue(DesignTime.PlaceholderTextProperty, value);
            SetInDesigner(nameof(PlaceholderTextProperty), element, value);
        }

        public static string GetPlaceholderText(UIElement element)
        {
            return (string)element.GetValue(DesignTime.PlaceholderTextProperty);
        }

        public static void SetContent(UIElement element, object value)
        {
            element.SetValue(DesignTime.ContentProperty, value);

            // ContentControl works a bit differently to other properties
            // and so we need to set the design-time value on ContentControl directly.
            SetInDesigner(typeof(ContentControl), ContentControl.ContentProperty, element, value);
        }

        public static object GetContent(UIElement element)
        {
            return (object)element.GetValue(DesignTime.ContentProperty);
        }

        public static void SetIsChecked(UIElement element, bool value)
        {
            element.SetValue(DesignTime.IsCheckedProperty, value);
            SetInDesigner(nameof(IsCheckedProperty), element, value);
        }

        public static bool GetIsChecked(UIElement element)
        {
            return (bool)element.GetValue(DesignTime.IsCheckedProperty);
        }

        public static void SetFooter(UIElement element, object value)
        {
            element.SetValue(DesignTime.FooterProperty, value);
            SetInDesigner(nameof(FooterProperty), element, value);
        }

        public static object GetFooter(UIElement element)
        {
            return (object)element.GetValue(DesignTime.FooterProperty);
        }

        public static void SetTitle(UIElement element, object value)
        {
            element.SetValue(DesignTime.TitleProperty, value);
            SetInDesigner(nameof(TitleProperty), element, value);
        }

        public static object GetTitle(UIElement element)
        {
            return (object)element.GetValue(DesignTime.TitleProperty);
        }

        public static void SetPaneFooter(UIElement element, object value)
        {
            element.SetValue(DesignTime.PaneFooterProperty, value);
            SetInDesigner(nameof(PaneFooterProperty), element, value);
        }

        public static object GetPaneFooter(UIElement element)
        {
            return (object)element.GetValue(DesignTime.PaneFooterProperty);
        }

        public static void SetPaneHeader(UIElement element, object value)
        {
            element.SetValue(DesignTime.PaneHeaderProperty, value);
            SetInDesigner(nameof(PaneHeaderProperty), element, value);
        }

        public static object GetPaneHeader(UIElement element)
        {
            return (object)element.GetValue(DesignTime.PaneHeaderProperty);
        }

        public static void SetPaneTitle(UIElement element, object value)
        {
            element.SetValue(DesignTime.PaneTitleProperty, value);
            SetInDesigner(nameof(PaneTitleProperty), element, value);
        }

        public static object GetPaneTitle(UIElement element)
        {
            return (object)element.GetValue(DesignTime.PaneTitleProperty);
        }

        public static void SetPassword(UIElement element, string value)
        {
            element.SetValue(DesignTime.PasswordProperty, value);
            SetInDesigner(nameof(PasswordProperty), element, value);
        }

        public static string GetPassword(UIElement element)
        {
            return (string)element.GetValue(DesignTime.PasswordProperty);
        }

        public static void SetPasswordChar(UIElement element, string value)
        {
            element.SetValue(DesignTime.PasswordCharProperty, value);
            SetInDesigner(nameof(PasswordCharProperty), element, value);
        }

        public static string GetPasswordChar(UIElement element)
        {
            return (string)element.GetValue(DesignTime.PasswordCharProperty);
        }

        public static void SetValue(UIElement element, double value)
        {
            element.SetValue(DesignTime.ValueProperty, value);
            SetInDesigner(nameof(ValueProperty), element, value);
        }

        public static double GetValue(UIElement element)
        {
            return (double)element.GetValue(DesignTime.ValueProperty);
        }

        public static void SetMinimum(UIElement element, double value)
        {
            element.SetValue(DesignTime.MinimumProperty, value);
            SetInDesigner(nameof(MinimumProperty), element, value);
        }

        public static double GetMinimum(UIElement element)
        {
            return (double)element.GetValue(DesignTime.MinimumProperty);
        }

        public static void SetMaximum(UIElement element, double value)
        {
            element.SetValue(DesignTime.MaximumProperty, value);
            SetInDesigner(nameof(MaximumProperty), element, value);
        }

        public static double GetMaximum(UIElement element)
        {
            return (double)element.GetValue(DesignTime.MaximumProperty);
        }

        public static void SetPlaceholderValue(UIElement element, double value)
        {
            element.SetValue(DesignTime.PlaceholderValueProperty, value);
            SetInDesigner(nameof(PlaceholderValueProperty), element, value);
        }

        public static double GetPlaceholderValue(UIElement element)
        {
            return (double)element.GetValue(DesignTime.PlaceholderValueProperty);
        }

        public static void SetMaxRating(UIElement element, int value)
        {
            element.SetValue(DesignTime.MaxRatingProperty, value);
            SetInDesigner(nameof(MaxRatingProperty), element, value);
        }

        public static int GetMaxRating(UIElement element)
        {
            return (int)element.GetValue(DesignTime.MaxRatingProperty);
        }

        public static void SetCaption(UIElement element, string value)
        {
            element.SetValue(DesignTime.CaptionProperty, value);
            SetInDesigner(nameof(CaptionProperty), element, value);
        }

        public static string GetCaption(UIElement element)
        {
            return (string)element.GetValue(DesignTime.MaxRatingProperty);
        }

        public static void SetQueryText(UIElement element, string value)
        {
            element.SetValue(DesignTime.QueryTextProperty, value);
            SetInDesigner(nameof(QueryTextProperty), element, value);
        }

        public static string GetQueryText(UIElement element)
        {
            return (string)element.GetValue(DesignTime.QueryTextProperty);
        }

        public static void SetIsOn(UIElement element, bool value)
        {
            element.SetValue(DesignTime.IsOnProperty, value);
            SetInDesigner(nameof(IsOnProperty), element, value);
        }

        public static bool GetIsOn(UIElement element)
        {
            return (bool)element.GetValue(DesignTime.IsOnProperty);
        }

        public static void SetOnContent(UIElement element, object value)
        {
            element.SetValue(DesignTime.OnContentProperty, value);
            SetInDesigner(nameof(OnContentProperty), element, value);
        }

        public static object GetOnContent(UIElement element)
        {
            return (object)element.GetValue(DesignTime.OnContentProperty);
        }

        public static void SetOffContent(UIElement element, object value)
        {
            element.SetValue(DesignTime.OffContentProperty, value);
            SetInDesigner(nameof(OffContentProperty), element, value);
        }

        public static object GetOffContent(UIElement element)
        {
            return (object)element.GetValue(DesignTime.OffContentProperty);
        }

        public static void SetIcon(UIElement element, IconElement value)
        {
            element.SetValue(DesignTime.IconProperty, value);
            SetInDesigner(nameof(IconProperty), element, value);
        }

        public static IconElement GetIcon(UIElement element)
        {
            return (IconElement)element.GetValue(DesignTime.IconProperty);
        }

        public static void SetSymbol(UIElement element, Symbol value)
        {
            element.SetValue(DesignTime.SymbolProperty, value);
            SetInDesigner(nameof(SymbolProperty), element, value);
        }

        public static Symbol GetSymbol(UIElement element)
        {
            return (Symbol)element.GetValue(DesignTime.SymbolProperty);
        }

        public static void SetTime(UIElement element, string value)
        {
            element.SetValue(DesignTime.TimeProperty, value);

            if (TimeSpan.TryParse(value, out TimeSpan parsed))
            {
                SetInDesigner(nameof(TimeProperty), element, parsed);
            }
        }

        public static string GetTime(UIElement element)
        {
            return (string)element.GetValue(DesignTime.TimeProperty);
        }

        public static void SetDate(UIElement element, string value)
        {
            element.SetValue(DesignTime.DateProperty, value);

            if (DateTimeOffset.TryParse(value, out DateTimeOffset parsed))
            {
                SetInDesigner(nameof(DateProperty), element, parsed);
            }
        }

        public static string GetDate(UIElement element)
        {
            return (string)element.GetValue(DesignTime.DateProperty);
        }

        public static void SetSource(UIElement element, ImageSource value)
        {
            element.SetValue(DesignTime.SourceProperty, value);
            SetInDesigner(nameof(SourceProperty), element, value);
        }

        public static ImageSource GetSource(UIElement element)
        {
            return (ImageSource)element.GetValue(DesignTime.SourceProperty);
        }

        public static void SetFlowDirection(UIElement element, FlowDirection value)
        {
            element.SetValue(DesignTime.FlowDirectionProperty, value);
            SetInDesigner(nameof(FlowDirectionProperty), element, value);
        }

        public static FlowDirection GetFlowDirection(UIElement element)
        {
            return (FlowDirection)element.GetValue(DesignTime.FlowDirectionProperty);
        }
    }
}
