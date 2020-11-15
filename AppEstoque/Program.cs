using System;

namespace AppEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto("Sapato", 100.00, 3);
            produto1.MostrarProduto();

            produto1.AdicionarProdutos(3);
            produto1.RemoverProdutos(7);

            produto1.MostrarProduto();


            Console.ReadKey();
        }
    }
}
