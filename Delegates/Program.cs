using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate int Calcula(int a, int b);

        static void Main(string[] args)
        {
            Calcula soma = new Calcula(Soma);
            Calcula sub = new Calcula(Subtrair);

            Console.WriteLine("Soma: " + soma(15, 30));
            Console.WriteLine("Subtração: " + sub(30, 15));
            
            var so = Soma(10, 20);
            var su = Subtrair(20, 10);

            Console.WriteLine("Soma: " + so);
            Console.WriteLine("Subtração: " + su);

            Console.ReadKey();
        }

        static int Soma(int a, int b)
        {
            return a + b;
        }

        static int Subtrair(int a, int b)
        {
            return a - b;
        }
    }
}
