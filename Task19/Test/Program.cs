using System;
using System.Collections.Generic;
using System.Threading;

namespace Test
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int counter = 0;
            foreach (var i in GetList())
            {
                if (counter == 3)
                {
                    break;
                }
                Console.WriteLine(i);
                counter++;
            }
            foreach (var i in GetList())
            {
                Console.WriteLine(i);
            }
        }

        static IEnumerable<int> GetList()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }

        
        

        // lazy evaluation of collection
    }
}
