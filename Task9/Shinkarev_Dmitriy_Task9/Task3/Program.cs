using System;
using System.Collections.Generic;
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

            var wordCounter = new Dictionary<string, int>();

            foreach (var match in matches)
            {
                // ContainsKey чувствителен к регистру.
                // Я напишу свой ContainsKey с игнором регистра ̶и̶ ̶к̶у̶р̶т̶и̶з̶а̶н̶к̶а̶м̶и̶.
                string overlapKey;
                if (!ContainsKeyWithIgnoreRegister(wordCounter, match.ToString(), out overlapKey))
                {
                    wordCounter.Add(match.ToString(), 1);
                }
                else
                {
                    wordCounter[overlapKey]++;
                }
            }

            WriteDictionary(wordCounter);

            Console.ReadLine();
        }

        static bool ContainsKeyWithIgnoreRegister(Dictionary<string, int> dictionary, string searchKey, out string outKey)
        {
            foreach (var pair in dictionary)
            {
                if (pair.Key.ToLower().Equals(searchKey.ToLower()))
                {
                    outKey = pair.Key;
                    return true;
                }
            }

            outKey = "";
            return false;
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
