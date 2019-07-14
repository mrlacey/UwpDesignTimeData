using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
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



        public static void SetText(UIElement element, string value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                switch (element)
                {
                    case TextBlock _:
                        element.SetValue(TextBlock.TextProperty, value);
                        break;
                    case TextBox _:
                        element.SetValue(TextBox.TextProperty, value);
                        break;
                    case ComboBox _:
                        element.SetValue(ComboBox.TextProperty, value);
                        break;
                }
            }
            else
            {
                element.SetValue(DesignTime.TextProperty, value);
            }
        }

        public static string GetText(UIElement element)
        {
            return (string)element.GetValue(DesignTime.TextProperty);
        }

        public static void SetDescription(UIElement element, object value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                switch (element)
                {
                    case TextBox _:
                        element.SetValue(TextBox.DescriptionProperty, value);
                        break;
                    case ComboBox _:
                        element.SetValue(ComboBox.DescriptionProperty, value);
                        break;
                    case PasswordBox _:
                        element.SetValue(PasswordBox.DescriptionProperty, value);
                        break;
                    case RichEditBox _:
                        element.SetValue(RichEditBox.DescriptionProperty, value);
                        break;
                }
            }
            else
            {
                element.SetValue(DesignTime.DescriptionProperty, value);
            }
        }

        public static object GetDescription(UIElement element)
        {
            return (object)element.GetValue(DesignTime.DescriptionProperty);
        }

        public static void SetHeader(UIElement element, object value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (ApiInformation.IsTypePresent("Windows.UI.Xaml.Controls.NavigationView"))
                {
                    if (element is NavigationView)
                    {
                        element.SetValue(NavigationView.HeaderProperty, value);
                    }
                }
                else
                {
                    switch (element)
                    {
                        case TextBox _:
                            element.SetValue(TextBox.HeaderProperty, value);
                            break;
                        case ComboBox _:
                            element.SetValue(ComboBox.HeaderProperty, value);
                            break;
                        case DatePicker _:
                            element.SetValue(DatePicker.HeaderProperty, value);
                            break;
                        case TimePicker _:
                            element.SetValue(TimePicker.HeaderProperty, value);
                            break;
                        case Hub _:
                            element.SetValue(Hub.HeaderProperty, value);
                            break;
                        case HubSection _:
                            element.SetValue(HubSection.HeaderProperty, value);
                            break;
                        case ListViewBase _:
                            element.SetValue(ListViewBase.HeaderProperty, value);
                            break;
                        case PasswordBox _:
                            element.SetValue(PasswordBox.HeaderProperty, value);
                            break;
                        case PivotItem _:
                            element.SetValue(PivotItem.HeaderProperty, value);
                            break;
                        case RichEditBox _:
                            element.SetValue(RichEditBox.HeaderProperty, value);
                            break;
                        case Slider _:
                            element.SetValue(Slider.HeaderProperty, value);
                            break;
                        case ToggleSwitch _:
                            element.SetValue(ToggleSwitch.HeaderProperty, value);
                            break;
                    }
                }
            }
            else
            {
                element.SetValue(DesignTime.HeaderProperty, value);
            }
        }

        public static object GetHeader(UIElement element)
        {
            return (object)element.GetValue(DesignTime.HeaderProperty);
        }

        public static void SetPlaceholderText(UIElement element, string value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                switch (element)
                {
                    case TextBox _:
                        element.SetValue(TextBox.PlaceholderTextProperty, value);
                        break;
                    case ComboBox _:
                        element.SetValue(ComboBox.PlaceholderTextProperty, value);
                        break;
                    case PasswordBox _:
                        element.SetValue(PasswordBox.PlaceholderTextProperty, value);
                        break;
                    case RichEditBox _:
                        element.SetValue(RichEditBox.PlaceholderTextProperty, value);
                        break;
                    case SearchBox _:
                        element.SetValue(SearchBox.PlaceholderTextProperty, value);
                        break;
                }
            }
            else
            {
                element.SetValue(DesignTime.PlaceholderTextProperty, value);
            }
        }

        public static string GetPlaceholderText(UIElement element)
        {
            return (string)element.GetValue(DesignTime.PlaceholderTextProperty);
        }

        public static void SetContent(UIElement element, object value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (element is ContentControl)
                {
                    element.SetValue(ContentControl.ContentProperty, value);
                }
            }
            else
            {
                element.SetValue(DesignTime.ContentProperty, value);
            }
        }

        public static object GetContent(UIElement element)
        {
            return (object)element.GetValue(DesignTime.ContentProperty);
        }

        public static void SetIsChecked(UIElement element, bool value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (element is ToggleButton)
                {
                    element.SetValue(ToggleButton.IsCheckedProperty, value);
                }
            }
            else
            {
                element.SetValue(DesignTime.IsCheckedProperty, value);
            }
        }

        public static bool GetIsChecked(UIElement element)
        {
            return (bool)element.GetValue(DesignTime.IsCheckedProperty);
        }

        public static void SetFooter(UIElement element, object value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (element is ListViewBase)
                {
                    element.SetValue(ListViewBase.FooterProperty, value);
                }
            }
            else
            {
                element.SetValue(DesignTime.FooterProperty, value);
            }
        }

        public static object GetFooter(UIElement element)
        {
            return (object)element.GetValue(DesignTime.FooterProperty);
        }

        public static void SetTitle(UIElement element, object value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (element is Pivot)
                {
                    element.SetValue(Pivot.TitleProperty, value);
                }
                else if (ApiInformation.IsTypePresent("Windows.UI.Xaml.Controls.MenuBarItem"))
                {
                    if (element is MenuBarItem)
                    {
                        element.SetValue(MenuBarItem.TitleProperty, value);
                    }
                }
            }
            else
            {
                element.SetValue(DesignTime.TitleProperty, value);
            }
        }

        public static object GetTitle(UIElement element)
        {
            return (object)element.GetValue(DesignTime.TitleProperty);
        }

        public static void SetPaneFooter(UIElement element, object value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (ApiInformation.IsTypePresent("Windows.UI.Xaml.Controls.NavigationView"))
                {
                    if (element is NavigationView)
                    {
                        element.SetValue(NavigationView.PaneFooterProperty, value);
                    }
                }
            }
            else
            {
                element.SetValue(DesignTime.PaneFooterProperty, value);
            }
        }

        public static object GetPaneFooter(UIElement element)
        {
            return (object)element.GetValue(DesignTime.PaneFooterProperty);
        }

        public static void SetPaneHeader(UIElement element, object value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (ApiInformation.IsTypePresent("Windows.UI.Xaml.Controls.NavigationView"))
                {
                    if (element is NavigationView)
                    {
                        element.SetValue(NavigationView.PaneHeaderProperty, value);
                    }
                }
            }
            else
            {
                element.SetValue(DesignTime.PaneHeaderProperty, value);
            }
        }

        public static object GetPaneHeader(UIElement element)
        {
            return (object)element.GetValue(DesignTime.PaneHeaderProperty);
        }

        public static void SetPaneTitle(UIElement element, object value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (ApiInformation.IsTypePresent("Windows.UI.Xaml.Controls.NavigationView"))
                {
                    if (element is NavigationView)
                    {
                        element.SetValue(NavigationView.PaneTitleProperty, value);
                    }
                }
            }
            else
            {
                element.SetValue(DesignTime.PaneTitleProperty, value);
            }
        }

        public static object GetPaneTitle(UIElement element)
        {
            return (object)element.GetValue(DesignTime.PaneTitleProperty);
        }

        public static void SetPassword(UIElement element, string value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (element is PasswordBox)
                {
                    element.SetValue(PasswordBox.PasswordProperty, value);
                }
            }
            else
            {
                element.SetValue(DesignTime.PasswordProperty, value);
            }
        }

        public static string GetPassword(UIElement element)
        {
            return (string)element.GetValue(DesignTime.PasswordProperty);
        }

        public static void SetPasswordChar(UIElement element, string value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (element is PasswordBox)
                {
                    element.SetValue(PasswordBox.PasswordCharProperty, value.Substring(0, 1));
                }
            }
            else
            {
                element.SetValue(DesignTime.PasswordCharProperty, value);
            }
        }

        public static string GetPasswordChar(UIElement element)
        {
            return (string)element.GetValue(DesignTime.PasswordCharProperty);
        }

        public static void SetValue(UIElement element, double value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (element is RangeBase)
                {
                    element.SetValue(RangeBase.ValueProperty, value);
                }
                else if (ApiInformation.IsTypePresent("Windows.UI.Xaml.Controls.RatingControl"))
                {
                    if (element is RatingControl)
                    {
                        element.SetValue(RatingControl.ValueProperty, value);
                    }
                }
            }
            else
            {
                element.SetValue(DesignTime.ValueProperty, value);
            }
        }

        public static double GetValue(UIElement element)
        {
            return (double)element.GetValue(DesignTime.ValueProperty);
        }

        public static void SetMinimum(UIElement element, double value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (element is RangeBase)
                {
                    element.SetValue(RangeBase.MinimumProperty, value);
                }
            }
            else
            {
                element.SetValue(DesignTime.MinimumProperty, value);
            }
        }

        public static double GetMinimum(UIElement element)
        {
            return (double)element.GetValue(DesignTime.MinimumProperty);
        }

        public static void SetMaximum(UIElement element, double value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (element is RangeBase)
                {
                    element.SetValue(RangeBase.MaximumProperty, value);
                }
            }
            else
            {
                element.SetValue(DesignTime.MaximumProperty, value);
            }
        }

        public static double GetMaximum(UIElement element)
        {
            return (double)element.GetValue(DesignTime.MaximumProperty);
        }

        public static void SetPlaceholderValue(UIElement element, double value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (ApiInformation.IsTypePresent("Windows.UI.Xaml.Controls.RatingControl"))
                {
                    if (element is RatingControl)
                    {
                        element.SetValue(RatingControl.PlaceholderValueProperty, value);
                    }
                }
            }
            else
            {
                element.SetValue(DesignTime.PlaceholderValueProperty, value);
            }
        }

        public static double GetPlaceholderValue(UIElement element)
        {
            return (double)element.GetValue(DesignTime.PlaceholderValueProperty);
        }

        public static void SetMaxRating(UIElement element, int value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (ApiInformation.IsTypePresent("Windows.UI.Xaml.Controls.RatingControl"))
                {
                    if (element is RatingControl)
                    {
                        element.SetValue(RatingControl.MaxRatingProperty, value);
                    }
                }
            }
            else
            {
                element.SetValue(DesignTime.MaxRatingProperty, value);
            }
        }

        public static int GetMaxRating(UIElement element)
        {
            return (int)element.GetValue(DesignTime.MaxRatingProperty);
        }

        public static void SetCaption(UIElement element, string value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (ApiInformation.IsTypePresent("Windows.UI.Xaml.Controls.RatingControl"))
                {
                    if (element is RatingControl)
                    {
                        element.SetValue(RatingControl.CaptionProperty, value);
                    }
                }
            }
            else
            {
                element.SetValue(DesignTime.CaptionProperty, value);
            }
        }

        public static string GetCaption(UIElement element)
        {
            return (string)element.GetValue(DesignTime.MaxRatingProperty);
        }

        public static void SetQueryText(UIElement element, string value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (element is SearchBox)
                {
                    element.SetValue(SearchBox.QueryTextProperty, value);
                }
            }
            else
            {
                element.SetValue(DesignTime.QueryTextProperty, value);
            }
        }

        public static string GetQueryText(UIElement element)
        {
            return (string)element.GetValue(DesignTime.QueryTextProperty);
        }

        public static void SetIsOn(UIElement element, bool value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (element is ToggleSwitch)
                {
                    element.SetValue(ToggleSwitch.IsOnProperty, value);
                }
            }
            else
            {
                element.SetValue(DesignTime.IsOnProperty, value);
            }
        }

        public static bool GetIsOn(UIElement element)
        {
            return (bool)element.GetValue(DesignTime.IsOnProperty);
        }

        public static void SetOnContent(UIElement element, object value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (element is ToggleSwitch)
                {
                    element.SetValue(ToggleSwitch.OnContentProperty, value);
                }
            }
            else
            {
                element.SetValue(DesignTime.OnContentProperty, value);
            }
        }

        public static object GetOnContent(UIElement element)
        {
            return (object)element.GetValue(DesignTime.OnContentProperty);
        }

        public static void SetOffContent(UIElement element, object value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (element is ToggleSwitch)
                {
                    element.SetValue(ToggleSwitch.OffContentProperty, value);
                }
            }
            else
            {
                element.SetValue(DesignTime.OffContentProperty, value);
            }
        }

        public static object GetOffContent(UIElement element)
        {
            return (object)element.GetValue(DesignTime.OffContentProperty);
        }

        public static void SetIcon(UIElement element, IconElement value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (ApiInformation.IsTypePresent("Windows.UI.Xaml.Controls.NavigationViewItem"))
                {
                    if (element is NavigationViewItem navviewitem)
                    {
                        if (navviewitem.Icon == null)
                        {
                            element.SetValue(NavigationViewItem.IconProperty, value);
                        }
                    }
                }
            }
            else
            {
                element.SetValue(DesignTime.IconProperty, value);
            }
        }

        public static IconElement GetIcon(UIElement element)
        {
            return (IconElement)element.GetValue(DesignTime.IconProperty);
        }

        public static void SetSymbol(UIElement element, Symbol value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (element is SymbolIcon)
                {
                    element.SetValue(SymbolIcon.SymbolProperty, value);
                }
            }
            else
            {
                element.SetValue(DesignTime.SymbolProperty, value);
            }
        }

        public static Symbol GetSymbol(UIElement element)
        {
            return (Symbol)element.GetValue(DesignTime.SymbolProperty);
        }

        public static void SetTime(UIElement element, string value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (element is TimePicker)
                {
                    if (TimeSpan.TryParse(value, out TimeSpan parsed))
                    {
                        element.SetValue(TimePicker.TimeProperty, parsed);
                    }
                }
            }
            else
            {
                element.SetValue(DesignTime.TimeProperty, value);
            }
        }

        public static string GetTime(UIElement element)
        {
            return (string)element.GetValue(DesignTime.TimeProperty);
        }

        public static void SetDate(UIElement element, string value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (element is DatePicker)
                {
                    if (DateTimeOffset.TryParse(value, out DateTimeOffset parsed))
                    {
                        element.SetValue(DatePicker.DateProperty, parsed);
                    }
                }
            }
            else
            {
                element.SetValue(DesignTime.DateProperty, value);
            }
        }

        public static string GetDate(UIElement element)
        {
            return (string)element.GetValue(DesignTime.DateProperty);
        }

        public static void SetSource(UIElement element, ImageSource value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (element is Image)
                {
                    element.SetValue(Image.SourceProperty, value);
                }
            }
            else
            {
                element.SetValue(DesignTime.SourceProperty, value);
            }
        }

        public static ImageSource GetSource(UIElement element)
        {
            return (ImageSource)element.GetValue(DesignTime.SourceProperty);
        }

        public static void SetFlowDirection(UIElement element, FlowDirection value)
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                if (element is FrameworkElement)
                {
                    element.SetValue(FrameworkElement.FlowDirectionProperty, value);
                }
            }
            else
            {
                element.SetValue(DesignTime.SourceProperty, value);
            }
        }

        public static FlowDirection GetFlowDirection(UIElement element)
        {
            return (FlowDirection)element.GetValue(DesignTime.FlowDirectionProperty);
        }

    }
}
