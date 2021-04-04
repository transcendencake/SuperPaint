using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPaint.Figures
{
    public class ManualPolygon : Figure
    {
        public override void Draw(Point? currPoint = null)
        {
            DrawingPen = DrawingPen ?? (Pen)FiguresProperties.CurrPen.Clone();
            Point[] tempPoints = new Point[Points.Count + 1];
            Points.CopyTo(tempPoints);
            if (currPoint != null)
            {                
                tempPoints[tempPoints.Length - 1] = (Point)currPoint;
                FiguresProperties.Canvas.DrawLines(DrawingPen, tempPoints);
            }
            else
            {
                tempPoints[tempPoints.Length - 1] = new Point(tempPoints[0].X, tempPoints[0].Y);
                GraphicsPath gPath = new GraphicsPath();
                gPath.AddLines(tempPoints);
                FiguresProperties.Canvas.FillPath(DrawingPen.Brush, gPath);
            }            
        }
        public ManualPolygon() : base()
        { }
    }
}
