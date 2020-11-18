using System;
using System.Collections.Generic;
using System.Text;

namespace AppAbstractTax
{
    public class PessoaFisica : Pessoa
    {
        public PessoaFisica(string nome, double rendaAnual, double gastosComSaude)
            : base(nome, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }

        public double GastosComSaude { get; set; }

        public override double CalcularImposto()
        {
            double total = 0;

            if (RendaAnual < 20000.00)
                total += RendaAnual * 0.15;                
            else
                total += RendaAnual * 0.25;
            
            return total -= (GastosComSaude * 0.5);
        }
    }
}
