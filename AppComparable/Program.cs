using System;
using System.Collections.Generic;

namespace AppComparable
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Funcionario> lista = new List<Funcionario>();

            lista.Add(new Funcionario("Maria Brown", 4300.00));
            lista.Add(new Funcionario("Alex Green", 3100.00));
            lista.Add(new Funcionario("Bob Grey", 3100.00));
            lista.Add(new Funcionario("Anna White", 3500.00));
            lista.Add(new Funcionario("Alex Black", 2450.00));
            lista.Add(new Funcionario("Eduardo Rose", 4390.00));
            lista.Add(new Funcionario("William Red", 2900.00));
            lista.Add(new Funcionario("Marta Blue", 6100.00));
            lista.Add(new Funcionario("Alex Brown", 5000.00));

            lista.Sort();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    class Funcionario : IComparable
    {
        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public string Nome { get; set; }
        public double Salario { get; set; }

        public int CompareTo(object obj)
        {
            if (!(obj is Funcionario))
                throw new ArgumentException("Comparação inválida");
            Funcionario funcionario = obj as Funcionario;
            return Nome.CompareTo(funcionario.Nome);
        }

        public override string ToString()
        {
            return "Nome: " + Nome + ", Salário: " + Salario.ToString("F2");
        }
    }
}
