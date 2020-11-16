using System;

namespace AppProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto("TV", 900.00, 10);
            Console.WriteLine(produto1);

            produto1.AdicionarProdutos(5);
            Console.WriteLine(produto1);

            produto1.RemoverProdutos(3);
            Console.WriteLine(produto1);

            Console.ReadKey();
        }
    }
}
