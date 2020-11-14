using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

            var listaFiltrada = lista.Where(l => l > 10).OrderBy(l => l).Select(l => l);
            var listaFiltradaFrom = from a in lista where a > 10 orderby a descending select a;

            foreach (var item in listaFiltrada)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            foreach (var item in listaFiltradaFrom)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
