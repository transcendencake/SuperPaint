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

        public override string Serialize()
        {
            string result = "";
            result += this.GetType() + ",";
            result += DrawingPen.Color.ToArgb() + ",";
            result += (int)DrawingPen.Width + ",";
            result += Points[0].X + ",";
            result += Points[0].Y + ",";
            result += Points[1].X + ",";
            result += Points[1].Y;
            return result;
        }

        public override void Deserialize(string[] values)
        {
            DrawingPen = new Pen(Color.FromArgb(int.Parse(values[1])));
            DrawingPen.Width = int.Parse(values[2]);
            Points.Add(new Point(int.Parse(values[3]), int.Parse(values[4])));
            Points.Add(new Point(int.Parse(values[5]), int.Parse(values[6])));
        }

        public Line() : base()
        { }

    }
}
