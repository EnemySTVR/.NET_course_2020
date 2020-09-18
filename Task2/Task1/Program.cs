using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int result;

            Console.WriteLine("Привет! Эта программа позволяет вычислить площадь прямоугольника по его сторонам A и B.");

            Console.Write("Введи длинну стороны A: ");
            a = InputCorrectValue();
            
            Console.Write("Введи длинну стороны B: ");
            b = InputCorrectValue();
            
            result = a * b;

            Console.WriteLine($"Площадь прямоугольника при сторонах {a} и {b} равна {result}.");
            Console.ReadLine();
        }

        private static int InputCorrectValue()
        {
            int result = 0;
            string input;
            do
            {
                input = Console.ReadLine();
                if (Int32.TryParse(input, out result) && result < 1)
                {
                    Console.WriteLine("Ошибка! Длинна стороны прямоугольника не может быть отрицательной или равна нулю.");
                }
            }
            while (result <= 0);
            return result;
        }
    }
}
