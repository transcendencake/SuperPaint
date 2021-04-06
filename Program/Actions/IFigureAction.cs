using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperPaint.Figures;

namespace SuperPaint.Actions
{
    public interface IFigureAction
    {
        Figure Figure { get; set; }
        void Undo();
        void Redo();
    }
}
