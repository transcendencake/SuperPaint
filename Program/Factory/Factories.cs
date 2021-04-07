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
        public Type FigureType 
        {
            get { return typeof(Line); }
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
        public Type FigureType
        {
            get { return typeof(Ellipse); }
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
        public Type FigureType
        {
            get { return typeof(ManualPolygon); }
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
        public Type FigureType
        {
            get { return typeof(Polygon); }
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
        public Type FigureType
        {
            get { return typeof(Rectan); }
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
        public Type FigureType
        {
            get { return typeof(PolyLine); }
        }
        public Figure Instantiate()
        {
            return new PolyLine();
        }
    }
}
