using System;

namespace AppParams
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = Calculadora.Somar(2, 3, 4);
            Console.WriteLine(total);

            Console.WriteLine("---------------------");

            int a = 10;
            Calculadora.Triplicar(ref a);
            Console.WriteLine(a);

            Console.WriteLine("---------------------");

            int b = 20;
            int triplo;
            Calculadora.Triplicar(b, out triplo);
            Console.WriteLine(triplo);

            Console.WriteLine("---------------------");

            int d = 10;
            int retorno;
            int f = 10;
            var res = Calculadora.Triplicar(d, f, out retorno);
            Console.WriteLine(retorno);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
