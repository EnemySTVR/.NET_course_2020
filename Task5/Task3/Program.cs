using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            string input;
            bool flag = false;

            
            Console.WriteLine("Укажите длинну сторон треугольника.");
            do
            {
                Console.Write("Сторона A:");
                input = Console.ReadLine();
                if (Int32.TryParse(input, out a))
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
                Console.Write("Сторона B:");
                input = Console.ReadLine();
                if (Int32.TryParse(input, out b))
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
                Console.Write("Сторона C:");
                input = Console.ReadLine();
                if (Int32.TryParse(input, out c))
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

            var triangle = new Triangle(a, b, c);
            Console.WriteLine();

            Console.WriteLine(triangle + $" имеет периметр {triangle.GetPerimeter()}, а его площадь равна {triangle.GetArea()}");
            Console.ReadLine();
        }
    }
}
