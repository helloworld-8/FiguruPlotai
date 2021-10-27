using System.Collections.Generic;
using Moksliukas.Core.Models;

namespace Moksliukas.Core.ViewModels
{
    public class MainViewModel
    {
        public List<FigureModel> Figures { get; set; } = FiguresModel.Figures;
    }
}
