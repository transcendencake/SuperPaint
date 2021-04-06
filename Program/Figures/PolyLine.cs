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

        public override string Serialize()
        {
            string result = "";
            result += this.GetType() + ",";
            result += DrawingPen.Color.ToArgb() + ",";
            result += (int)DrawingPen.Width;
            for (int i = 0; i < Points.Count; i++)
            {
                result += "," + Points[i].X + "," + Points[i].Y;
            }
            return result;
        }

        public override void Deserialize(string[] values)
        {
            DrawingPen = new Pen(Color.FromArgb(int.Parse(values[1])));
            DrawingPen.Width = int.Parse(values[2]);
            for (int i = 3; i < values.Length; i++)
            {
                Points.Add(new Point(int.Parse(values[i]), int.Parse(values[i + 1])));
                i++;
            }
        }

        public PolyLine() : base()
        { }
    }
}
