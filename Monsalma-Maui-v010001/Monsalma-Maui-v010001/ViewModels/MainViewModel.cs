using CommunityToolkit.Mvvm.ComponentModel;
using Monsalma_Maui_v010001.Data;
using System.Collections.ObjectModel;

namespace Monsalma_Maui_v010001.ViewModels
{
    internal class MainViewModel : ObservableObject
    {
        private ObservableCollection<WorldCupWinner> worldCupWinners;
        public ObservableCollection<WorldCupWinner> WorldCupWinners 
        { 
            get => worldCupWinners; 
            set => SetProperty(ref worldCupWinners, value);
        }

        private WorldCupWinner selectedWorldCupWinner;
        public WorldCupWinner SelectedWorldCupWinner
        {
            get => selectedWorldCupWinner;
            set => SetProperty(ref selectedWorldCupWinner, value);
        }

        private ObservableCollection<object> selectedWorldCupWinners;
        public ObservableCollection<object> SelectedWorldCupWinners // TO BE IMPROVED (converter)
        {
            get => selectedWorldCupWinners;
            set => SetProperty(ref selectedWorldCupWinners, value);
        }

        public MainViewModel() 
        {
            WorldCupWinners = [];
            
            WorldCupWinners.Add(new WorldCupWinner() { Year = 1986, Country = "Argentina", ImageSource="argentina.png", GoldenBallWinner = "Diego Maradona" });
            WorldCupWinners.Add(new WorldCupWinner() { Year = 1990, Country = "Germany", ImageSource = "germany.png", GoldenBallWinner = "Salvatore Schillaci" });
            WorldCupWinners.Add(new WorldCupWinner() { Year = 1994, Country = "Brazil", ImageSource = "brazil.png", GoldenBallWinner = "Romário" });
            WorldCupWinners.Add(new WorldCupWinner() { Year = 1998, Country = "France", ImageSource = "france.png", GoldenBallWinner = "Ronaldo" });
            WorldCupWinners.Add(new WorldCupWinner() { Year = 2002, Country = "Brazil", ImageSource = "brazil.png", GoldenBallWinner = "Oliver Kahn" });
            WorldCupWinners.Add(new WorldCupWinner() { Year = 2006, Country = "Italy", ImageSource = "italy.png", GoldenBallWinner = "Zinedine Zidane" });
            WorldCupWinners.Add(new WorldCupWinner() { Year = 2010, Country = "Spain", ImageSource = "spain.png", GoldenBallWinner = "Diego Forlán" });
            WorldCupWinners.Add(new WorldCupWinner() { Year = 2014, Country = "Germany", ImageSource = "germany.png", GoldenBallWinner = "Lionel Messi" });
            WorldCupWinners.Add(new WorldCupWinner() { Year = 2018, Country = "France", ImageSource = "france.png", GoldenBallWinner = "Luka Modrić" });
            WorldCupWinners.Add(new WorldCupWinner() { Year = 2022, Country = "Argentina", ImageSource = "argentina.png", GoldenBallWinner = "Lionel Messi" });
        }
    }
}
