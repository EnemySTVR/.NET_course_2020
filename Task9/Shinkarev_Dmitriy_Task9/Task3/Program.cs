using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Enter text on english:");
            string input = Console.ReadLine();

            var regex = new Regex("[A-z]+");
            var matches = regex.Matches(input);

            var words = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (var match in matches)
            {
                if (!words.ContainsKey(match.ToString()))
                {
                    words.Add(match.ToString(), 1);
                }
                else
                {
                    words[match.ToString()]++;
                }
            }

            WriteDictionary(words);

            Console.ReadLine();
        }

        static void WriteDictionary(Dictionary<string, int> pairs)
        {
            foreach (var pair in pairs)
            {
                Console.WriteLine($"Слово {pair.Key} встречается {pair.Value} раз(а).");
            }
        }
    }
}
