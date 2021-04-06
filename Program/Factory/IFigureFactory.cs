using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperPaint.Figures;

namespace SuperPaint
{
    public interface IFigureFactory
    {
        string Name { get; }
        Figure Instantiate();
    }
}
