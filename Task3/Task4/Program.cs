using Library;
using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[3, 3];

            Filling.Filling_2d_array(array);
            Console.WriteLine("Массив случайных чисел сгенерирован:");
            Output.Output_2d_array(array);
            #region Отступ.
            Console.WriteLine();
            #endregion
            Console.WriteLine($"Сумма всех элементов с четной суммой индексов равна: {Getter.Get_summ_even_index_numbers(array)}");
            Console.ReadLine();
        }
    }
}
