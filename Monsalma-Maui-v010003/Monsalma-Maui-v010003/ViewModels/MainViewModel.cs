using CommunityToolkit.Mvvm.ComponentModel;
using Monsalma_Maui_v010003.Data;
using System.Collections.ObjectModel;

namespace Monsalma_Maui_v010003.ViewModels
{
    internal class MainViewModel : ObservableObject
    {
        private ObservableCollection<VirtualizationDemoData> demoData;
        public ObservableCollection<VirtualizationDemoData> DemoData 
        { 
            get => demoData; 
            set => SetProperty(ref demoData, value);
        }

        private VirtualizationDemoData selectedDemoData;
        public VirtualizationDemoData SelectedDemoData
        {
            get => selectedDemoData;
            set => SetProperty(ref selectedDemoData, value);
        }

        public MainViewModel() 
        {
            Random random = new(DateTime.Now.Millisecond);

            DemoData = [];
            for (int i = 0; i < 10000; ++i)
            {
                VirtualizationDemoData newDemoData = new()
                {
                    RowNumber = i + 1,
                    ColumnA = new string('A', random.Next(5, 50)),
                    ColumnB = new string('B', random.Next(5, 100))
                };

                DemoData.Add(newDemoData);
            }
        }
    }
}
