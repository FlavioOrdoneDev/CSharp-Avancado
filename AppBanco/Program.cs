using System;

namespace AppBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta(8532, "Alex Green", 200.00);
            Console.WriteLine(c1);

            c1.Depositar(200);
            Console.WriteLine(c1);

            c1.Sacar(400);
            Console.WriteLine(c1);

            Console.ReadKey();
        }
    }
}
