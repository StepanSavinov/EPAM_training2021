using System;
using System.Collections.Generic;
using System.Text;

namespace epamXT
{
    class Ring : Circle
    {
        private int _innerR;
        
        protected int InnerR { get => _innerR; set => _innerR = value; }
        public Ring() : this(1, 1, 1, 1) { }
        public Ring(int x, int y, int r, int innerR) : base()
        {
            X = x;
            Y = y;
            R = r;
            InnerR = innerR;
        }
        public double InnerArea { get => Math.PI * _innerR * _innerR; }

        public double InnerCircumference { get => 2 * Math.PI * _innerR; }

        public override string ToString() => "Кольцо с координатами: " +
            "X = " + _x + ", " + 
            "Y = " + _y + ", " + 
            "R = " + _r + ", " +
            "Внутренний R = " + _innerR + Environment.NewLine;

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

            Console.Write("Введите внутренний радиус: ");
            int tempInnerR;

            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out tempInnerR));

            InnerR = tempInnerR;

            if (_innerR > _r)
            {
                throw new ArithmeticException("Внутренний радиус не может быть больше внешнего!");
            }

            AllFigures.Add(new Ring(_x, _y, _r, _innerR));

            Console.WriteLine("Кольцо создано!" + Environment.NewLine);
        }






    }
}
