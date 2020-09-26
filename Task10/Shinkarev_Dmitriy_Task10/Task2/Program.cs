using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var office = new Office();

            var jon = new Employee("Jon");
            var peter = new Employee("Peter");
            var ivan = new Employee("Ivan");

            office.AddEmployee(jon);
            office.AddEmployee(peter);
            office.AddEmployee(ivan);

            office.RemoveEmployee(jon);
            office.RemoveEmployee(peter);
            office.RemoveEmployee(ivan);
        }
    }
}
