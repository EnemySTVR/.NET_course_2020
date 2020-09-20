using Library;
using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[10];
            FillingArray.OneDimensional(array);
            Console.WriteLine
                ("Массив случайных чисел сгенерирован:");
            OutputArray.OneDimensional(array);

            int result = SearchInArray.SummPositiveNumbers(array);
            Console.WriteLine
                ($"Сумма всех не отрицательных чисел массива равна: {result}");
            Console.ReadLine();
        }
    }
}
