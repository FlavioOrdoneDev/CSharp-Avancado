using System;
using System.Collections.Generic;
using System.Globalization;

namespace AppList_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionário deseja registrar? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionário #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Entre com o id do funcionário para aumentar seu salário: ");
            int searchId = int.Parse(Console.ReadLine());

            Funcionario emp = lista.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Este id não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Atualizada lista de funcionários:");
            foreach (Funcionario obj in lista)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();
        }
    }
}
