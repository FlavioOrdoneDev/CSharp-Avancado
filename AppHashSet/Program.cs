using System;
using System.Collections.Generic;

namespace AppHashSet
{
    class Program
    {
        static HashSet<int> A;
        static HashSet<int> B;

        static void Main(string[] args)
        {
            A = new HashSet<int>();
            B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            //A.Remove(8);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            A.ExceptWith(B); // Diferênça entre conjuntos
            MostrarConjunto(A);

            A.UnionWith(B); // União entre conjuntos
            MostrarConjunto(A);

            A.IntersectWith(B); // O quê é igual entre os conjuntos
            MostrarConjunto(A);


            // B.Remove(4);

            VerificaPertence(4);
            VerificaPertence(7);

            Console.ReadKey();
        }

        public static void VerificaPertence(int numero)
        {
            if (B.Contains(numero))
                Console.WriteLine("Pertence: " + numero);
            else
                Console.WriteLine("Não Pertence: " + numero);
        }

        public static void MostrarConjunto(HashSet<int> conjunto)
        {
            foreach (var item in conjunto)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
