using System;
using System.Linq;

namespace epamXT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            string[] splitted = str.Split(new[] {' ', '!', '?', ':', ',', '.'}, StringSplitOptions.RemoveEmptyEntries);
            int averageLength = splitted.Aggregate(0, (count, nextWord) => count += nextWord.Length) / splitted.Length;

            Console.WriteLine("Средняя длина слов в строке: {0}", averageLength);
        }
    }
}