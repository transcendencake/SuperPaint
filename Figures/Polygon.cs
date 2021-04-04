using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPaint.Figures
{
    public class Polygon : Figure
    {
        private int? anglesNum;
        public override void Draw(Point? currPoint = null)
        {
            DrawingPen = DrawingPen ?? new Pen(new SolidBrush(FiguresProperties.CurrBrushColor));

            Point secondPoint = this.Points.Count == 1 ? (Point)currPoint : this.Points[1];

            Point center = new Point();
            double r = Math.Round(Math.Sqrt(Math.Pow(Points[0].X - secondPoint.X, 2) +
                                           Math.Pow(Points[0].Y - secondPoint.Y, 2)) / 2);
            center.X = Points[0].X + (secondPoint.X - Points[0].X) / 2;
            center.Y = Points[0].Y + (secondPoint.Y - Points[0].Y) / 2;

            anglesNum = anglesNum ?? FiguresProperties.Angles;
            double _angleCenterDegree = Math.PI * 2 / (int)anglesNum;

            List<Point> path = new List<Point>();
            Point topPoint = new Point(center.X, center.Y - (int)r);
            path.Add(topPoint);

            double currDegree = _angleCenterDegree;
            for (int i = 1; i < anglesNum; i++)
            {
                double a = r * Math.Sin(currDegree);
                double b = r * (1 - Math.Cos(currDegree));
                Point nextPoint = new Point((int)(topPoint.X - a), (int)(topPoint.Y + b));
                path.Add(nextPoint);
                currDegree += _angleCenterDegree;
            }

            GraphicsPath gPath = new GraphicsPath();
            gPath.AddLines(path.ToArray());
            FiguresProperties.Canvas.FillPath(DrawingPen.Brush, gPath);
        }

        public override string Serialize()
        {
            string result = "";
            result += this.GetType() + ",";
            result += ((SolidBrush)DrawingPen.Brush).Color.ToArgb() + ",";
            result += (int)anglesNum + ",";
            result += Points[0].X + ",";
            result += Points[0].Y + ",";
            result += Points[1].X + ",";
            result += Points[1].Y;
            return result;
        }

        public override void Deserialize(string[] values)
        {
            DrawingPen = new Pen(new SolidBrush(Color.FromArgb(int.Parse(values[1]))));
            anglesNum = int.Parse(values[2]);
            Points.Add(new Point(int.Parse(values[3]), int.Parse(values[4])));
            Points.Add(new Point(int.Parse(values[5]), int.Parse(values[6])));
        }

        public Polygon() : base()
        {
            anglesNum = null;
        }
    }
        
}
