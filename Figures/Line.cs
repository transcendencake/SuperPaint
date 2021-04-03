using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPaint.Figures
{
    public class Line : Figure
    {
        public override void Draw(Point? currPoint = null)
        {
            DrawingPen = DrawingPen ?? (Pen)FiguresProperties.CurrPen.Clone();
            Point secondPoint = this.Points.Count == 1 ? (Point)currPoint : this.Points[1];
            FiguresProperties.Canvas.DrawLine(DrawingPen, this.Points[0], secondPoint);
        }
        public Line() : base()
        { }
    }
}
