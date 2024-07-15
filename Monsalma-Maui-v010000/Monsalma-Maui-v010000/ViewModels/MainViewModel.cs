using CommunityToolkit.Mvvm.ComponentModel;
using Monsalma_Maui_v010000.Data;
using System.Collections.ObjectModel;

namespace Monsalma_Maui_v010000.ViewModels
{
    internal class MainViewModel : ObservableObject
    {
        private static readonly List<string> FIRST_NAMES = new() 
        {
            "Andre",
            "Bill",
            "Cedric",
            "Chauncey",
            "Dennis",
            "Dirk",
            "Dwyane",
            "Giannis",
            "Hakeem",
            "Isiah",
            "James",
            "Jaylen",
            "Jerry",
            "Joe",
            "Joe",
            "John",
            "Kareem",
            "Kawhi",
            "Kevin",
            "Kobe",
            "Larry",
            "LeBron",
            "Magic",
            "Michael",
            "Moses",
            "Nikola",
            "Paul",
            "Rick",
            "Shaquille",
            "Stephen",
            "Tim",
            "Tony",
            "Wes",
            "Willis",
            "Wilt"
        };
        private static readonly List<string> LAST_NAMES = new() 
        {
            "Iguodala",
            "Walton",
            "Maxwell",
            "Billups",
            "Johnson",
            "Nowitzki",
            "Wade",
            "Antetokounmpo",
            "Olajuwon",
            "Thomas",
            "Worthy",
            "Brow",
            "West",
            "Dumars",
            "White",
            "Havlicek",
            "Abdul-Jabbar",
            "Leonard",
            "Durant",
            "Bryant",
            "Bird",
            "James",
            "Johnson",
            "Jordan",
            "Malone",
            "Jokic",
            "Pierce",
            "Barry",
            "O'Neal",
            "Curry",
            "Duncan",
            "Parker",
            "Unseld",
            "Reed",
            "Chamberlain"
        };

        private ObservableCollection<Person> persons;
        public ObservableCollection<Person> Persons 
        { 
            get => persons; 
            set => SetProperty(ref persons, value);
        }

        private Person selectedPerson;
        public Person SelectedPerson
        {
            get => selectedPerson;
            set => SetProperty(ref selectedPerson, value);
        }

        private ObservableCollection<object> selectedPersons;
        public ObservableCollection<object> SelectedPersons // TO BE IMPROVED (converter)
        {
            get => selectedPersons;
            set => SetProperty(ref selectedPersons, value);
        }

        public MainViewModel() 
        {
            Random random = new(DateTime.Now.Millisecond);

            Persons = new();
            int maxRandomNumber = Math.Min(FIRST_NAMES.Count, LAST_NAMES.Count);
            for (int i = 0; i < 100; ++i)
            {
                int rnd = random.Next(maxRandomNumber);

                Person p = new()
                {
                    Row = i + 1,
                    FirstName = FIRST_NAMES[rnd],
                    LastName = LAST_NAMES[rnd]
                };

                Persons.Add(p);
            }
        }
    }
}
