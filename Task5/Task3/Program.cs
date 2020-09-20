using Library;
using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine
                ("Укажите длинну сторон треугольника.");
            Console.Write
                ("Сторона A:");
            int a = CorrectInput.PositiveNumber();
            Console.Write
                ("Сторона B:");
            int b = CorrectInput.PositiveNumber();
            Console.Write
                ("Сторона C:");
            int c = CorrectInput.PositiveNumber();

            var triangle = new Triangle(a, b, c);
            Console.WriteLine(triangle + $" имеет периметр {triangle.GetPerimeter()}, а его площадь равна {triangle.GetArea()}");
            Console.ReadLine();
        }
    }
}
