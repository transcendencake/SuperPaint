using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperPaint.Figures;

namespace Trapezoid
{
    public class Trapezoid : Figure
    {
        public override void Draw(Point? currPoint = null)
        {
            Point secondPoint = this.Points.Count == 1 ? (Point)currPoint : this.Points[1];
            Point thirdPoint = new Point(Points[0].X + (secondPoint.X - Points[0].X) / 4, Points[0].Y);
            Point foughtPoint = new Point(Points[0].X + (secondPoint.X - Points[0].X) / 4 * 3, Points[0].Y);
            Point firstPoint = new Point(Points[0].X, secondPoint.Y);
            GraphicsPath gPath = new GraphicsPath();
            gPath.AddLines(new Point[]
            {
                firstPoint,                
                thirdPoint,
                foughtPoint,
                secondPoint,
                firstPoint
            });
            Canvas.FillPath(DrawingPen.Brush, gPath);
        }

        public override string Serialize()
        {
            string result = "";
            result += this.GetType() + ",";
            result += ((SolidBrush)DrawingPen.Brush).Color.ToArgb() + ",";
            result += Points[0].X + ",";
            result += Points[0].Y + ",";
            result += Points[1].X + ",";
            result += Points[1].Y;
            return result;
        }

        public override void Deserialize(string[] values)
        {
            DrawingPen = new Pen(new SolidBrush(Color.FromArgb(int.Parse(values[1]))));
            Points.Add(new Point(int.Parse(values[2]), int.Parse(values[3])));
            Points.Add(new Point(int.Parse(values[4]), int.Parse(values[5])));
        }

        public Trapezoid() : base()
        { }
    }
}
