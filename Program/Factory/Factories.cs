using SuperPaint.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPaint
{
    public class LineFactory : IFigureFactory
    {
        public string Name
        {
            get { return "Line"; }
        }

        public Figure Instantiate()
        {
            return new Line();
        }
    }
    public class EllipseFactory : IFigureFactory
    {
        public string Name
        {
            get { return "Ellipse"; }
        }

        public Figure Instantiate()
        {
            return new Ellipse();
        }
    }
    public class ManualPolygonFactory : IFigureFactory
    {
        public string Name
        {
            get { return "Manual Polygon"; }
        }

        public Figure Instantiate()
        {
            return new ManualPolygon();
        }
    }
    public class PolygonFactory : IFigureFactory
    {
        public string Name
        {
            get { return "Polygon"; }
        }

        public Figure Instantiate()
        {
            return new Polygon();
        }
    }
    public class RectanFactory : IFigureFactory
    {
        public string Name
        {
            get { return "Rectangle"; }
        }

        public Figure Instantiate()
        {
            return new Rectan();
        }
    }
    public class PolyLineFactory : IFigureFactory
    {
        public string Name
        {
            get { return "Polygon Line"; }
        }

        public Figure Instantiate()
        {
            return new PolyLine();
        }
    }
}
