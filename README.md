# UWP Design-Time Data

Allow UWP projects to use inline design-time data.

[![NuGet](https://img.shields.io/nuget/v/UwpDesignTimeData.svg)](https://www.nuget.org/packages/UwpDesignTimeData/1.1.0)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
![Works with Visual Studio 2017](https://img.shields.io/static/v1.svg?label=VS&message=2017&color=5F2E96)
![Works with Visual Studio 2019](https://img.shields.io/static/v1.svg?label=VS&message=2019&color=BB88F3)

If using localization or bindings in your XAML you can end up with a page that looks empty in the designer.

![Designer with no useful, visible data](./assets/design-time-before.png)

This makes it hard to know what the UI will look like without running the app.
This library provides a way to add data that shows up in the designer without impacting the behavior of the app at run-time.

![Designer showing content at design-time](./assets/design-time-after.png)

Do this:

1. `Install-Package UwpDesignTimeData`
2. Then, do things like this in your XAML: `dt:DesignTime.Text="Only shown in designer."`

Then you can see behavior like this:

![Design time data in bindings shown in VS](./assets/design-time-binding.png)

The `Text` property will show the value from the binding at run-time while showing the design-time data in the designer, so you can have a visual idea of how it will look.

## Support for the following properties

You can use this library with any of the following `DesignTime` properties.

- Caption
- Content
- Date
- Description
- FlowDirection
- Footer
- Header
- Icon
- IsChecked
- IsOn
- Maximum
- MaxRating
- Minimum
- OffContent
- OnContent
- PaneFooter
- PaneHeader
- PaneTitle
- Password
- PasswordChar
- PlaceholderText
- PlaceholderValue
- QueryText
- Source
- Symbol
- Text
- Time
- Title
- Value

If the underlying element has the property the design-time content will be used in the designer. If it doens't have that property, the design-time value will be ignored.

## Improving the design-time experience

There are some things you can't visualize in the designer. But these can be seen with this library.

This includes specifying `Date` for the `DatePicker` and `Time` for the `TimePicker`.

![DatePicker and TimePicker showing values in the designer](./assets/design-time-dateandtime.png)

## Other design-time data solutions

It's possible to specify a design-time **DataContext** to use and populate the designer. No guarantees are made for using such a solution in combination with this library. Your experience may vary depending on exactly what you're doing.

## Avoid impact at run-time

Ignore the XML namespace alias ('dt' in the example below) to avoid the design-time data being parsed at runtime.

```diff
    xmlns:dt="using:UwpDesignTimeData"

-   mc:Ignorable="d"
+   mc:Ignorable="d dt"
```

Even if you don't do this, the way the code is implemented means that it won't try and overwrite values, at run-time, the way it does in the designer.

The performance impact of including this library is tiny and should not be noticable. Please feel free to raise an issue if you have a way of reproducing a measurable impact at run-time.

## Why doesn't Visual Studio do this already?

Xamarin.Forms already [has this capability](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/xaml/xaml-previewer/design-time-data). Consider this a poly-fill until this functionality is provided by Visual Studio for all XAML dialects. Hopefully this will be soon. :crossed_fingers:

The hope is that when official support is added, you'll be able to update your code to use it by removing the NuGet reference and replacing '`dt:DesignTime.`' with '`d:`'.

## Important to know

Before you start using this, you should probably know the following:

- You may need to rebuild the app to force the designer to update and show the [changes to] design-time data.
- If you specify a property and the design-time version, specify the design-time version second or it may not show in the designer.
- If you have any questions or suggestions for a new property to support at design-time, please [raise an issue](https://github.com/mrlacey/UwpDesignTimeData/issues/new).
