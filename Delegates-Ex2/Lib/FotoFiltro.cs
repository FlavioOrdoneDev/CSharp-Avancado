using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Ex2.Lib
{
    public class FotoFiltro
    {
        public void Colorir(Foto foto)
        {
            Console.WriteLine("FotoFiltro > Colorir");
        }

        public void GerarThumb(Foto foto)
        {
            Console.WriteLine("FotoFiltro > GerarThumb");
        }

        public void PretoBranco(Foto foto)
        {
            Console.WriteLine("FotoFiltro > PretoBranco");
        }

        public void Redimensionar(Foto foto)
        {
            Console.WriteLine("FotoFiltro > Redimensionar");
        }
    }
}
