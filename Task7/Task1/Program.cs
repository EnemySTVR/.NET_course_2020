using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var figures = new List<Figure>();
            UI.MainMenu(figures);
        }
    }

    static class UI
    {
        public static void MainMenu(List<Figure> figures)
        {
            Console.Clear();
            Console.WriteLine("1.Создать линию");
            Console.WriteLine("2.Создать откужность");
            Console.WriteLine("3.Создать прямоугольник");
            Console.WriteLine("4.Создать круг");
            Console.WriteLine("5.Создать кольцо");
            Console.WriteLine("6.Вывести на экран созданные фигуры");
            Console.Write("Введите цифру соответствующую пункту меню: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateLine(figures);
                    break;

                case "2":
                    CreateRound(figures);
                    break;

                case "3":
                    CreateRectangle(figures);
                    break;

                case "4":
                    CreateCorrectRound(figures);
                    break;

                case "5":
                    CreateRing(figures);
                    break;

                case "6":
                    Input(figures);
                    break;
                default:
                    MainMenu(figures);
                    break;
            }
        }
        public static void CreateLine(List<Figure> figures)
        {
            int a_x;
            int a_y;
            int b_x;
            int b_y;
            Console.Clear();
            Console.WriteLine("Введите координаты точки А.");
            Console.Write("X: ");
            a_x = Int32.Parse(CorrectInput());
            
            Console.Write("Y: ");
            a_y = Int32.Parse(CorrectInput());

            Console.WriteLine("Введите координаты точки B.");
            Console.Write("X: ");
            b_x = Int32.Parse(CorrectInput());

            Console.Write("Y: ");
            b_y = Int32.Parse(CorrectInput());

            figures.Add(new Line(a_x, a_y, b_x, b_y));
                        
            UI.MainMenu(figures);
        }
        public static void CreateRound(List<Figure> figures)
        {
            int x;
            int y;
            int radius_x;
            int radius_y;

            Console.Clear();
            Console.WriteLine("Введите координаты.");
            Console.Write("X: ");
            x = Int32.Parse(CorrectInput());

            Console.Write("Y: ");
            y = Int32.Parse(CorrectInput());

            Console.WriteLine("Введите радиусы по осям.");
            Console.Write("X: ");
            radius_x = Int32.Parse(CorrectInput());

            Console.Write("Y: ");
            radius_y = Int32.Parse(CorrectInput());

            figures.Add(new Round(x, y, radius_x, radius_y));

            UI.MainMenu(figures);
        }
        public static void CreateRectangle(List<Figure> figures)
        {
            int x;
            int y;
            int height;
            int width;

            Console.Clear();
            Console.WriteLine("Введите координаты.");
            Console.Write("X: ");
            x = Int32.Parse(CorrectInput());
            Console.Write("Y: ");
            y = Int32.Parse(CorrectInput());
            Console.Write("Введите высоту: ");
            height = Int32.Parse(CorrectInput());
            Console.Write("Введите ширину: ");
            width = Int32.Parse(CorrectInput());

            figures.Add(new Rectangle(x, y, width, width));

            UI.MainMenu(figures);
        }
        public static void CreateCorrectRound(List<Figure> figures)
        {
            int x;
            int y;
            int radius;

            Console.Clear();
            Console.WriteLine("Введите координаты.");
            Console.Write("X: ");
            x = Int32.Parse(CorrectInput());
            Console.Write("Y: ");
            y = Int32.Parse(CorrectInput());
            Console.Write("Введите радиус: ");
            radius = Int32.Parse(CorrectInput());

            figures.Add(new CorrectRound(x, y, radius));

            UI.MainMenu(figures);
        }
        public static void CreateRing(List<Figure> figures)
        {
            int x;
            int y;
            int external_radius;
            int interior_radius;

            Console.Clear();
            Console.WriteLine("Введите координаты.");
            Console.Write("X: ");
            x = Int32.Parse(CorrectInput());
            Console.Write("Y: ");
            y = Int32.Parse(CorrectInput());
            Console.Write("Введите внешний радиус: ");
            external_radius = Int32.Parse(CorrectInput());
            Console.Write("Введите внутренний радиус: ");
            interior_radius = Int32.Parse(CorrectInput());

            figures.Add(new Ring(x, y, external_radius, interior_radius));

            UI.MainMenu(figures);
        }
        public static void Input(List<Figure> figures)
        {
            Console.Clear();
            foreach(var f in figures)
            {
                f.Draw();
            }
            Console.ReadLine();

            UI.MainMenu(figures);
        }

        private static string CorrectInput()
        {
            string input;
            do
            { input = Console.ReadLine(); }
            while (!Regex.IsMatch(input, @"^(\d*)$"));
            return input;
        }
    }


}
