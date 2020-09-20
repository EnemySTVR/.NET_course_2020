using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи число N (Только не слишком большое):");
            string input = Console.ReadLine();
            int n = Int32.Parse(input);
            int rowLenght = (n * 2) - 1;
            int leftPointer = rowLenght / 2;
            int rightPointer = rowLenght / 2;
            char[] row = new char[rowLenght];
            for(int i = 0; i < n; i++)
            {
                row[leftPointer] = '*';
                row[rightPointer] = '*';
                leftPointer--;
                rightPointer++;
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
