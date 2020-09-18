using System;
using Library;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int r_1;
            int r_2;

            Console.WriteLine("Сейчас мы создадим кольцо.");
            Console.Write("Введи расположения круга по оси X: ");
            x = CorrectInput.Number();
            Console.Write("Введи расположения круга по оси Y: ");
            y = CorrectInput.Number();
            Console.Write("Введи внешний радиус: ");
            r_1 = CorrectInput.PositiveNumber();
            Console.Write("Введи внутренний радиус: ");
            r_2 = CorrectInput.PositiveNumber();

            var ring = new Ring(x, y, r_1, r_2);

            Console.WriteLine();

            Console.WriteLine($"Отлично! Кольцо с координатами {ring.Coordinates}, внешним радиусом {ring.Radius} и внутренним радиусом {ring.InteriorRadius} создан!");
            Console.WriteLine($"Сумма длинны внешнего и внутреннего равна {ring.Lenght}, а площадь {ring.Area}.");
            Console.ReadLine();

        }
    }
}
