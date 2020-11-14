using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> idade = null;
            int? idade2 = null;

            Console.WriteLine(idade.ToString(), idade2.ToString());

            Console.ReadKey();
        }
    }
}
