using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPaint.Figures
{
    public class Rectan : Figure
    {
        public override void Draw(Point? currPoint = null)
        {
            DrawingPen = DrawingPen ?? new Pen(new SolidBrush(FiguresProperties.CurrBrushColor));
            Point secondPoint = this.Points.Count == 1 ? (Point)currPoint : this.Points[1];
            FiguresProperties.Canvas.FillRectangle(DrawingPen.Brush,
                Points[0].X < secondPoint.X ? Points[0].X : secondPoint.X,
                Points[0].Y < secondPoint.Y ? Points[0].Y : secondPoint.Y,
                Math.Abs(secondPoint.X - Points[0].X), Math.Abs(Points[0].Y - secondPoint.Y));
        }
        public Rectan() : base()
        { }
    }
}
