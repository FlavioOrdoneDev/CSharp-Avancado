using System;
using System.Collections.Generic;
using System.Text;

namespace AppEstoque
{
    public class Produto
    {
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            if (quantidade <= 0)
                Console.WriteLine("Insira uma quantidade válida");
            else
                Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            if (Quantidade < quantidade)
                Console.WriteLine("Não será possivel remover essa quantidade");
            else
                Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return "Dados do Produto: " + Nome + ", R$ " + Preco.ToString("F2") + ", " + Quantidade + " unidades, Total: R$ " + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
