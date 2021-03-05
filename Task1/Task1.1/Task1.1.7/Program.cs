using System;

namespace epamXT
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);
            }

            PrintSortedArray(arr);
            PrintMaxAndMinElements(arr);
        }


        public static void PrintSortedArray(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.Write("Отсортированный массив: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine(Environment.NewLine);
        }

        public static void PrintMaxAndMinElements(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i]) min = arr[i];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i]) max = arr[i];
            }

            Console.WriteLine("Минимальный элемент массива: " + min);
            Console.WriteLine("Максиимальный элемент массива: " + max);
        }
    }
}