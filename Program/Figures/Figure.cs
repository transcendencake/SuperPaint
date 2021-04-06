using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPaint.Figures
{
    public abstract class Figure
    {
        public Graphics Canvas { get; set; }
        public Pen DrawingPen { get; set; }
        public List<Point> Points;
        public abstract void Draw(Point? currPoint = null);
        public Figure()
        {
            Points = new List<Point>();
        }
        public abstract string Serialize();
        public abstract void Deserialize(string[] values);
    }
}
