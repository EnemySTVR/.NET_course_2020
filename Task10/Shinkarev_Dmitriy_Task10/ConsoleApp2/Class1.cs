using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    static class Class1
    {
        public static event Action myAction;

        public static void MethodWithAction()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("*");
            }
        }
    }
}
