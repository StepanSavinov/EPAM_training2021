using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace epamXT
{
    class Program
    {

        static void Main(string[] args)
        {
            DynamicArray<int> dynamicArray = new DynamicArray<int>();

            var dynamicArray2 = new DynamicArray<int>();

            int temp = 1;
            int temp2 = 10;

            for (int i = 0; i < dynamicArray.Capacity; i++)
            {
                dynamicArray.Add(temp);
                temp++;
            }

            for (int i = 0; i < dynamicArray2.Capacity; i++)
            {
                dynamicArray2.Add(temp2);
                temp2++;
            }

            dynamicArray.Add(9);

            Console.Write("First DynamicArray: ");
            foreach (var item in dynamicArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.Write("Second DynamicArray: ");
            foreach (var item in dynamicArray2)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            dynamicArray.Remove(5);
            dynamicArray.Remove(3);

            dynamicArray.AddRange(dynamicArray2);

            dynamicArray.Insert(2, 23);

            Console.Write("Final DynamicArray: ");
            foreach (var item in dynamicArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Length: {0}, Capacity: {1}", dynamicArray.Length, dynamicArray.Capacity);
        }
    }
}
