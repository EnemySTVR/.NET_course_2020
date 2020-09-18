using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region properties
            string input;
            int n;
            int row_lenght;

            int left_pointer;
            int right_pointer;

            int counter = 1;
            #endregion
            #region input
            Console.WriteLine("Введи число N (Только не слишком большое):");
            input = Console.ReadLine();
            n = Int32.Parse(input);
            #endregion
            row_lenght = (n * 2) + 1;
            left_pointer = row_lenght / 2;
            right_pointer = row_lenght / 2;

            char[] array = new char[row_lenght];
            
            for(int i = 0; i <= n; i++)
            {
                for (int l = 0; l < row_lenght; l++) array[l] = ' ';

                for (int j = 0; j < counter; j++)
                {
                    array[left_pointer] = '*';
                    array[right_pointer] = '*';
                    left_pointer--;
                    right_pointer++;
                    foreach (var c in array) Console.Write(c);
                    Console.WriteLine();
                }
                left_pointer = row_lenght / 2;
                right_pointer = row_lenght / 2;
                counter++;
            }
            
            Console.ReadLine();
        }
    }
}
