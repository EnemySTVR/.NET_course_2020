using Library;
using System;


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[3, 3, 3];

            FillingArray.ThreeDimensional(array);
            Console.WriteLine("Сгененрирован трехмерный массив:");
            OutputArray.ThreeDimensional(array);

            ReplaceArrayElement.PositiveToZero(array);
            Console.WriteLine("Все положительные элементы массива заменены на нули:");
            OutputArray.ThreeDimensional(array);
            Console.ReadLine();
        }
    }
}
