using System;

namespace epamXT
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr = new int[3, 3, 3];
            Random rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = rand.Next(-10, 10);
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        if (arr[i,j,k] > 0)
                        {
                            arr[i, j, k] = 0;
                        }
                    }
                }
            }


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write(arr[i, j, k] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}