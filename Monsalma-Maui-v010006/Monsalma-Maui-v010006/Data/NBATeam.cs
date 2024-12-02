using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Monsalma_Maui_v010006.Data
{
    public partial class NBATeam : INotifyPropertyChanged
    {
        #region Properties
        public bool IsSelected { get; set; }
        public string IsSelectedText => IsSelected ? "Deselect" : "Select";
        public string Name { get; set; }
        public string ImageSource { get; set; }
        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        #endregion
    }
}
