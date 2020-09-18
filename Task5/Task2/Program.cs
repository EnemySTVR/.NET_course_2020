using System;
using Library;
using System.Drawing;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int x;
            int y;
            int r;

            Console.WriteLine("Сейчас мы создадим круг.");
            Console.Write("Введи расположения круга по оси X: ");
            x = CorrectInput.Number();
            Console.Write("Введи расположения круга по оси Y: ");
            y = CorrectInput.Number();
            Console.Write("Введи радиус: ");
            r = CorrectInput.PositiveNumber();
            

            var round = new Round(x, y, r);

            Console.WriteLine();

            Console.WriteLine($"Отлично! Круг с координатами {round.Coordinates} и радиусом {round.Radius} создан!");
            Console.WriteLine($"Его длинна равна {round.Lenght}, а площадь {round.Area}.");
            Console.ReadLine();
        }
    }
}
