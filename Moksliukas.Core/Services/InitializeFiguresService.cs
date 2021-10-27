using Moksliukas.Core.Models;
using Newtonsoft.Json;


namespace Moksliukas.Core.Services
{

    public class InitializeFiguresService
    {
        public InitializeFiguresService()
        {

            // Pirmoji figura
            FigureModel f = new FigureModel
            {
                FigureId = 1,
                FigureName = "Trikampio plotas pagal aukštinę",
                FigureExpression = "(1/2)*a*h"
            };
            f.AddFigureArgument(new FigureArgumentModel()
            {
                FigureArgumentName = "a",
                FigureArgumentDescription = "kraštinė"
            });
            f.AddFigureArgument(new FigureArgumentModel()
            {
                FigureArgumentName = "h",
                FigureArgumentDescription = "aukštinė (į kraštinę a)"
            });
            f.Save();


            // Antroji
            f = new FigureModel
            {
                FigureId = 2,
                FigureName = "Trikampio plotas pagal kraštines ir kampą",
                FigureExpression = "(1/2)*a*b*sin(c)"
            };
            f.AddFigureArgument(new FigureArgumentModel()
            {
                FigureArgumentName = "a",
                FigureArgumentDescription = "kraštinė"
            });
            f.AddFigureArgument(new FigureArgumentModel()
            {
                FigureArgumentName = "b",
                FigureArgumentDescription = "kraštinė"
            });
            f.AddFigureArgument(new FigureArgumentModel()
            {
                FigureArgumentName = "c",
                FigureArgumentDescription = "kampas tarp a ir b"
            });
            f.Save();

            // Trecioji
            f = new FigureModel
            {
                FigureId = 3,
                FigureName = "Trikampio plotas pagal pusperimetrį ir įbrėžto apskritimo spindulį",
                FigureExpression = "p*r"
            };
            f.AddFigureArgument(new FigureArgumentModel()
            {
                FigureArgumentName = "p",
                FigureArgumentDescription = "pusperimetris"
            });
            f.AddFigureArgument(new FigureArgumentModel()
            {
                FigureArgumentName = "r",
                FigureArgumentDescription = "įbrėžto apskritimo spindulys"
            });
            f.Save();

        }

    }
}
