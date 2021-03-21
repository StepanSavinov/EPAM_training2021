using System;
using System.Collections.Generic;
using System.Text;

namespace epamXT
{
    public abstract class Figure
    {
        public static List<Figure> AllFigures = new List<Figure>();

        protected int _x;
        protected int _y;

        protected int X { get => _x; set => _x = value; }
        protected int Y { get => _y; set => _y = value; }
        
        public abstract double Area { get; }

        public abstract void CreateFigure();
    }
}
