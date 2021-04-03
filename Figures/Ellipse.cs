using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPaint.Figures
{
    public class Ellipse : Figure
    {
        public override void Draw(Point? currPoint = null)
        {
            DrawingPen = DrawingPen ?? new Pen(new SolidBrush(FiguresProperties.CurrBrushColor));
            Point secondPoint = this.Points.Count == 1 ? (Point)currPoint : this.Points[1];
            FiguresProperties.Canvas.FillEllipse(DrawingPen.Brush, new System.Drawing.Rectangle(Points[0].X, Points[0].Y,
                secondPoint.X - Points[0].X, secondPoint.Y - Points[0].Y));
        }
        public Ellipse() : base()
        {}
    }
}
