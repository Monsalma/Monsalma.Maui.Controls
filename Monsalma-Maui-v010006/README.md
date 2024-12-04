# Monsalma.Maui.Controls v1.0.6 Demo

Version 1.0.6 introduces a new column type for Monsalma data grid control - <b>the command (button) column</b>. We'll be using the free `DataGrid` control for .NET MAUI to list all NBA teams (their names and logos) and select 3 favorite teams. 

To get started, please download Monsalma.Maui.Controls NuGet package. The package includes free data grid for .NET MAUI: <br/>
[https://www.nuget.org/packages/Monsalma.Maui.Controls/1.0.6](https://www.nuget.org/packages/Monsalma.Maui.Controls/1.0.6).

Additional resources:
+ [Monsalma Controls for .NET MAUI](https://monsalma.net/monsalma-controls-for-net-maui/)
+ [Info on data grid columns](https://monsalma.net/monsalma-controls-for-net-maui/monsalma-data-grid-for-net-maui-columns/)
+ [Info on column width](https://monsalma.net/monsalma-controls-for-net-maui/monsalma-data-grid-for-net-maui-column-width/)

## Model (Data)

Instances of the `NBATeam` class (`Monsalma_Maui_v010006.Data.NBATeam`) contain the data. The class inherits from [`INotifyPropertyChanged`](https://learn.microsoft.com/en-us/dotnet/maui/xaml/fundamentals/mvvm?view=net-maui-9.0) because we need to notify changes of the `IsSelectedText` property in order to switch between "Select" and "Deselect" button text. 
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/502ffb13331ed5b67434d7b3265a486cda75d805/Monsalma-Maui-v010006/Monsalma-Maui-v010006/Data/NBATeam.cs#L6-L34](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/502ffb13331ed5b67434d7b3265a486cda75d805/Monsalma-Maui-v010006/Monsalma-Maui-v010006/Data/NBATeam.cs#L6-L34)

## [View Model](https://learn.microsoft.com/en-us/dotnet/architecture/maui/mvvm)

`MainViewModel` (`Monsalma_Maui_v010006.ViewModels.MainViewModel`) creates a collection (`ObservableCollection`) of NBA teams. 

### Relevant properties - Collection of teams (`NBATeams`) and collection of selected teams (`SelectedTeams`)
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/502ffb13331ed5b67434d7b3265a486cda75d805/Monsalma-Maui-v010006/Monsalma-Maui-v010006/ViewModels/MainViewModel.cs#L46-L58](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/502ffb13331ed5b67434d7b3265a486cda75d805/Monsalma-Maui-v010006/Monsalma-Maui-v010006/ViewModels/MainViewModel.cs#L46-L58)

### [Command](https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/data-binding/commanding?view=net-maui-9.0) initialization
The view model initiates the command, which we'll use later in [XAML](https://learn.microsoft.com/en-us/dotnet/maui/xaml/?view=net-maui-9.0). It's important to know that, by default, `DataGrid` sets command parameter (`commandParameter`) to a corresponding item from the item list which feeds the grid (`Items` bindable property). This default behavior can be overriden by using the `CommandParameter` bindable property of the `DataGridColumnCommand` class.
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/502ffb13331ed5b67434d7b3265a486cda75d805/Monsalma-Maui-v010006/Monsalma-Maui-v010006/ViewModels/MainViewModel.cs#L65-L86](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/502ffb13331ed5b67434d7b3265a486cda75d805/Monsalma-Maui-v010006/Monsalma-Maui-v010006/ViewModels/MainViewModel.cs#L65-L86)

## View ([XAML](https://learn.microsoft.com/en-us/dotnet/maui/xaml/?view=net-maui-9.0))

`MainPage` (`Monsalma_Maui_v010006.MainPage`) represents the view.

### Importing packages and local namespaces
First we import the package ([`Monsalma.Maui.Controls`](https://www.nuget.org/packages/Monsalma.Maui.Controls/1.0.6)) and local namespaces (data and view model):
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30a200543a11d17eca0b68a3c21d3f9e6c43b39d/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L5-L7](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30a200543a11d17eca0b68a3c21d3f9e6c43b39d/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L5-L7)

### Row styles
Similar to previous demos, then we define row styles (odd row, even row and selected row) for the data grid control:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30a200543a11d17eca0b68a3c21d3f9e6c43b39d/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L17-L54](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30a200543a11d17eca0b68a3c21d3f9e6c43b39d/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L17-L54)

### Command (button) column style
In this demo we also need to define the button style, to be used when defining `DataGridColumnCommand`:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/ab3e1a1196090a0ab00d426591ef219de1ecbac0/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L56-L76](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/ab3e1a1196090a0ab00d426591ef219de1ecbac0/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L56-L76)

### [Data template](https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/datatemplate?view=net-maui-9.0)
Next, we define the data template for our templated column (`DataGridColumnTemplated`) which will contain team logo ([`Image`](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/image?view=net-maui-9.0)) and team name ([`Label`](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/label?view=net-maui-9.0)):
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30a200543a11d17eca0b68a3c21d3f9e6c43b39d/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L78-L100](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30a200543a11d17eca0b68a3c21d3f9e6c43b39d/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L78-L100)

### Selected NBA teams collection (ListView / ObservableCollection)
We'll use [`ListView`](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/listview?view=net-maui-9.0) to display selected teams. The [item template](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/listview?view=net-maui-9.0#define-item-appearance) is pretty straighforward:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30a200543a11d17eca0b68a3c21d3f9e6c43b39d/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L119-L131](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30a200543a11d17eca0b68a3c21d3f9e6c43b39d/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L119-L131)

### All NBA teams collection (Monsalma Data Grid for .NET MAUI / ObservableCollection)
Finally, we define the [data grid](https://monsalma.net/monsalma-controls-for-net-maui/):
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30a200543a11d17eca0b68a3c21d3f9e6c43b39d/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L137-L164](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/30a200543a11d17eca0b68a3c21d3f9e6c43b39d/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L137-L164)

Here everything should be easy to understand. If not, please refer to previous demos: <br/>
- [Version 1.0.3 Demo](https://github.com/Monsalma/Monsalma.Maui.Controls/tree/main/Monsalma-Maui-v010003)
- [Version 1.0.2 Demo](https://github.com/Monsalma/Monsalma.Maui.Controls/tree/main/Monsalma-Maui-v010002)
- [Version 1.0.1 Demo](https://github.com/Monsalma/Monsalma.Maui.Controls/tree/main/Monsalma-Maui-v010001)
- [Version 1.0.0 Demo](https://github.com/Monsalma/Monsalma.Maui.Controls/tree/main/Monsalma-Maui-v010000)

It is important to understand how `DataGridColumnCommand` is defined. We use the `DataBinding` bindable property because we want to have different values for different items ("Select" for items which are not selected, "Deselect" for selected items). If we wanted to have only one button text value, we would use the `CommandText` bindable property.
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/502ffb13331ed5b67434d7b3265a486cda75d805/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L155-L160](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/502ffb13331ed5b67434d7b3265a486cda75d805/Monsalma-Maui-v010006/Monsalma-Maui-v010006/MainPage.xaml#L155-L160)

## Screen capture GIFs

### Windows

![Monsalma Data Grid for .NET MAUI - Demo - Command (button) column - Windows](/Images/v010006_DataGrid_NBATeams_Windows.gif)

### Android Emulator (Google Pixel 3 XL - API 30)

![Monsalma Data Grid for .NET MAUI - Demo - Command (button) column - Android](/Images/v010006_DataGrid_NBATeams_Android.gif)
