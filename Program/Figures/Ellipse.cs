﻿using System;
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

        public Ellipse() : base()
        {}
    }
}
