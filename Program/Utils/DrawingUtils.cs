using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperPaint.Figures;

namespace SuperPaint.Utils
{
    internal static class DrawingUtils
    {
        public static void Redraw()
        {
            FiguresProperties.Canvas.Clear(System.Drawing.Color.White);
            foreach (var figure in Storage.AllFigures)
            {
                figure.Draw();
            }
        }
    }
}
