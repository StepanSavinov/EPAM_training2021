using System;
using System.Linq;
namespace epamXT
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = new int[4] { 1, 1, 3, 5 };

            Console.WriteLine("Sum: {0}, Average: {1}, Most frequent: {2}", 
                array.Summ(), array.Average(), array.MostFrequent());
        }
    }
}
