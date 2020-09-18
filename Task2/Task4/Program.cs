using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region properties
            
            int n;
            int row_lenght;

            int left_pointer;
            int right_pointer;

            int counter = 1;
            #endregion

            Console.WriteLine("Введи число N (Только не слишком большое):");
            n = Int32.Parse(Console.ReadLine());
            row_lenght = (n * 2) + 1;
            left_pointer = row_lenght / 2;
            right_pointer = row_lenght / 2;

            char[] row = new char[row_lenght];
            
            for(int i = 0; i <= n; i++)
            {
                Array.Clear(row, 0, row.Length);

                for (int j = 0; j < counter; j++)
                {
                    row[left_pointer] = '*';
                    row[right_pointer] = '*';
                    left_pointer--;
                    right_pointer++;
                    foreach (var c in row) Console.Write(c);
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
