using System;
using Library;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[10];

            Filling.Filling_1D_array(array);
            Console.WriteLine("Массив случайных чисел сгенерирован:");
            Output.Output_1d_array(array);
            #region Отступ.
            Console.WriteLine();
            #endregion
            Console.WriteLine("Наибольшее число в массиве:");
            Console.WriteLine(Getter.Get_max_value(array));
            #region Отступ.
            Console.WriteLine();
            #endregion
            Console.WriteLine("Наименьшее число в массиве:");
            Console.WriteLine(Getter.Get_min_value(array));
            #region Отступ.
            Console.WriteLine();
            #endregion
            Sort.BubbleSort(array);
            Console.WriteLine("Массив отсортирован:");
            Output.Output_1d_array(array);

            Console.ReadLine();
        }
    }
}
