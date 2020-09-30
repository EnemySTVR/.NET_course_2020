using MyLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        private const string path = @"C:\Repositories\.NET_course_2020\Task12\Task1\disposable_task_file.txt";
        private static Regex isNumber = new Regex(@"\d+");
        static void Main(string[] args)
        {


            Console.WriteLine("Сейчас файл в исходном состоянии. Открой, проверь и нажми любую кнопку.");
            Console.ReadKey();

            List<string> fileContent = new List<string>();

            // Извлекаем из файла содержимое в Content.
            using (var streamReader = new StreamReader(path))
            {
                string readedRow;
                while ((readedRow = streamReader.ReadLine()) != null)
                {
                    fileContent.Add(readedRow);
                }
            }

            // Изменяем Content.
            for (int i = 0; i < fileContent.Count; i++)
            {
                var row = fileContent[i];
                ReplaceNumbersToTwoExponentation(ref row);
                fileContent[i] = row;
            }

            // Перезаписываем Content обратно в файл.
            using (var streamWriter = new StreamWriter(path, false))
            {
                foreach (var row in fileContent)
                {
                    streamWriter.WriteLine(row);
                }
            }

            Console.WriteLine("А сейчас все числа в файле возведены в квадрат. Пока.");
        }

        private static void ReplaceNumbersToTwoExponentation(ref string row)
        {
            var matches = isNumber.Matches(row).ToArray();
            var numbers = new double[matches.Length];
            for (int i = 0; i < matches.Length; i++)
            {
                numbers[i] = Int32.Parse(matches[i].Value);
            }

            var resultNumbers = numbers.Select(x => x = MyMath.Exponentiation(x, 2)).ToArray(); 

            for (int i = 0; i < matches.Length; i++)
            {
                row = row.Replace(numbers[i].ToString(), resultNumbers[i].ToString());
            }
        }
    }
}
