using System;
using System.Collections.Generic;
using Library;

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
            Console.WriteLine
                ("1.Создать линию");
            Console.WriteLine
                ("2.Создать откужность");
            Console.WriteLine
                ("3.Создать прямоугольник");
            Console.WriteLine
                ("4.Создать круг");
            Console.WriteLine
                ("5.Создать кольцо");
            Console.WriteLine
                ("6.Вывести на экран созданные фигуры");
            Console.Write
                ("Введите цифру соответствующую пункту меню: ");

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
                    OutputAll(figures);
                    break;
                default:
                    MainMenu(figures);
                    break;
            }
        }
        public static void CreateLine(List<Figure> figures)
        {
            Console.Clear();
            Console.WriteLine
                ("Введите координаты точки А.");
            Console.Write
                ("X: ");
            int aXCoordinates = CorrectInput.Number();
            Console.Write
                ("Y: ");
            int aYCoordinates = CorrectInput.Number();
            Console.WriteLine
                ("Введите координаты точки B.");
            Console.Write
                ("X: ");
            int bXCoordinates = CorrectInput.Number();
            Console.Write("Y: ");
            int bYCoordinates = CorrectInput.Number();

            figures.Add(new Line(aXCoordinates, aYCoordinates, bXCoordinates, bYCoordinates));
                        
            UI.MainMenu(figures);
        }
        public static void CreateRound(List<Figure> figures)
        {
            Console.Clear();
            Console.WriteLine
                ("Введите координаты.");
            Console.Write
                ("X: ");
            int xCoordinates = CorrectInput.Number();
            Console.Write
                ("Y: ");
            int yCoordinates = CorrectInput.Number();
            Console.WriteLine
                ("Введите радиусы по осям.");
            Console.Write
                ("X: ");
            int radiusX = CorrectInput.PositiveNumber();
            Console.Write
                ("Y: ");
            int radiusY = CorrectInput.PositiveNumber();

            figures.Add(new Round(xCoordinates, yCoordinates, radiusX, radiusY));

            UI.MainMenu(figures);
        }
        public static void CreateRectangle(List<Figure> figures)
        {
            Console.Clear();
            Console.WriteLine
                ("Введите координаты.");
            Console.Write
                ("X: ");
            int xCoordinates = CorrectInput.Number();
            Console.Write
                ("Y: ");
            int yCoordinates = CorrectInput.Number();
            Console.Write
                ("Введите высоту: ");
            int height = CorrectInput.PositiveNumber();
            Console.Write
                ("Введите ширину: ");
            int width = CorrectInput.PositiveNumber();

            figures.Add(new Rectangle(xCoordinates, yCoordinates, width, width));

            UI.MainMenu(figures);
        }
        public static void CreateCorrectRound(List<Figure> figures)
        {
            Console.Clear();
            Console.WriteLine
                ("Введите координаты.");
            Console.Write
                ("X: ");
            int x = CorrectInput.Number();
            Console.Write
                ("Y: ");
            int y = CorrectInput.Number();
            Console.Write
                ("Введите радиус: ");
            int radius = CorrectInput.PositiveNumber();

            figures.Add(new CorrectRound(x, y, radius));

            UI.MainMenu(figures);
        }
        public static void CreateRing(List<Figure> figures)
        {
            Console.Clear();
            Console.WriteLine
                ("Введите координаты.");
            Console.Write
                ("X: ");
            int xCoordinates = CorrectInput.Number();
            Console.Write
                ("Y: ");
            int yCoordinates = CorrectInput.Number();
            Console.Write
                ("Введите внешний радиус: ");
            int externalRadius = CorrectInput.PositiveNumber();
            Console.Write
                ("Введите внутренний радиус: ");
            int interiorRadius = CorrectInput.PositiveNumber();

            figures.Add(new Ring(xCoordinates, yCoordinates, externalRadius, interiorRadius));

            UI.MainMenu(figures);
        }
        public static void OutputAll(List<Figure> figures)
        {
            Console.Clear();
            foreach(var f in figures)
            {
                f.Draw();
            }
            Console.ReadLine();

            UI.MainMenu(figures);
        }

    }


}
