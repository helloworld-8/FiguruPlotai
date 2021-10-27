using Moksliukas.Core.Models;

namespace Moksliukas.Core.ViewModels
{
    public class FigureViewModel
    {
        public FigureModel Figure { get; set; }
        public FigureViewModel(int FigureId)
        {
            this.Figure = FiguresModel.Figures[FigureId];
        }

    }
}
