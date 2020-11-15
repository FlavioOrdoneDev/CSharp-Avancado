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
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            if (Quantidade < quantidade)
                Console.WriteLine("Não será possivel remover essa quantidade");
            else
                Quantidade -= quantidade;
        }

        public void MostrarProduto()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Preco: " + Preco);
            Console.WriteLine("Quantidade: " + Quantidade);
            Console.WriteLine("Valor total em estoque: " + ValorTotalEmEstoque());

        }
    }
}
