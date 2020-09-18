using Library;
using System;


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var _3d_array = new int[3, 3, 3];

            Filling.Filling_3d_array(_3d_array);
            Console.WriteLine("Сгененрирован трехмерный массив:");
            Output.Output_d3_array(_3d_array);

            Replace.Replacement_to_zero(_3d_array);
            Console.WriteLine("Все положительные элементы массива заменены на нули:");
            Output.Output_d3_array(_3d_array);
            Console.ReadLine();
        }
    }
}
