namespace Monsalma_Maui_v010002.Data
{
    public class WorldCupWinner
    {
        public int Year { get; set; }
        public string Country { get; set; }
        public string ImageSource { get; set; }
        public string GoldenBallWinner { get; set; }

        public bool IsCountryReadOnly { get => Year < 2000; }
    }
}
