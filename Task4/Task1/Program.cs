using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine
                ("Введи предложение из нескольких слов:");
            string input = Console.ReadLine();

            var spliters = new char[] 
                { ' ', ',', '.', ';', ':', '"', '!', '?' };
            var words = input.Split(spliters, StringSplitOptions.RemoveEmptyEntries);
            int charCount = 0;
            int wordCount = 0;
            foreach (var w in words)
            {
                charCount += w.Length;
                wordCount++;
            }
            var result = charCount / wordCount;
            Console.WriteLine
                ($"Среднее кол-во букв в словах этого предложения равно: {result}");
            Console.ReadLine();
        }
    }
}
