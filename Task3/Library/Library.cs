using System;

namespace Library
{
    public class Filling
    {
        public static void Filling_1D_array(int[] array)
        {
            var rnd = new Random();
            for (int i = 0; i < array.Length; i++) array[i] = rnd.Next(-100, 100);
        }
        public static void Filling_2d_array(int[,] array)
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
        public static void Filling_3d_array(int[,,] array)
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

    public static class Output
    {
        public static void Output_1d_array(int[] array)
        {
            foreach (var a in array) Console.Write(a + " ");
            Console.WriteLine();
        }
        public static void Output_2d_array(int[,] array)
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
        public static void Output_d3_array(int[,,] array)
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

    public static class Replace
    {
        public static void Replacement_to_zero(int[,,] array)
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
    public static class Getter
    {
        public static int Get_max_value(int[] array)
        {
            int result = array[0];
            foreach (var a in array)
            {
                if (a > result) result = a;
            }
            return result;
        }
        public static int Get_min_value(int[] array)
        {
            int result = array[0];
            foreach (var a in array)
            {
                if (a < result) result = a;
            }
            return result;
        }
        public static int Get_summ_positive_numbers(int[] array)
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
        public static int Get_summ_even_index_numbers(int[,] array)
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
