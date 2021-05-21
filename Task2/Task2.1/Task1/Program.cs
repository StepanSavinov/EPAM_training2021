using System;

namespace epam_xt
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomString customString = new CustomString("This is another custom string");
            CustomString customString1 = new CustomString("This is another custom string");

            Console.WriteLine(customString.IndexOfChar('T'));

            Console.WriteLine(customString.Contains('A'));

            Console.WriteLine(CustomString.CompareTo(customString, customString1));

            Console.WriteLine(CustomString.Concatenate(customString, customString1));
        }
    }
}
