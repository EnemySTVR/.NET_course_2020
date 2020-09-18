using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string input;

            Console.WriteLine("Введи число N (Только не слишком большое):");
            input = Console.ReadLine();
            n = Int32.Parse(input);

            Console.WriteLine();

            for(int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
