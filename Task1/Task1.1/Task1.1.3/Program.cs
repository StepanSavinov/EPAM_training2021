using System;

namespace epamXT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите основание треугольника: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                for (int j = 1; j < N - i; j++)
                {
                    Console.Write(' ');
                }
                for (int j = N - 2 * i; j <= N; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}