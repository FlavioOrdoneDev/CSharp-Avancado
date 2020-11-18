using System;
using System.Collections.Generic;
using System.Linq;

namespace AppAbstractTax
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(new PessoaFisica("Alex", 50000.00, 2000.00));
            pessoas.Add(new PessoaJuridica("SoftTech", 400000.00, 25));
            pessoas.Add(new PessoaFisica("Bob", 120000.00, 1000.00));


            Console.WriteLine("Taxas Pagas:");
            foreach (var item in pessoas)
            {
                Console.WriteLine(item.Nome + ": R$ " + item.CalcularImposto().ToString("F2"));
            }
            Console.WriteLine("Taxas Totais: R$ " + pessoas.Sum(x => x.CalcularImposto()));

            Console.ReadKey();
        }
    }
}
