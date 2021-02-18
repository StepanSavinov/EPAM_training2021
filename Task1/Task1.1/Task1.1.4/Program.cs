using System;

namespace epamXT
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 1;
            Console.Write("Введите кол-во треугольников: ");
            int K = int.Parse(Console.ReadLine());

            Console.WriteLine();

            while (N < K)
            {

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

                N++;
            }
        }
    }
}