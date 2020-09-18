using Library;
using System;

namespace Task3
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
            Console.WriteLine($"Сумма всех положительных чисел массива равна: {Getter.Get_summ_positive_numbers(array)}");
            Console.ReadLine();
        }
    }
}
