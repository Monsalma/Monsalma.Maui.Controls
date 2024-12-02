# Monsalma.Maui.Controls v1.0.6 Demo

Version 1.0.6 introduces <b>command (button) columns</b>. We'll be using free Monsalma `DataGrid` control to list all NBA teams (their names and logos) and select 3 favorite teams. 

To get started, please download Monsalma.Maui.Controls NuGet package:
[https://www.nuget.org/packages/Monsalma.Maui.Controls/1.0.6](https://www.nuget.org/packages/Monsalma.Maui.Controls/1.0.6).

Additional resources:
+ [Monsalma Controls for .NET MAUI](https://monsalma.net/monsalma-controls-for-net-maui/)
+ [Info on data grid columns](https://monsalma.net/monsalma-controls-for-net-maui/monsalma-data-grid-for-net-maui-columns/)
+ [Info on column width](https://monsalma.net/monsalma-controls-for-net-maui/monsalma-data-grid-for-net-maui-column-width/)

## Model (Data)

Instances of the `NBATeam` class (`Monsalma_Maui_v010006.Data.NBATeam`) contain the data. The class inherits from `INotifyPropertyChanged` because we need to notify changes of the `IsSelectedText` property in order to switch between "Select" and "Deselect" button text. 
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/502ffb13331ed5b67434d7b3265a486cda75d805/Monsalma-Maui-v010006/Monsalma-Maui-v010006/Data/NBATeam.cs#L6-L34](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/502ffb13331ed5b67434d7b3265a486cda75d805/Monsalma-Maui-v010006/Monsalma-Maui-v010006/Data/NBATeam.cs#L6-L34)

## View Model

`MainViewModel` (`Monsalma_Maui_v010006.ViewModels.MainViewModel`) creates a collection (`ObservableCollection`) of NBA teams. 

### Relevant properties - Collection of teams (`NBATeams`) and collection of selected teams (`SelectedTeams`)
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/502ffb13331ed5b67434d7b3265a486cda75d805/Monsalma-Maui-v010006/Monsalma-Maui-v010006/ViewModels/MainViewModel.cs#L46-L58](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/502ffb13331ed5b67434d7b3265a486cda75d805/Monsalma-Maui-v010006/Monsalma-Maui-v010006/ViewModels/MainViewModel.cs#L46-L58)

### Command initialization
The view model initiates the command, which we'll use later in XAML. It's important to know that, by default, `DataGrid` sets command parameter (the `commandParameter` parameter) to a corresponding item from the item list which feeds the grid (`Items` bindable property). 
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/502ffb13331ed5b67434d7b3265a486cda75d805/Monsalma-Maui-v010006/Monsalma-Maui-v010006/ViewModels/MainViewModel.cs#L65-L86](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/502ffb13331ed5b67434d7b3265a486cda75d805/Monsalma-Maui-v010006/Monsalma-Maui-v010006/ViewModels/MainViewModel.cs#L65-L86)

## View (XAML)

`MainPage` (`Monsalma_Maui_v010006.MainPage`) represents the view.

First we import the package ([`Monsalma.Maui.Controls`](https://www.nuget.org/packages/Monsalma.Maui.Controls/1.0.6)) and local namespaces (data and view model):
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30a200543a11d17eca0b68a3c21d3f9e6c43b39d/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L5-L7](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30a200543a11d17eca0b68a3c21d3f9e6c43b39d/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L5-L7)

Similar to previous demos, then we define row styles (header row, odd row, even row and selected row) for the data grid control:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30a200543a11d17eca0b68a3c21d3f9e6c43b39d/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L17-L54](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30a200543a11d17eca0b68a3c21d3f9e6c43b39d/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L17-L54)

In this demo we also need to define the button style, to be used when defining `DataGridColumnCommand`:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30a200543a11d17eca0b68a3c21d3f9e6c43b39d/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L56-L76](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30a200543a11d17eca0b68a3c21d3f9e6c43b39d/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L56-L76)

Next, we define the data template for our templated column (`DataGridColumnTemplated`):
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30a200543a11d17eca0b68a3c21d3f9e6c43b39d/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L78-L100](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30a200543a11d17eca0b68a3c21d3f9e6c43b39d/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L78-L100)

We'll use `ListView` to display selected teams. The item template is pretty straighforward:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30a200543a11d17eca0b68a3c21d3f9e6c43b39d/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L119-L131](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30a200543a11d17eca0b68a3c21d3f9e6c43b39d/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L119-L131)

Finally, we defin the data grid:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30a200543a11d17eca0b68a3c21d3f9e6c43b39d/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L137-L164](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30a200543a11d17eca0b68a3c21d3f9e6c43b39d/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L137-L164)

Here everything should be easy to understand. If not, please refer to previous demos:
[Version 1.0.3 Demo](https://github.com/Monsalma/Monsalma.Maui.Controls/tree/main/Monsalma-Maui-v010003)
[Version 1.0.2 Demo](https://github.com/Monsalma/Monsalma.Maui.Controls/tree/main/Monsalma-Maui-v010002)
[Version 1.0.1 Demo](https://github.com/Monsalma/Monsalma.Maui.Controls/tree/main/Monsalma-Maui-v010001)
[Version 1.0.0 Demo](https://github.com/Monsalma/Monsalma.Maui.Controls/tree/main/Monsalma-Maui-v010000)

It is important to understand how `DataGridColumnCommand` is defined. We use the `DataBinding` bindable property because we want to have different values for different items ("Select" for items which are not selected, "Deselect" for selected items). If we wanted to have only one button text value, we would use the `CommandText` bindable property.
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/502ffb13331ed5b67434d7b3265a486cda75d805/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L155-L160](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/502ffb13331ed5b67434d7b3265a486cda75d805/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L155-L160)

## Screenshots

### Windows

![Monsalma Data Grid for .NET MAUI - Demo - Command (button) column - Windows](/Images/v010006_DataGrid_NBATeams_Windows.gif)

### Android Emulator (Google Pixel 3 XL - API 30)

![Monsalma Data Grid for .NET MAUI - Demo - Command (button) column - Android](/Images/v010006_DataGrid_NBATeams_Android.gif)
