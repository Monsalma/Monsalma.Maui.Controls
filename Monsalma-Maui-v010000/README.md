# Monsalma.Maui.Controls v1.0.0 Demo

NBA fan? This demo uses Monsalma DataGrid control to display all NBA MVPs.  

To get started, please download Monsalma.Maui.Controls NuGet package:
[https://www.nuget.org/packages/Monsalma.Maui.Controls/1.0.0](https://www.nuget.org/packages/Monsalma.Maui.Controls/1.0.0).

Additional resources:
+ [Monsalma Controls for .NET MAUI](https://monsalma.net/monsalma-controls-for-net-maui/)
+ [Info on data grid columns](https://monsalma.net/monsalma-controls-for-net-maui/monsalma-data-grid-for-net-maui-columns/)
+ [Info on column width](https://monsalma.net/monsalma-controls-for-net-maui/monsalma-data-grid-for-net-maui-column-width/)

## Model (Data)

Instances of the `Person` class (`Monsalma_Maui_v010000.Data.Person`) contain the data:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/2386b71f801007c0fa7952ad8452853626822cb8/Monsalma-Maui-v010000/Monsalma-Maui-v010000/Data/Person.cs#L3-L8](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/2386b71f801007c0fa7952ad8452853626822cb8/Monsalma-Maui-v010000/Monsalma-Maui-v010000/Data/Person.cs#L3-L8)

## View Model

`MainViewModel` (`Monsalma_Maui_v010000.ViewModels.MainViewModel`) randomly selects 100 NBA legends:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/2386b71f801007c0fa7952ad8452853626822cb8/Monsalma-Maui-v010000/Monsalma-Maui-v010000/ViewModels/MainViewModel.cs#L107-L126](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/2386b71f801007c0fa7952ad8452853626822cb8/Monsalma-Maui-v010000/Monsalma-Maui-v010000/ViewModels/MainViewModel.cs#L107-L126)

## View (XAML)

`MainPage` (`Monsalma_Maui_v010000.MainPage`) is what we're interested in.

First we import the package ([`Monsalma.Maui.Controls`](https://www.nuget.org/packages/Monsalma.Maui.Controls/1.0.0)) and view model:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/2386b71f801007c0fa7952ad8452853626822cb8/Monsalma-Maui-v010000/Monsalma-Maui-v010000/MainPage.xaml#L5-L6](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/2386b71f801007c0fa7952ad8452853626822cb8/Monsalma-Maui-v010000/Monsalma-Maui-v010000/MainPage.xaml#L5-L6)

Then we define row styles (header row, odd row, even row and selected row) for the data grid control:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/2386b71f801007c0fa7952ad8452853626822cb8/Monsalma-Maui-v010000/Monsalma-Maui-v010000/MainPage.xaml#L14-L66](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/2386b71f801007c0fa7952ad8452853626822cb8/Monsalma-Maui-v010000/Monsalma-Maui-v010000/MainPage.xaml#L14-L66)

After that, we add the data grid markup:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/2386b71f801007c0fa7952ad8452853626822cb8/Monsalma-Maui-v010000/Monsalma-Maui-v010000/MainPage.xaml#L76-L84](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/2386b71f801007c0fa7952ad8452853626822cb8/Monsalma-Maui-v010000/Monsalma-Maui-v010000/MainPage.xaml#L76-L84)

Lastly, we add the columns. For this demo, we're using only the simplest column type (`DataGridColumnText `), which under the hub contains a `Label` instance:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/2386b71f801007c0fa7952ad8452853626822cb8/Monsalma-Maui-v010000/Monsalma-Maui-v010000/MainPage.xaml#L86-L107](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/2386b71f801007c0fa7952ad8452853626822cb8/Monsalma-Maui-v010000/Monsalma-Maui-v010000/MainPage.xaml#L86-L107)

Things to note at this point:
+ Column width is defined using `Width`, `MinWidth` and `MaxWidth` bindable properties.<br />
For example, `Row` column will take as much space as it needs (`Width="Auto"`), but it will take at least 100 DIU (`MinWidth="100"`) and will not take more than 200 DIU (`MaxWidth="200"`).<br />
More info at: [https://monsalma.net/monsalma-controls-for-net-maui/monsalma-data-grid-for-net-maui-column-width/](https://monsalma.net/monsalma-controls-for-net-maui/monsalma-data-grid-for-net-maui-column-width/).
+ `Items` object acts as a data source for the grid (`Items="{Binding Persons}"`). To specify the column data source, we use `DataBinding` bindable property (`DataBinding="FirstName"`).
+ We specify column header text with `HeaderText` (`HeaderText="First Name"`).
