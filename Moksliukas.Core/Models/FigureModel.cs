using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace Moksliukas.Core.Models
{
    public class FigureModel
    {
        public int FigureId { get; set; }
        public string FigureName { get; set; }
        public string FigureExpression { get; set; }
        private List<FigureArgumentModel> FigureArguments { get; set; } = new List<FigureArgumentModel>();

        public void AddFigureArgument(FigureArgumentModel argument) => FigureArguments.Add(argument);
        public List<FigureArgumentModel> GetFigureArguments() => FigureArguments;
        public void Save() => FiguresModel.Save(this);
    }
}
