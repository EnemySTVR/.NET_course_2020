using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int char_count = 0;
            int word_count = 0;

            Console.WriteLine("Введи предложение из нескольких слов:");
            input = Console.ReadLine();

            var spliters = new char[] { ' ', ',', '.', ';', ':', '"', '!', '?' };
            var words = input.Split(spliters, StringSplitOptions.RemoveEmptyEntries);

            foreach(var w in words)
            {
                char_count += w.Length;
                word_count++;
            }

            var result = char_count / word_count;
            Console.WriteLine($"Среднее кол-во букв в словах этого предложения равно: {result}");
            Console.ReadLine();
        }
    }
}
