using System;

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
            string input;
            bool flag = false;

            Console.WriteLine("Сейчас мы создадим кольцо.");
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
                Console.Write("Введи внешний радиус: ");
                input = Console.ReadLine();
                if (Int32.TryParse(input, out r_1))
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
                Console.Write("Введи внутренний радиус: ");
                input = Console.ReadLine();
                if (Int32.TryParse(input, out r_2))
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

            var ring = new Ring(x, y, r_1, r_2);

            Console.WriteLine();

            Console.WriteLine($"Отлично! Кольцо с координатами {ring.Coordinates}, внешним радиусом {ring.Radius} и внутренним радиусом {ring.InteriorRadius} создан!");
            Console.WriteLine($"Сумма длинны внешнего и внутреннего равна {ring.Lenght}, а площадь {ring.Area}.");
            Console.ReadLine();

        }
    }
}
