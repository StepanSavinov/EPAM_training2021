using System;

namespace epamXT
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите первую сторону прямоугольника: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите вторую сторону прямоугольника: ");
                    int b = int.Parse(Console.ReadLine());

                    if (a <= 0 || b <= 0)
                    {
                        throw new ArithmeticException("Стороны прямоугольника не могут быть меньше или равны 0!");
                    }

                    int S = a * b;
                    Console.WriteLine("Площадь прямоугольника равна: " + S);
                    break;
                }

                catch (FormatException)
                {
                    Console.WriteLine("Это не целое число!");
                    continue;
                }
            }
        }
    }
}