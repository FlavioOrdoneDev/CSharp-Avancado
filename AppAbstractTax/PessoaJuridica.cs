using System;
using System.Collections.Generic;
using System.Text;

namespace AppAbstractTax
{
    public class PessoaJuridica : Pessoa
    {
        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios)
         : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public int NumeroFuncionarios { get; set; }

        public override double CalcularImposto()
        {
            if (NumeroFuncionarios > 10)
                return RendaAnual * 0.14;
            else
                return RendaAnual * 0.16;
        }
    }
}
