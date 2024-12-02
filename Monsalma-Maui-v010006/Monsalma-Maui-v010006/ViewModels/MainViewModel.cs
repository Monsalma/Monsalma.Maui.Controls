using CommunityToolkit.Mvvm.ComponentModel;
using Monsalma_Maui_v010006.Data;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Monsalma_Maui_v010006.ViewModels
{
    internal partial class MainViewModel : ObservableObject
    {
        private const int MAX_SELECTED_TEAMS = 3;

        private readonly string[] teams =
        [
            "Atlanta Hawks",
            "Boston Celtics",
            "Brooklyn Nets",
            "Charlotte Hornets",
            "Chicago Bulls",
            "Cleveland Cavaliers",
            "Dallas Mavericks",
            "Denver Nuggets",
            "Detroit Pistons",
            "Golden State Warriors",
            "Houston Rockets",
            "Indiana Pacers",
            "Los Angeles Clippers",
            "Los Angeles Lakers",
            "Memphis Grizzlies",
            "Miami Heat",
            "Milwaukee Bucks",
            "Minnesota Timberwolves",
            "New Orleans Pelicans",
            "New York Knicks",
            "Oklahoma City Thunder",
            "Orlando Magic",
            "Philadelphia 76ers",
            "Phoenix Suns",
            "Portland Trail Blazers",
            "Sacramento Kings",
            "San Antonio Spurs",
            "Toronto Raptors",
            "Utah Jazz",
            "Washington Wizards"
        ];

        private ObservableCollection<NBATeam> nbaTeams;
        public ObservableCollection<NBATeam> NBATeams 
        { 
            get => nbaTeams; 
            set => SetProperty(ref nbaTeams, value);
        }

        private ObservableCollection<NBATeam> selectedTeams = [];
        public ObservableCollection<NBATeam> SelectedTeams 
        {
            get => selectedTeams;
            set => SetProperty(ref selectedTeams, value);
        }

        public ICommand SelectDeselectCommand { get; private set; }

        public MainViewModel() 
        {
            // Command
            SelectDeselectCommand = new Command(
                execute: (object commandParameter) =>
                {
                    if (commandParameter is NBATeam team)
                    {
                        if (team.IsSelected) // deselect
                        {
                            team.IsSelected = false;
                            SelectedTeams.Remove(team);
                        }
                        else // select
                        {
                            if (SelectedTeams.Count < MAX_SELECTED_TEAMS)
                            {
                                team.IsSelected = true;
                                SelectedTeams.Add(team);
                            }
                        }
                    }
                },
                canExecute: (object commandParameter) => true
            );

            // Demo data
            NBATeams = [];
            foreach (string team in teams)
            {
                NBATeam newDemoData = new()
                {
                    IsSelected = false,
                    Name = team,
                    ImageSource = team.ToLower().Replace(" ", "_") + ".png"
                };

                NBATeams.Add(newDemoData);
            }
        }
    }
}
