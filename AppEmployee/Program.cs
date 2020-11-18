using System;
using System.Collections.Generic;

namespace AppEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Employee e1 = new Employee("Alex", 50, 20.00);
            Employee e2 = new Employee("Maria", 60, 20.00);
            OutsourcedEmployee et = new OutsourcedEmployee("Bob", 100, 15.00, 200.00);

            list.Add(e1);
            list.Add(e2);
            list.Add(et);

            foreach (var item in list)
            {
                Console.WriteLine("Name: " + item.Name + ", Payment: " + item.Payment().ToString("F2"));
            }

            Console.ReadKey();
        }
    }
}
