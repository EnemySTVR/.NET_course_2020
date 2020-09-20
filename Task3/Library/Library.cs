using System;

namespace Library
{
    public class FillingArray
    {
        public static void OneDimensional(int[] array)
        {
            var random = new Random();
            for (int i = 0; i < array.Length; i++) array[i] = random.Next(-100, 100);
        }
        public static void TwoDimensional(int[,] array)
        {
            var rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-100, 100);
                }
            }
        }
        public static void ThreeDimensional(int[,,] array)
        {
            var rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int l = 0; l < array.GetLength(2); l++)
                    {
                        array[i, j, l] = rnd.Next(-100, 100);
                    }
                }
            }
        }
    }


    public static class OutputArray
    {
        public static void OneDimensional(int[] array)
        {
            foreach (var a in array) Console.Write(a + " ");
            Console.WriteLine();
        }
        public static void TwoDimensional(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void ThreeDimensional(int[,,] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i != 0)
                {
                    Console.WriteLine("=========");
                }
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int l = 0; l < array.GetLength(2); l++)
                    {
                        Console.Write(array[i, j, l] + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }

    public static class ReplaceArrayElement
    {
        public static void PositiveToZero(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int l = 0; l < array.GetLength(2); l++)
                    {
                        if (array[i, j, l] > 0)
                        {
                            array[i, j, l] = 0;
                        }
                    }
                }
            }
        }
    }
    public static class SearchInArray
    {
        public static int MaxValue(int[] array)
        {
            int result = array[0];
            foreach (var a in array)
            {
                if (a > result) result = a;
            }
            return result;
        }
        public static int MinValue(int[] array)
        {
            int result = array[0];
            foreach (var a in array)
            {
                if (a < result) result = a;
            }
            return result;
        }
        public static int SummPositiveNumbers(int[] array)
        {
            int result = 0;
            foreach (var a in array)
            {
                if (a > 0)
                {
                    result += a;
                }
            }
            return result;
        }
        public static int SummEvenIndexElements(int[,] array)
        {
            int result = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        result += array[i, j];
                    }
                }
            }
            result -= array[0, 0];
            return result;
        }

    }
    public static class Sort
    {
        public static void BubbleSort(int[] array)
        {
                int temp;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] > array[i + 1])
                        {
                            temp = array[i + 1];
                            array[i + 1] = array[i];
                            array[i] = temp;
                        }
                    }
                } 
        }
    }
}
