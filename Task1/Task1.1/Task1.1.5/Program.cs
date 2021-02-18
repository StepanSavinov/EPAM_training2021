using System;

namespace epamXT
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            for (int i = 0; i < 1000; i++)
            {

                if (i % 5 == 0 || i % 3 == 0)
                {
                    counter += i;
                }
            }

            Console.WriteLine(counter);
        }
    }
}