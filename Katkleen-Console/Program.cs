using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Katkleen_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var festa = new Festa();

            festa.Convidados = 12;
            festa.TipoBebida = "normal";
            festa.TipoDecoracao = "chique";
            var total = festa.ValorTotalFesta(festa);            
            Console.WriteLine("Valor total: " + total);

            Console.ReadKey();            
        }
    }
}
