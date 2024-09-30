# Monsalma.Maui.Controls v1.0.3 Demo

Version 1.0.3 supports <b>UI virtualization</b>! We'll be using free Monsalma `DataGrid` control to display some dummy data. The goal of this demo is to showcase the benefits of UI virtualization. To know more about how things work under the hub, please read this post - [Data Grid for .NET MAUI - Version 1.0.3 Released](https://monsalma.net/data-grid-for-net-maui-version-1-0-3-released-supporting-ui-virtualization/).

To get started, please download Monsalma.Maui.Controls NuGet package:
[https://www.nuget.org/packages/Monsalma.Maui.Controls/1.0.3](https://www.nuget.org/packages/Monsalma.Maui.Controls/1.0.3).

Additional resources:
+ [Monsalma Controls for .NET MAUI](https://monsalma.net/monsalma-controls-for-net-maui/)
+ [Info on data grid columns](https://monsalma.net/monsalma-controls-for-net-maui/monsalma-data-grid-for-net-maui-columns/)
+ [Info on column width](https://monsalma.net/monsalma-controls-for-net-maui/monsalma-data-grid-for-net-maui-column-width/)

## Model (Data)

Instances of the `VirtualizationDemoData` class (`Monsalma_Maui_v010003.Data.VirtualizationDemoData`) contain the data:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0cc0d5e35290a96e0c5c1c3bfca4fddfad40ebb9/Monsalma-Maui-v010003/Monsalma-Maui-v010003/Data/VirtualizationDemoData.cs#L3-L8](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0cc0d5e35290a96e0c5c1c3bfca4fddfad40ebb9/Monsalma-Maui-v010003/Monsalma-Maui-v010003/Data/VirtualizationDemoData.cs#L3-L8)

## View Model

`MainViewModel` (`Monsalma_Maui_v010003.ViewModels.MainViewModel`) creates a list of dummy data (10000 items). The goal is to generate column content of random length, so we get rows with variable heights. Rows with variable heights are a challenge and I want to showcase that `DataGrid` successfully overcomes the challenge.
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0cc0d5e35290a96e0c5c1c3bfca4fddfad40ebb9/Monsalma-Maui-v010003/Monsalma-Maui-v010003/ViewModels/MainViewModel.cs#L23-L39](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0cc0d5e35290a96e0c5c1c3bfca4fddfad40ebb9/Monsalma-Maui-v010003/Monsalma-Maui-v010003/ViewModels/MainViewModel.cs#L23-L39)

## View (XAML)

`MainPage` (`Monsalma_Maui_v010003.MainPage`) represents the view.

First we import the package ([`Monsalma.Maui.Controls`](https://www.nuget.org/packages/Monsalma.Maui.Controls/1.0.3)) and local namespaces (data and view model):
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0cc0d5e35290a96e0c5c1c3bfca4fddfad40ebb9/Monsalma-Maui-v010003/Monsalma-Maui-v010003/MainPage.xaml#L5-L7](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0cc0d5e35290a96e0c5c1c3bfca4fddfad40ebb9/Monsalma-Maui-v010003/Monsalma-Maui-v010003/MainPage.xaml#L5-L7)

Then we define row styles (header row, odd row, even row and selected row) for the data grid control:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0cc0d5e35290a96e0c5c1c3bfca4fddfad40ebb9/Monsalma-Maui-v010003/Monsalma-Maui-v010003/MainPage.xaml#L16-L66](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0cc0d5e35290a96e0c5c1c3bfca4fddfad40ebb9/Monsalma-Maui-v010003/Monsalma-Maui-v010003/MainPage.xaml#L16-L66)

`DataGrid` definition differs substantially from previous demos ([Monsalma-Maui-v010000](/Monsalma-Maui-v010000#view-xaml), [Monsalma-Maui-v010001](/Monsalma-Maui-v010001#view-xaml), [Monsalma-Maui-v010002](/Monsalma-Maui-v010002#view-xaml)). In this demo, we added bindable properties related to UI virtualization: `VirtualizationEnabled`, `VirtualizationInitialRowsToLoad`, `VirtualizationRowsBeforeActing`, `VirtualizationRowsToLoad` and `VirtualizationMinRowsToUnload`. These are nicely explained in another post ([Data Grid for .NET MAUI - Version 1.0.3 Released](https://monsalma.net/data-grid-for-net-maui-version-1-0-3-released-supporting-ui-virtualization/)), so I'll not repeat myself here.
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0cc0d5e35290a96e0c5c1c3bfca4fddfad40ebb9/Monsalma-Maui-v010003/Monsalma-Maui-v010003/MainPage.xaml#L78-L92](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/0cc0d5e35290a96e0c5c1c3bfca4fddfad40ebb9/Monsalma-Maui-v010003/Monsalma-Maui-v010003/MainPage.xaml#L78-L92)

This time, there's nothing fancy about the way we define columns:
[https://github.com/Monsalma/Monsalma.Maui.Controls/blob/165afd6c5cdd11b4a8d5f137e9b9093581e38c10/Monsalma-Maui-v010003/Monsalma-Maui-v010003/MainPage.xaml#L94-L113](https://github.com/Monsalma/Monsalma.Maui.Controls/blob/165afd6c5cdd11b4a8d5f137e9b9093581e38c10/Monsalma-Maui-v010003/Monsalma-Maui-v010003/MainPage.xaml#L94-L113)

Tada! Even though we have 10k items, our data grid works fine! Try disabling UI virtulization by setting `VirtualizationEnabled` to `False` and you'll see the difference. 

## Screenshots

### Windows

![Monsalma Data Grid for .NET MAUI - Demo - UI Virtualization - Windows](/Images/v010003_DataGrid_Virtualization_Windows.png)

### Android

![Monsalma Data Grid for .NET MAUI - Demo - UI Virtualization - Android](/Images/v010003_DataGrid_Virtualization_Android.png)
