using AppWorker.Entities;
using AppWorker.Enums;
using System;

namespace AppWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department { Name = "Design"};

            Worker worker = new Worker("Alex", WorkerLevel.MidLevel, 1200.00);
            worker.Department = department;

            HourContract contract1 = new HourContract(DateTime.Parse("20/08/2018"), 50.00, 20);
            HourContract contract2 = new HourContract(DateTime.Parse("13/06/2018"), 30.00, 18);
            HourContract contract3 = new HourContract(DateTime.Parse("25/08/2018"), 80.00, 10);

            worker.AddContract(contract1);
            worker.AddContract(contract2);
            worker.AddContract(contract3);

            int day = 08;
            int year = 2018;

            var total = worker.Income(day, year);

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + day + "/" + year + ": " + total);
            Console.WriteLine("Base Salary: " + worker.BaseSalary);


            Console.WriteLine("-------------------------------------");


            Department department2 = new Department { Name = "TI" };

            Worker worker2 = new Worker("Flávio", WorkerLevel.Senior, 3000.00);
            worker2.Department = department2;

            HourContract contract4 = new HourContract(DateTime.Parse("20/08/2020"), 100.00, 20);
            HourContract contract5 = new HourContract(DateTime.Parse("13/06/2020"), 130.00, 18);
            HourContract contract6 = new HourContract(DateTime.Parse("25/08/2020"), 200.00, 10);

            worker2.AddContract(contract4);
            worker2.AddContract(contract5);
            worker2.AddContract(contract6);

            day = 08;
            year = 2020;

            total = worker2.Income(day, year);

            Console.WriteLine("Name: " + worker2.Name);
            Console.WriteLine("Department: " + worker2.Department.Name);
            Console.WriteLine("Income for " + day + "/" + year + ": " + total);
            Console.WriteLine("Base Salary: " + worker2.BaseSalary);


            Console.ReadKey();
        }
    }
}
