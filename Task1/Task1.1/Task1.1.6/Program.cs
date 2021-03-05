using System;
using System.Text;

namespace epamXT
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder currentStyle = new StringBuilder();
            currentStyle.Append("None");
            parameters(currentStyle);
            choose(currentStyle); 
        }
        public static void parameters(StringBuilder currentStyle)
        {
            Console.WriteLine("Параметры надписи: " + currentStyle);
            Console.WriteLine("Введите:");
            Console.WriteLine("\t 1: bold");
            Console.WriteLine("\t 2: italic");
            Console.WriteLine("\t 3: underline");
        }

        public static void choose(StringBuilder currentStyle)
        {
            var choice = (Console.ReadLine());

            switch (choice)
            {
                case "1":

                    if (currentStyle.ToString().Contains("None"))
                    {
                        currentStyle.Clear();
                        currentStyle.Append("Bold ");
                    }

                    else if (currentStyle.ToString().Contains("Bold "))
                    {
                        currentStyle.Remove(currentStyle.ToString().IndexOf('B'), 5);
                    }

                    else if (currentStyle.ToString().Contains(""))
                    {
                        currentStyle.Append("Bold ");
                    }

                    parameters(currentStyle);
                    choose(currentStyle);
                    break;

                case "2":

                    if (currentStyle.ToString().Contains("None"))
                    {
                        currentStyle.Clear();
                        currentStyle.Append("Italic ");
                    }

                    else if (currentStyle.ToString().Contains("Italic "))
                    {
                        currentStyle.Remove(currentStyle.ToString().IndexOf('I'), 7);
                    }

                    else if (currentStyle.ToString().Contains(""))
                    {
                        currentStyle.Append("Italic ");
                    }

                    parameters(currentStyle);
                    choose(currentStyle);
                    break;

                case "3":

                    if (currentStyle.ToString().Contains("None"))
                    {
                        currentStyle.Clear();
                        currentStyle.Append("Underline ");
                    }

                    else if (currentStyle.ToString().Contains("Underline "))
                    {
                        currentStyle.Remove(currentStyle.ToString().IndexOf('U'), 10);
                    }

                    else if (currentStyle.ToString().Contains(""))
                    {
                        currentStyle.Append("Underline ");
                    }

                    parameters(currentStyle);
                    choose(currentStyle);
                    break;

                default:

                    Console.WriteLine("Такого выбора нет!");
                    parameters(currentStyle);
                    choose(currentStyle);
                    break;
            }
        }
    }
}