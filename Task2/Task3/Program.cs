using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int n;
            int lenght;

            int left_pointer;
            int right_pointer;

            Console.WriteLine("Введи число N (Только не слишком большое):");
            input = Console.ReadLine();
            n = Int32.Parse(input);
            lenght = (n * 2) - 1;
            left_pointer = lenght / 2;
            right_pointer = lenght / 2;

            char[] array = new char[lenght];
            for(int i = 0; i < lenght; i++)
            {
                array[i] = ' ';
            }

            Console.WriteLine();

            for(int i = 0; i < n; i++)
            {
                array[left_pointer] = '*';
                array[right_pointer] = '*';
                left_pointer--;
                right_pointer++;
                foreach(var c in array)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
