using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    delegate void GreetingNewEmployeeDelegate(Employee employee, DateTime arrivalTime);
    delegate void PartingEmployeeDelegate(Employee employee);
    class Office
    {
        // Хз зачем. Возможно, потребуется получить список сотрудников на работе
        // или что-то с ними делать.
        private LinkedList<Employee> _employees = new LinkedList<Employee>();
        GreetingNewEmployeeDelegate GreetingNewEmployee = null;
        PartingEmployeeDelegate PartingEmployee = null;

        public void AddEmployee(Employee employee)
        {
            Console.WriteLine($"[{employee.Name} пришёл на работу]");
            if (_employees.Count > 0)
            {
                GreetingNewEmployee(employee, DateTime.Now);
            }
            GreetingNewEmployee += employee.Greeting;
            PartingEmployee += employee.Parting;
            _employees.AddLast(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            Console.WriteLine($"[{employee.Name} ушёл с работы]");
            GreetingNewEmployee -= employee.Greeting;
            PartingEmployee -= employee.Parting;
            _employees.Remove(employee);
            if (_employees.Count > 0)
            {
                PartingEmployee(employee);
            }
        }

    }
}
