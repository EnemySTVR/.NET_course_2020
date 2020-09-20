using Library;
using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[3, 3];
            FillingArray.TwoDimensional(array);
            Console.WriteLine("Массив случайных чисел сгенерирован:");
            OutputArray.TwoDimensional(array);

            int result = SearchInArray.SummEvenIndexElements(array);
            Console.WriteLine($"Сумма всех элементов с четной суммой индексов равна: {result}");
            Console.ReadLine();
        }
    }
}
