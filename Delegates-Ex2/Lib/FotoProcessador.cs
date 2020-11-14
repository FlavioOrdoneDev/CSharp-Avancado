using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Ex2.Lib
{
    public class FotoProcessador
    {
        public delegate void FotoFiltroHandler(Foto foto);

        public static FotoFiltroHandler filtros;

        public static void Processar(Foto foto)
        {
            filtros(foto);
        }
    }
}
