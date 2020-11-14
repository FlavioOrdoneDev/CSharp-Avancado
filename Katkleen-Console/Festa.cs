using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katkleen_Console
{
    public class Festa
    {
        private decimal ValorPorConvidado = 25;
        public int Convidados { get; set; }        
        public string TipoBebida { get; set; }
        public string TipoDecoracao { get; set; }

        private decimal bebidas;
        public decimal Bebidas
        {
            get
            {
                return bebidas;
            }
            set
            {
                if (TipoBebida == "saudavel")
                {
                    bebidas = 5M;
                }
                else
                {
                    bebidas = 20M;
                }
            }
        }


        private decimal custoDecoracao;
        public decimal CustoDecoracao
        {
            get 
            { 
                return custoDecoracao; 
            }
            set 
            { 
                if (TipoDecoracao == "normal")
                {
                    custoDecoracao = (this.Convidados * 7.50M) + 30M;
                }
                else
                {
                    custoDecoracao = (this.Convidados * 15) + 50M;
                }
            }
        }

        public decimal ValorTotalFesta(Festa festa)
        {
            decimal total;
            this.Bebidas = 1;
            this.CustoDecoracao = 1;

            total = custoDecoracao + (( ValorPorConvidado + bebidas) * festa.Convidados);

            if (TipoBebida == "saudavel")
            {
                return total * .95M;
            }
            else
            {
                return total;
            }
        }
    }
}
