using System;
using System.Collections.Generic;
using System.Text;

namespace epamXT
{
    class Triangle : Figure
    {
        private int _x2;
        private int _y2;

        private int _x3;
        private int _y3;

        protected int X2 { get => _x2; set => _x2 = value; }
        protected int Y2 { get => _y2; set => _y2 = value; }

        protected int X3 { get => _x3; set => _x3 = value; }
        protected int Y3 { get => _y3; set => _y3 = value; }

        public Triangle() : this(1, 1, 1, 1, 1, 1) { }

        public Triangle(int x, int y, int x2, int y2, int x3, int y3)
        {
            X = x;
            Y = y;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
        }

        public override double Area { get => Math.Abs((_x2 - _x) * (_y3 - _y) - (_x3 - _x) * (_y2 - _y)) * 0.5; }

        public override string ToString() => "Треугольник с координатами: " +
            "X = " + _x + ", " +
            "Y = " + _y + ", " +
            "X2 = " + _x2 + ", " +
            "Y2 = " + _y2 + ", " +
            "X3 = " + _x3 + ", " +
            "Y3 = " + _y3 + ", " + Environment.NewLine;

        public override void CreateFigure()
        {
            Console.WriteLine("Введите Параметры фигуры Треугольник");

            Console.Write("Введите координату Х1 создания треугольника: ");
            string input;
            int tempX;

            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out tempX));

            X = tempX;

            Console.Write("Введите координату У1 создания треугольника: ");
            int tempY;

            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out tempY));

            Y = tempY;

            Console.Write("Введите координату X2 точки треугольника: ");
            int tempX2;

            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out tempX2));

            X2 = tempX2;

            Console.Write("Введите координату У2 создания треугольника: ");
            int tempY2;

            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out tempY2));

            Y2 = tempY2;

            Console.Write("Введите координату X3 создания треугольника: ");
            int tempX3;

            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out tempX3));

            X3 = tempX3;

            Console.Write("Введите координату У3 создания треугольника: ");
            int tempY3;

            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out tempY3));

            Y3 = tempY3;

            AllFigures.Add(new Triangle(_x, _y, _x2, _y2, _x3, _y3));

            Console.WriteLine("Треугольник создан!" + Environment.NewLine);
        }
    }
}
