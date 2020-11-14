using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Autor> ListaAutores = new List<Autor>();
            List<Livro> listaLivros = new List<Livro>();

            listaLivros.Add(new Livro() { Id = 1, AutorId = 2, Titulo = "Use a cabeça C#", AnoPublicacao = "2000" });
            listaLivros.Add(new Livro() { Id = 2, AutorId = 1, Titulo = "Código limpo", AnoPublicacao = "2001" });
            listaLivros.Add(new Livro() { Id = 3, AutorId = 2, Titulo = "Domain driven", AnoPublicacao = "2002" });
            listaLivros.Add(new Livro() { Id = 4, AutorId = 3, Titulo = "Javascript completo", AnoPublicacao = "2013" });
            listaLivros.Add(new Livro() { Id = 5, AutorId = 1, Titulo = "Aprenda C# 2019", AnoPublicacao = "2019" });

            ListaAutores.Add(new Autor() { Id = 1, Nome = "Robert C. Martin" });
            ListaAutores.Add(new Autor() { Id = 2, Nome = "Uncle Bob" });
            ListaAutores.Add(new Autor() { Id = 3, Nome = "Loiane Groner" });

            var listaFiltrada = from livros in listaLivros join autor in ListaAutores on livros.AutorId equals autor.Id select new { livros, autor };

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine("livro: " + item.livros.Titulo + " - Autor: " + item.autor.Nome);
            }

            Console.ReadKey();

        }
    }
}
