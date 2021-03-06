using System;

namespace epamXT
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[10];
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-10, 10);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }

            Console.Write("Полученный массив: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Сумма всех неотрицательных элементов: " + sum);
        }
    }
}