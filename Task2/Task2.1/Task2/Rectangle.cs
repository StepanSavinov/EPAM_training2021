using System;
using System.Collections.Generic;
using System.Text;

namespace epamXT
{
    class Rectangle : Figure
    {
        private int _sideA;
        private int _sideB;
        int SideA { get => _sideA; set => _sideA = value; }
        int SideB { get => _sideB; set => _sideB = value; }


        public Rectangle() : this(1, 1, 1, 1) { }
        public Rectangle(int x, int y, int sideA, int sideB)
        {
            X = x;
            Y = y;
            SideA = sideA;
            SideB = sideB;
        }
        public override double Area { get => _sideA * _sideB; }

        public override string ToString() => "Прямоугольник с координатами: " +
            "X = " + _x + ", " +
            "Y = " + _y + ", " +
            "Сторона A = " + _sideA + ", " +
            "Сторона B = " + _sideB + Environment.NewLine;

        public override void CreateFigure()
        {
            Console.WriteLine("Введите Параметры фигуры Квадрат");

            Console.Write("Введите координату Х левой верхней точки квадрата: ");
            string input;
            int tempX;

            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out tempX));

            X = tempX;

            Console.Write("Введите координату У левой верхней точки квадрата: ");
            int tempY;

            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out tempY));

            Y = tempY;

            Console.Write("Введите длину стороны A: ");
            int tempSideA;

            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out tempSideA));

            SideA = tempSideA;

            Console.Write("Введите длину стороны B: ");
            int tempSideB;

            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out tempSideB));

            SideB = tempSideB;

            AllFigures.Add(new Rectangle(_x, _y, _sideA, _sideB));

            if (_sideA == _sideB)
            {
                Console.WriteLine("Квадрат создан!" + Environment.NewLine);
            }

            else
            {
                Console.WriteLine("Прямоугольник создан!" + Environment.NewLine);
            }
        }
    }
}
