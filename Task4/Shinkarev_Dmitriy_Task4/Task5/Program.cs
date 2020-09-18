using System;
using System.Text.RegularExpressions;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            
            Console.WriteLine("Введите HTML текст:");
            input = Console.ReadLine();

            var result = Regex.Replace(input, @"<[^>]*>", "_");

            Console.WriteLine($"Результат замены: {result}");
            Console.ReadLine();
        }
    }
}
