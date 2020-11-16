using System;
using System.Collections.Generic;
using System.Text;

namespace AppProduto
{
    public class Produto
    {
        public Produto() { }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            _preco = preco;
            Quantidade = 0;
        }

        public Produto(string nome, double preco, int quantidade)
            : this(nome, preco)
        {            
            Quantidade = quantidade;
        }

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }

        private double _preco;
        public double Preco
        {
            get { return _preco; }
            private set { _preco = value; }
        }

        private int _quantidade;
        public int Quantidade
        {
            get { return _quantidade; }
            set 
            {
                if (value >= 0)
                   _quantidade = value;
            }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            if (quantidade <= 0)
                Console.WriteLine("Insira uma quantidade válida");
            else
                _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            if (_quantidade < quantidade)
                Console.WriteLine("Não será possivel remover essa quantidade");
            else
                _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return "Dados do Produto: " + Nome + ", R$ " + Preco.ToString("F2") + ", " + Quantidade + " unidades, Total: R$ " + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
