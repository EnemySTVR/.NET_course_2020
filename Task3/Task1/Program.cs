using System;
using Library;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[10];
            FillingArray.OneDimensional(array);
            Console.WriteLine("Массив случайных чисел сгенерирован:");
            OutputArray.OneDimensional(array);

            Console.WriteLine("Наибольшее число в массиве:");
            int maxValue = SearchInArray.MaxValue(array);
            Console.WriteLine(maxValue);

            Console.WriteLine("Наименьшее число в массиве:");
            int minValue = SearchInArray.MinValue(array);
            Console.WriteLine(minValue);

            Sort.BubbleSort(array);
            Console.WriteLine("Массив отсортирован:");
            OutputArray.OneDimensional(array);

            Console.ReadLine();
        }
    }
}
