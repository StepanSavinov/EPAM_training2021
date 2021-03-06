using System;

namespace epamXT
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            Random rand = new Random();
            int sum = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(10);
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += arr[i, j];
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine(Environment.NewLine);
            }

            Console.WriteLine("Сумма элементов на четных позициях: " + sum);
        }
    }
}