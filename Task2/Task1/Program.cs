using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int a;
            int b;
            int result;

            Console.WriteLine("Привет! Эта программа позволяет вычислить площадь прямоугольника по его сторонам A и B.");
            Console.WriteLine("Введи длинну стороны A:");
            do
            {
                input = Console.ReadLine();
                if(Int32.TryParse(input, out a) && a < 1)
                {
                    Console.WriteLine("Ошибка! Длинна стороны прямоугольника не может быть отрицательной или равна нулю.");
                }
            }
            while (!(a > 0));

            Console.WriteLine("Введи длинну стороны B:");
            do
            {
                input = Console.ReadLine();
                if (Int32.TryParse(input, out b) && b < 1)
                {
                    Console.WriteLine("Ошибка! Длинна стороны прямоугольника не может быть отрицательной или равна нулю.");
                }
            }
            while (!(b > 0));

            result = a * b;
            Console.WriteLine($"Площадь прямоугольника при сторонах {a} и {b} равна {result}.");
            Console.ReadLine();
        }
    }
}
