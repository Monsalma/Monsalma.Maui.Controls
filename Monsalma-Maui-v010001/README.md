# Monsalma.Maui.Controls v1.0.1 Demo

This one is for all soccer fans out there. We'll be using Monsalma `DataGrid` control to display all World Cup winners (and Golden Ball winners). Warning - templated columns (added in version 1.0.1)!

To get started, please download Monsalma.Maui.Controls NuGet package:
[https://www.nuget.org/packages/Monsalma.Maui.Controls/1.0.1-beta](https://www.nuget.org/packages/Monsalma.Maui.Controls/1.0.1-beta).

Additional resources:
+ [Monsalma Controls for .NET MAUI](https://monsalma.net/monsalma-controls-for-net-maui/)
+ [Info on data grid columns](https://monsalma.net/monsalma-controls-for-net-maui/monsalma-data-grid-for-net-maui-columns/)
+ [Info on column width](https://monsalma.net/monsalma-controls-for-net-maui/monsalma-data-grid-for-net-maui-column-width/)

## Model (Data)

Instances of the `WorldCupWinner` class (`Monsalma_Maui_v010001.Data.WorldCupWinner`) contain the data:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/926f5e3fbf35d32f83fcea6104d27e13cc63efa0/Monsalma-Maui-v010001/Monsalma-Maui-v010001/Data/WorldCupWinner.cs#L3-L9](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/926f5e3fbf35d32f83fcea6104d27e13cc63efa0/Monsalma-Maui-v010001/Monsalma-Maui-v010001/Data/WorldCupWinner.cs#L3-L9)

## View Model

`MainViewModel` (`Monsalma_Maui_v010001.ViewModels.MainViewModel`) creates a list of all world cup winners:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/926f5e3fbf35d32f83fcea6104d27e13cc63efa0/Monsalma-Maui-v010001/Monsalma-Maui-v010001/ViewModels/MainViewModel.cs#L30-L44](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/926f5e3fbf35d32f83fcea6104d27e13cc63efa0/Monsalma-Maui-v010001/Monsalma-Maui-v010001/ViewModels/MainViewModel.cs#L30-L44)

## View (XAML)

`MainPage` (`Monsalma_Maui_v010001.MainPage`) is the only page used in this demo.

### Imports

First we import the package ([`Monsalma.Maui.Controls`](https://www.nuget.org/packages/Monsalma.Maui.Controls/1.0.1-beta)) and local namespaces (data, template selectors and view model):
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/926f5e3fbf35d32f83fcea6104d27e13cc63efa0/Monsalma-Maui-v010001/Monsalma-Maui-v010001/MainPage.xaml#L5-L8](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/926f5e3fbf35d32f83fcea6104d27e13cc63efa0/Monsalma-Maui-v010001/Monsalma-Maui-v010001/MainPage.xaml#L5-L8)

### Row Styles

Then we define row styles (header row, odd row, even row and selected row) for the data grid control:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/926f5e3fbf35d32f83fcea6104d27e13cc63efa0/Monsalma-Maui-v010001/Monsalma-Maui-v010001/MainPage.xaml#L17-L67](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/926f5e3fbf35d32f83fcea6104d27e13cc63efa0/Monsalma-Maui-v010001/Monsalma-Maui-v010001/MainPage.xaml#L17-L67)

### Data Templates

We define data templates and data template selector, to be used later on. 20<sup>th</sup> century winners template is slightly different than the 21<sup>st</sup> century template. This is just to illustrate the power of templates.
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/926f5e3fbf35d32f83fcea6104d27e13cc63efa0/Monsalma-Maui-v010001/Monsalma-Maui-v010001/MainPage.xaml#L69-L120](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/926f5e3fbf35d32f83fcea6104d27e13cc63efa0/Monsalma-Maui-v010001/Monsalma-Maui-v010001/MainPage.xaml#L69-L120)

### Data Grid Definition

`DataGrid` definition should be pretty straightforward. It it's not, please refer to the previous demo ([Monsalma-Maui-v010000](/Monsalma-Maui-v010000#view-xaml)).
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30042892bff50ea44b8dbd8d873f9d05e9566a6b/Monsalma-Maui-v010001/Monsalma-Maui-v010001/MainPage.xaml#L132-L141](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30042892bff50ea44b8dbd8d873f9d05e9566a6b/Monsalma-Maui-v010001/Monsalma-Maui-v010001/MainPage.xaml#L132-L141)

### Column Definition

Next, it's time to define our columns. For `Year` and `GoldenBallWinner` we'll use a simple text column (`DataGridColumnText`). Nothing new there. For `Country` we'll use a templated column (`DataGridColumnTemplated`):
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30042892bff50ea44b8dbd8d873f9d05e9566a6b/Monsalma-Maui-v010001/Monsalma-Maui-v010001/MainPage.xaml#L143-L174](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30042892bff50ea44b8dbd8d873f9d05e9566a6b/Monsalma-Maui-v010001/Monsalma-Maui-v010001/MainPage.xaml#L143-L174)

### Conclusion

The important thing to learn from this demo is how to use data templates, data template selector and templated column. This is the single line of code that brings all 3 concepts together:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30042892bff50ea44b8dbd8d873f9d05e9566a6b/Monsalma-Maui-v010001/Monsalma-Maui-v010001/MainPage.xaml#L162](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30042892bff50ea44b8dbd8d873f9d05e9566a6b/Monsalma-Maui-v010001/Monsalma-Maui-v010001/MainPage.xaml#L162)

## Data Template Selector

`DataTemplateSelector` class is selecting `Century20Template` or `Century2021Template` based on the year (`Year` property):
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30042892bff50ea44b8dbd8d873f9d05e9566a6b/Monsalma-Maui-v010001/Monsalma-Maui-v010001/DataTemplateSelectors/WorldCupWinnerDataTemplateSelector.cs#L5-L14](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30042892bff50ea44b8dbd8d873f9d05e9566a6b/Monsalma-Maui-v010001/Monsalma-Maui-v010001/DataTemplateSelectors/WorldCupWinnerDataTemplateSelector.cs#L5-L14)

## Screenshots

### Windows

![Monsalma Data Grid for .NET MAUI - Demo - Templated Columns - World Cup Winners - Windows](/Images/v010001_DataGrid_WorldCupWinners_Windows.png)

### Android

![Monsalma Data Grid for .NET MAUI - Demo - Templated Columns - World Cup Winners - Android](/Images/v010001_DataGrid_WorldCupWinners_Android.png)
