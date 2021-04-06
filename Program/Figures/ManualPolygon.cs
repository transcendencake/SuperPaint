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
            DrawingPen = DrawingPen ?? new Pen(new SolidBrush(FiguresProperties.CurrBrushColor));
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

        public override string Serialize()
        {
            string result = "";
            result += this.GetType() + ",";
            result += ((SolidBrush)DrawingPen.Brush).Color.ToArgb();
            for (int i = 0; i < Points.Count; i++)
            {
                result += "," + Points[i].X + "," + Points[i].Y;
            }
            return result;
        }

        public override void Deserialize(string[] values)
        {
            DrawingPen = new Pen(new SolidBrush(Color.FromArgb(int.Parse(values[1]))));
            for (int i = 2; i < values.Length; i++)
            {
                Points.Add(new Point(int.Parse(values[i]), int.Parse(values[i + 1])));
                i++;
            }
        }
        public ManualPolygon() : base()
        { }
    }
}
