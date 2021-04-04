using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace SuperPaint.Figures
{
    public class PolyLine : Figure
    {
        public override void Draw(Point? currPoint = null)
        {
            DrawingPen = DrawingPen ?? (Pen)FiguresProperties.CurrPen.Clone();
            Point[] tempPoints = new Point[Points.Count + (currPoint == null ? 0 : 1)];
            Points.CopyTo(tempPoints);
            if (currPoint != null)
                tempPoints[tempPoints.Length - 1] = (Point)currPoint;
            FiguresProperties.Canvas.DrawLines(DrawingPen, tempPoints);
        }
        public PolyLine() : base()
        { }
    }
}
