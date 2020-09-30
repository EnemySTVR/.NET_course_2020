using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи предложение из нескольких слов:");
            string input = Console.ReadLine();

            var spliters = new char[] { ' ', ',', '.', ';', ':', '"', '!', '?' };
            var words = input.Split(spliters, StringSplitOptions.RemoveEmptyEntries);
            double charCount = 0.0;
            double wordCount = 0.0;
            foreach (var word in words)
            {
                charCount += word.Length;
                wordCount++;
            }
            var result = charCount / wordCount;
            Console.WriteLine($"Среднее кол-во букв в словах этого предложения равно: {result}");
            Console.ReadLine();
        }
    }
}
