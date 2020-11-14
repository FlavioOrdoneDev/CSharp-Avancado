using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_Dynamics
{
    class Program
    {
        static void Main(string[] args)
        {
            object t1 = "";
            object t2 = 1234;
            t2 = "";

            var v1 = "";
            var v2 = 1234;
            // erro: var v3;
            // erro: v2 = "";

            Console.WriteLine("{0} {1} {2} {3} ",t1.ToString(), t2.ToString(), v1, v2.ToString());

            dynamic d1 = new Usuario() { Nome = "Flávio"};

            Console.WriteLine(d1.Nome);

            Console.ReadKey();
        }
    }

    public class Usuario
    {
        public string Nome { get; set; }
    }
}
