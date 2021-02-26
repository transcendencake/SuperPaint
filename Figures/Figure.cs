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
        public List<Point> Points { get; protected set; }
        protected abstract void Draw();
        protected Figure() { }
        public abstract Figure Instantiate(List<Point> points);
    }
}
