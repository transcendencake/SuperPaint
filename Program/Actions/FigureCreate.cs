using SuperPaint.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperPaint.Utils;

namespace SuperPaint.Actions
{
    class FigureCreate : IFigureAction
    {
        public Figure Figure { get;  set; }

        public void Redo()
        {
            Storage.AllFigures.Add(Figure);
        }

        public void Undo()
        {
            Storage.AllFigures.Remove(Figure);
        }
    }
}
