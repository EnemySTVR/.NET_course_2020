using Library;
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
            
            Console.WriteLine("Укажите длинну сторон треугольника.");
            Console.Write("Сторона A:");
            a = CorrectInput.PositiveNumber();
            Console.Write("Сторона B:");
            b = CorrectInput.PositiveNumber();
            Console.Write("Сторона C:");
            c = CorrectInput.PositiveNumber();

            var triangle = new Triangle(a, b, c);
            Console.WriteLine();

            Console.WriteLine(triangle + $" имеет периметр {triangle.GetPerimeter()}, а его площадь равна {triangle.GetArea()}");
            Console.ReadLine();
        }
    }
}
