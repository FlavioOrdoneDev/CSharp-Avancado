using System;

namespace AppProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto("TV", 900.00, 20);

            produto1.Nome = "T";
            produto1.Quantidade = -50;

            Console.WriteLine(produto1);            

            produto1.AdicionarProdutos(5);
            Console.WriteLine(produto1);

            produto1.RemoverProdutos(3);
            Console.WriteLine(produto1);

            Produto produto2 = new Produto("Home Theater", 2000.00, 5);
            Console.WriteLine(produto2);

            Console.ReadKey();
        }
    }
}
