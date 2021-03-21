using System;
using System.Collections.Generic;
using System.Text;


namespace epamXT
{
    class Circle : Figure
    {
        private protected int _r;
        protected int R { get => _r; set => _r = value; }
        public Circle() : this(1, 1, 1) { }
        public Circle(int x, int y, int r)
        {
            X = x;
            Y = y;
            R = r;

        }

        public override double Area { get => Math.PI * _r * _r; }

        public double Circumference { get => 2 * Math.PI * _r; }

        public override string ToString() => "Круг с координатами: " + 
            "X = " + _x + ", " + 
            "Y = " + _y + ", " + 
            "R = " + _r + Environment.NewLine;

        public override void CreateFigure()
        {
            Console.WriteLine("Введите Параметры фигуры Круг");

            Console.Write("Введите координату Х центральной точки: ");
            string input;
            int tempX;

            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out tempX));
            
            X = tempX;

            Console.Write("Введите координату У центральной точки: ");
            int tempY;

            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out tempY));

            Y = tempY;

            Console.Write("Введите радиус: ");
            int tempR;

            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out tempR));

            R = tempR;

            AllFigures.Add(new Circle(_x, _y, _r));

            Console.WriteLine("Круг создан!" + Environment.NewLine);
        }
    }
}
