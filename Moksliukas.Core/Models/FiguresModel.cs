using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace Moksliukas.Core.Models
{
    public class FiguresModel
    {
        public static List<FigureModel> Figures { get; set; } = new List<FigureModel>();
        public static void Save(FigureModel figure) => Figures.Add(figure);
    }
}
