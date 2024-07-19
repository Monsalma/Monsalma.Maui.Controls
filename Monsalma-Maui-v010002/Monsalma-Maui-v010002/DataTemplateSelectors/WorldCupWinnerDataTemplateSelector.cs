using Monsalma_Maui_v010002.Data;

namespace Monsalma_Maui_v010002.DataTemplateSelectors
{
    internal class WorldCupWinnerDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Century20Template { get; set; }
        public DataTemplate Century2021Template { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((WorldCupWinner)item).Year >= 2000 ? Century2021Template : Century20Template;
        }
    }
}
