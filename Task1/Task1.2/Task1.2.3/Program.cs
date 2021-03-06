using System;

namespace epamXT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            string[] splitted = str.Split(new[] { ' ', '!', '?', ':', ',', '.', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;

            foreach (var lower in splitted)
            {
                if (char.IsLower(lower[0]))
                {
                    sum += 1;
                }
            }

            Console.WriteLine("Количество слов, начинающихся с маленькой буквы: {0}", sum);
        }
    }
}