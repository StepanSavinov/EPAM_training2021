using System;
using System.Text;

namespace epamXT
{
    class Program
    {
        static void Main(string[] args)
        {
            Choose();
        }
        public static void Choose()
        {
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            Ring ring = new Ring();
            Triangle triangle = new Triangle();

            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("Добавить фигуру - 1");
            Console.WriteLine("Вывести все фигуры - 2");
            Console.WriteLine("Очистить холст - 3");
            Console.WriteLine("Выход - 4");

            string Choice = Console.ReadLine();

            switch (Choice)
            {
                case "1":
                    Console.WriteLine("Какую фигуру вы хотите добавить?");
                    Console.WriteLine("Круг - 1");
                    Console.WriteLine("Кольцо - 2");
                    Console.WriteLine("Прямоугольник - 3");
                    Console.WriteLine("Треугольник - 4");
                    string SecondChoice = Console.ReadLine();

                    switch (SecondChoice)
                    {
                        case "1":
                            circle.CreateFigure();
                            break;

                        case "2":
                            ring.CreateFigure();
                            break;

                        case "3":
                            rectangle.CreateFigure();
                            break;

                        case "4":
                            triangle.CreateFigure();
                            break;

                        default:
                            break;
                    }
                    Choose();
                    break;

                case "2":
                    foreach (var figure in Figure.AllFigures)
                    {
                        Console.WriteLine(figure.ToString());
                    }
                    Choose();
                    break;

                case "3":
                    Figure.AllFigures.Clear();
                    Console.WriteLine("Холст очищен");
                    Choose();
                    break;

                case "4":
                    break;

                default:
                    break;
            }
        }
    }
}