using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int n;
            int row_lenght;

            int left_pointer;
            int right_pointer;

            Console.WriteLine("Введи число N (Только не слишком большое):");
            input = Console.ReadLine();
            n = Int32.Parse(input);
            row_lenght = (n * 2) - 1;
            left_pointer = row_lenght / 2;
            right_pointer = row_lenght / 2;

            char[] row = new char[row_lenght];


            Console.WriteLine();

            for(int i = 0; i < n; i++)
            {
                row[left_pointer] = '*';
                row[right_pointer] = '*';
                left_pointer--;
                right_pointer++;
                foreach(var c in row)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
