using System;
using Library;
using System.Drawing;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine
                ("Сейчас мы создадим круг.");
            Console.Write
                ("Введи расположения круга по оси X: ");
            int xCoordinates = CorrectInput.Number();
            Console.Write
                ("Введи расположения круга по оси Y: ");
            int yCoordinates = CorrectInput.Number();
            Console.Write
                ("Введи радиус: ");
            int radius = CorrectInput.PositiveNumber();
            

            var round = new Round(xCoordinates, yCoordinates, radius);
            Console.WriteLine($"Отлично! Круг с координатами {round.Coordinates} и радиусом {round.Radius} создан!");
            Console.WriteLine($"Его длинна равна {round.Lenght}, а площадь {round.Area}.");
            Console.ReadLine();
        }
    }
}
