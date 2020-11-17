using AppWorker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppWorker.Entities
{
    public class Worker
    {
        public Worker() { }
        public Worker(string name, WorkerLevel level, double baseSalary)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;            
        }        

        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }

        private List<HourContract> Contracts = new List<HourContract>();

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int month, int year)
        {
            double total = BaseSalary;
            return total += Contracts.FindAll(x => x.Date.Month == month && x.Date.Year == year).Sum(x => x.TotalValue());            
        }


    }
}
