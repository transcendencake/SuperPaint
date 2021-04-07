using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperPaint;
using SuperPaint.Figures;

namespace Trapezoid
{
    class TrapezoidFactory : IFigureFactory
    {
        public string Name
        {
            get { return "Trapezoid"; }
        }
        public Type FigureType
        {
            get { return typeof(Trapezoid); }
        }
        public Figure Instantiate()
        {
            return new Trapezoid();
        }
    }
}
