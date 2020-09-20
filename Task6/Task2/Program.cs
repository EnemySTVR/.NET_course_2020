using System;
using Library;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сейчас мы создадим кольцо.");
            Console.Write("Введи расположения круга по оси X: ");
            int xCoordinates = CorrectInput.Number();
            Console.Write("Введи расположения круга по оси Y: ");
            int yCoordinates = CorrectInput.Number();
            Console.Write("Введи внешний радиус: ");
            int externalRadius = CorrectInput.PositiveNumber();
            Console.Write("Введи внутренний радиус: ");
            int interiorRadius = CorrectInput.PositiveNumber();

            var ring = new Ring(xCoordinates, yCoordinates, externalRadius, interiorRadius);
            Console.WriteLine($"Отлично! Кольцо с координатами {ring.Coordinates}, внешним радиусом {ring.Radius} и внутренним радиусом {ring.InteriorRadius} создан!");
            Console.WriteLine($"Сумма длинны внешнего и внутреннего равна {ring.Lenght}, а площадь {ring.Area}.");
            Console.ReadLine();
        }
    }
}
