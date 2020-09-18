using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int result = 0;
            int count = 0;

            Console.WriteLine("Введи предложение из нескольких слов:");
            input = Console.ReadLine();

            var spliters = new char[] { ' ', ',', '.', ';', ':', '"', '!', '?' };
            var words = input.Split(spliters, StringSplitOptions.RemoveEmptyEntries);
            foreach(var w in words)
            {
                result += w.Length;
                count++;
            }

            Console.WriteLine($"Среднее кол-во букв в словах этого предложения равно: {result / count}");
            Console.ReadLine();
        }
    }
}
