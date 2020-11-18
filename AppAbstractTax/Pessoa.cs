using System;
using System.Collections.Generic;
using System.Text;

namespace AppAbstractTax
{
    public abstract class Pessoa
    {
        protected Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public string Nome { get; set; }
        public double RendaAnual { get; set; }  

        public abstract double CalcularImposto();
    }
}
