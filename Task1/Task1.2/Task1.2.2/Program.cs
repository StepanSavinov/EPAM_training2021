using System;

namespace epamXT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую строку: ");
            string firstString = Console.ReadLine() + Environment.NewLine;

            Console.Write("Введите вторую строку: ");
            string secondString = Console.ReadLine();

            for (int i = 0; i < firstString.Length; i++)
            {
                if (secondString.Contains(firstString[i]))
                {
                    firstString = firstString.Insert(i + 1, firstString[i++].ToString());
                }
            }
            Console.WriteLine("Результат: {0}", firstString);
        }
    }
}