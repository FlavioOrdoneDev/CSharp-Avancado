using System;

namespace AppVetores
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] vect = new double[3];

            vect[0] = 1.72;
            vect[1] = 1.56;
            vect[2] = 1.80;

            double aux = 0;

            for (int i = 0; i < vect.Length; i++)
            {
                aux += vect[i];
            }

            var resultado = aux / vect.Length;

            Console.WriteLine(resultado.ToString("F2"));
            
            Console.WriteLine("------------------------");

            Produto p1 = new Produto("TV", 900.00);
            Produto p2 = new Produto("Fryer", 400.00);
            Produto p3 = new Produto("Stove", 800.00);

            Produto[] produtos = new Produto[3];

            produtos[0] = p1;
            produtos[1] = p2;
            produtos[2] = p3;

            aux = 0;

            for (int i = 0; i < produtos.Length; i++)
            {
                aux += produtos[i].Preco;
            }

            var media = aux / produtos.Length;

            Console.WriteLine(media.ToString("F2"));

            Console.ReadKey();
        }
    }
}
