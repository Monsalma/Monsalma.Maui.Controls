# Monsalma.Maui.Controls v1.0.2 Demo

Similar to the previous demo, this one is for all soccer fans out there. We'll be using Monsalma `DataGrid` control to display all World Cup winners (and Golden Ball winners). 

To get started, please download Monsalma.Maui.Controls NuGet package:
[https://www.nuget.org/packages/Monsalma.Maui.Controls/1.0.2](https://www.nuget.org/packages/Monsalma.Maui.Controls/1.0.2).

Additional resources:
+ [Monsalma Controls for .NET MAUI](https://monsalma.net/monsalma-controls-for-net-maui/)
+ [Info on data grid columns](https://monsalma.net/monsalma-controls-for-net-maui/monsalma-data-grid-for-net-maui-columns/)
+ [Info on column width](https://monsalma.net/monsalma-controls-for-net-maui/monsalma-data-grid-for-net-maui-column-width/)

## Model (Data)

Instances of the `WorldCupWinner` class (`Monsalma_Maui_v010002.Data.WorldCupWinner`) contain the data:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0d4940d006ac691373a521f94544783eb9739741/Monsalma-Maui-v010002/Monsalma-Maui-v010002/Data/WorldCupWinner.cs#L3-L11](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0d4940d006ac691373a521f94544783eb9739741/Monsalma-Maui-v010002/Monsalma-Maui-v010002/Data/WorldCupWinner.cs#L3-L11)

## View Model

`MainViewModel` (`Monsalma_Maui_v010002.ViewModels.MainViewModel`) creates a list of all world cup winners:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0d4940d006ac691373a521f94544783eb9739741/Monsalma-Maui-v010002/Monsalma-Maui-v010002/ViewModels/MainViewModel.cs#L30-L44](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0d4940d006ac691373a521f94544783eb9739741/Monsalma-Maui-v010002/Monsalma-Maui-v010002/ViewModels/MainViewModel.cs#L30-L44)

## View (XAML)

`MainPage` (`Monsalma_Maui_v010002.MainPage`) is the only page used in this demo.

### Imports

First we import the package ([`Monsalma.Maui.Controls`](https://www.nuget.org/packages/Monsalma.Maui.Controls/1.0.2)) and local namespaces (data, template selectors and view model):
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0d4940d006ac691373a521f94544783eb9739741/Monsalma-Maui-v010002/Monsalma-Maui-v010002/MainPage.xaml#L5-L8](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0d4940d006ac691373a521f94544783eb9739741/Monsalma-Maui-v010002/Monsalma-Maui-v010002/MainPage.xaml#L5-L8)

### Row Styles

Then we define row styles (header row, odd row, even row and selected row) for the data grid control:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0d4940d006ac691373a521f94544783eb9739741/Monsalma-Maui-v010002/Monsalma-Maui-v010002/MainPage.xaml#L17-L67](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0d4940d006ac691373a521f94544783eb9739741/Monsalma-Maui-v010002/Monsalma-Maui-v010002/MainPage.xaml#L17-L67)

### Data Templates

We define data templates and data template selector, to be used later on. 20<sup>th</sup> century winners template is slightly different than the 21<sup>st</sup> century template. This is just to illustrate the power of templates.
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0d4940d006ac691373a521f94544783eb9739741/Monsalma-Maui-v010002/Monsalma-Maui-v010002/MainPage.xaml#L69-L120](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0d4940d006ac691373a521f94544783eb9739741/Monsalma-Maui-v010002/Monsalma-Maui-v010002/MainPage.xaml#L69-L120)

In addition to data templates and data template selector defined above, which were used in [the previous demo](/Monsalma-Maui-v010001#view-xaml) as well as in this one, in this version we introduce the edit template (to be used later on, when defining columns):
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0d4940d006ac691373a521f94544783eb9739741/Monsalma-Maui-v010002/Monsalma-Maui-v010002/MainPage.xaml#L122-L129](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0d4940d006ac691373a521f94544783eb9739741/Monsalma-Maui-v010002/Monsalma-Maui-v010002/MainPage.xaml#L122-L129)

### Data Grid Definition

`DataGrid` definition should be pretty straightforward. It it's not, please refer to the previous demo ([Monsalma-Maui-v010001](/Monsalma-Maui-v010001#view-xaml)).
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0d4940d006ac691373a521f94544783eb9739741/Monsalma-Maui-v010002/Monsalma-Maui-v010002/MainPage.xaml#L143-L152](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0d4940d006ac691373a521f94544783eb9739741/Monsalma-Maui-v010002/Monsalma-Maui-v010002/MainPage.xaml#L143-L152)

### Column Definition

Next, it's time to define our columns. `Year` and `GoldenBallWinner` columns are pretty much the same as in [the previous demo](/Monsalma-Maui-v010001#view-xaml). Now I'd like to highlight the usage of `CellIsReadOnlyBinding`, `CellTemplate` and `CellEditTemplate`:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0d4940d006ac691373a521f94544783eb9739741/Monsalma-Maui-v010002/Monsalma-Maui-v010002/MainPage.xaml#L165-L176](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0d4940d006ac691373a521f94544783eb9739741/Monsalma-Maui-v010002/Monsalma-Maui-v010002/MainPage.xaml#L165-L176)

`CellIsReadOnlyBinding` binds to the `IsCountryReadOnly` property of the [`WorldCupWinner`](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0d4940d006ac691373a521f94544783eb9739741/Monsalma-Maui-v010002/Monsalma-Maui-v010002/Data/WorldCupWinner.cs#L10) class. If the bound value returns `true`, then the data template defined by `CellTemplate` is used. Otherwise, `CellEditTemplate` determines which data template to use.

## Data Template Selector

`DataTemplateSelector` class is selecting `Century20Template` or `Century2021Template` based on the year (`Year` property):
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0d4940d006ac691373a521f94544783eb9739741/Monsalma-Maui-v010002/Monsalma-Maui-v010002/DataTemplateSelectors/WorldCupWinnerDataTemplateSelector.cs#L5-L14](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0d4940d006ac691373a521f94544783eb9739741/Monsalma-Maui-v010002/Monsalma-Maui-v010002/DataTemplateSelectors/WorldCupWinnerDataTemplateSelector.cs#L5-L14)

## Screenshots

### Windows - `CellTemplate` used (`CellIsReadOnlyBinding` is `true`)

![Monsalma Data Grid for .NET MAUI - Demo - Templated Columns - World Cup Winners - Windows](/Images/v010002_DataGrid_WorldCupWinners_Windows.png)

### Android - `CellTemplate` used (`CellIsReadOnlyBinding` is `true`)

![Monsalma Data Grid for .NET MAUI - Demo - Templated Columns - World Cup Winners - Android - CellTemplate](/Images/v010002_DataGrid_WorldCupWinners_Android_CellTemplate.png)

### Android - `CellEditTemplate` used (`CellIsReadOnlyBinding` is `false`)

![Monsalma Data Grid for .NET MAUI - Demo - Templated Columns - World Cup Winners - Android - CellEditTemplate](/Images/v010002_DataGrid_WorldCupWinners_Android_CellEditTemplate.png)
