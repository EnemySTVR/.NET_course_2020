using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи число N (Только не слишком большое):");
            int n = Int32.Parse(Console.ReadLine());
            int rowLenght = (n * 2) + 1;
            int leftPointer = rowLenght / 2;
            int rightPointer = rowLenght / 2;
            char[] row = new char[rowLenght];
            int counter = 1;
            for (int i = 0; i <= n; i++)
            {
                Array.Clear(row, 0, row.Length);

                for (int j = 0; j < counter; j++)
                {
                    row[leftPointer] = '*';
                    row[rightPointer] = '*';
                    leftPointer--;
                    rightPointer++;
                    foreach (var c in row) Console.Write(c);
                    Console.WriteLine();
                }
                leftPointer = rowLenght / 2;
                rightPointer = rowLenght / 2;
                counter++;
            }
            Console.ReadLine();
        }
    }
}
