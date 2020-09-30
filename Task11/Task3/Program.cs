using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var point1 = new TwoDPoint(1, 10);
            var point2 = new TwoDPoint(10, 1);

            Console.WriteLine($"hach code point1: {point1.GetHashCode()}");
            Console.WriteLine($"hach code point2: {point2.GetHashCode()}");
            Console.ReadKey();
        }
    }
}
