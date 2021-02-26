using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPaint.Figures
{
    public static class FiguresProperties
    {
        public static Pen CurrPen = new Pen(Color.Black);
        public static Brush CurrBrush
        { 
            set
            {
                CurrPen.Brush = value;
            }
        }
        public static Graphics Canvas { get; set; }
        public static int Angles { get; set; } = 4;
    }
}
