using System;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread = new Thread(Class1.MethodWithAction);
            thread.Start();
            
            Thread.Join
        }

        
    }
}
