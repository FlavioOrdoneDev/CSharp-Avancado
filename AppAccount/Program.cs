using System;

namespace AppAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);

            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            // Upcasting
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.00);
            Account acc3 = new SavingsAccount(1004, "Anna", 10.0, 10.01);

            // Downcasting
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount)acc3; // Não permitido, originalmente instanciado como um SavingsAccount

            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
                Console.WriteLine(acc5.Balance);
            }

            Console.ReadKey();
        }
    }
}
