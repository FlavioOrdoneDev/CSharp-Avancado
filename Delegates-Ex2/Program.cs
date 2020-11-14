using Delegates_Ex2.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Foto foto = new Foto { Nome = "foto.jpg", TamanhoX = 1920, TamanhoY = 1080 };

            // Tela - Cadastro de Usuário: Thumb (Foto de perfil)
            FotoProcessador.filtros = new FotoFiltro().GerarThumb;
            FotoProcessador.Processar(foto);

            // Tela - Cadastro de Produtos: Colorir + Redimensionar
            FotoProcessador.filtros = new FotoFiltro().Colorir;
            FotoProcessador.filtros += new FotoFiltro().Redimensionar;
            FotoProcessador.Processar(foto);

            // Tela - Cadastro de Albuns do Usuário Retro: Preto e Branco
            FotoProcessador.filtros = new FotoFiltro().PretoBranco;
            FotoProcessador.Processar(foto);

            Console.ReadKey();
        }
    }
}
