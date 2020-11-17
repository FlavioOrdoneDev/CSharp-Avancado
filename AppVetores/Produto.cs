using System;
using System.Collections.Generic;
using System.Text;

namespace AppVetores
{
    public class Produto
    {
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public string Nome { get; set; }
        public double Preco { get; set; }

    }
}
