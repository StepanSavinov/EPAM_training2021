using System;

namespace epamXT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту треугольника: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}