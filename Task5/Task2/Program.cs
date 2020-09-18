using System;
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
            string input;
            bool flag = false;

            Console.WriteLine("Сейчас мы создадим круг.");
            do
            {
                Console.Write("Введи расположения круга по оси X: ");
                input = Console.ReadLine();
                if (Int32.TryParse(input, out x))
                {
                    flag = false;
                    
                }
                else
                {
                    Console.WriteLine("Это должно быть целое число.");
                    flag = true;
                }
            }
            while (flag == true);
            do
            {
                Console.Write("Введи расположения круга по оси Y: ");
                input = Console.ReadLine();
                if (Int32.TryParse(input, out y))
                {
                    flag = false;

                }
                else
                {
                    Console.WriteLine("Это должно быть целое число.");
                    flag = true;
                }
            }
            while (flag == true);
            do
            {
                Console.Write("Введи радиус: ");
                input = Console.ReadLine();
                if (Int32.TryParse(input, out r))
                {
                    flag = false;

                }
                else
                {
                    Console.WriteLine("Это должно быть целое число.");
                    flag = true;
                }
            }
            while (flag == true);

            var round = new Round(x, y, r);

            Console.WriteLine();

            Console.WriteLine($"Отлично! Круг с координатами {round.Coordinates} и радиусом {round.Radius} создан!");
            Console.WriteLine($"Его длинна равна {round.Lenght}, а площадь {round.Area}.");
            Console.ReadLine();
        }
    }
}
