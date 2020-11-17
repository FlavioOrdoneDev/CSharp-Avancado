using System;
using System.Collections.Generic;

namespace AppList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> lista = new List<string>();

            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Bob");
            lista.Add("Anna");
            lista.Insert(2, "Marco"); // Inserir no indice 2

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            string s1 = lista.Find(x => x[0] == 'A');  // Find - Encontrar o primeiro que começa com a letra 'A'
            Console.WriteLine("Primeiro 'A': " + s1);

            string s2 = lista.FindLast(x => x[0] == 'A'); // FindLast - Encontrar o último que começa com a letra 'A'
            Console.WriteLine("Último 'A': " + s2);

            int pos1 = lista.FindIndex(x => x[0] == 'A'); // FindIndex - Encontrar o primeiro índice que começa com a letra 'A'
            Console.WriteLine("Primeiro Índice 'A': " + pos1);

            int pos2 = lista.FindLastIndex(x => x[0] == 'A'); // FindLastIndex - Encontrar o último índice que começa com a letra 'A'
            Console.WriteLine("Último Índice 'A': " + pos2);



            Console.WriteLine("---------------------------------");

            List<string> lista2 = lista.FindAll(x => x.Length == 5); // FindAll - Encontrar todos com o nome contendo 5 caracteres

            foreach (var item in lista2)
            {
                Console.WriteLine("Nome: " + item);
            }

            Console.WriteLine("---------------------------------");

            lista.Remove("Alex");
            foreach (var item in lista)
            {
                Console.WriteLine("Nome: " + item);
            }

            Console.WriteLine("---------------------------------");

            lista.RemoveAll(x => x[0] == 'M'); // RemoveAll - Remove todos que começam com a letra 'M'
            foreach (var item in lista)
            {
                Console.WriteLine("Nome: " + item);
            }

            Console.WriteLine("---------------------------------");

            lista.RemoveAt(1); // RemoveAt - Remove em determinado índice (1)
            foreach (var item in lista)
            {
                Console.WriteLine("Nome: " + item);
            }

            lista.RemoveAt(0);

            Console.WriteLine("---------------------------------");

            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Bob");
            lista.Add("Anna");

            lista.RemoveRange(1, 2); // RemoveRange - Remove apartir do índice 1, 2 posições 

            foreach (var item in lista)
            {
                Console.WriteLine("Nome: " + item);
            }

            Console.ReadKey();
        }
    }
}
