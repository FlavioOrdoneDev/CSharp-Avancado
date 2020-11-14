using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_GroupBy_Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listaNumeros = { 1, 1, 1, 1, 4, 4, 4, 4, 2, 3, 5, 6, 6, 10, 9, 8 };

            var listaDistinct = listaNumeros.Distinct().OrderBy(n => n);
            var listaGroupBy = listaNumeros.OrderBy(n => n).GroupBy(n => n).Select(n => n); 

            foreach (var item in listaDistinct)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            foreach (var item in listaGroupBy)
            {
                Console.Write(item.Key + " ");
            }

            Console.ReadKey();
        }
    }
}
