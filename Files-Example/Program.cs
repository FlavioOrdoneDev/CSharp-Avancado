using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteFile();
            ReadFile();

            Console.ReadKey();
        }

        public static void WriteFile()
        {
            StreamWriter sw = new StreamWriter(@"C:\Projetos\Projetos\Cursos\Curso-de-CSharp-Avancado-Arquivos\secret_plan.txt");

            sw.WriteLine("How I'll defeat Captain Amazing");
            sw.WriteLine("Another genius secret plan by the Swindler");
            sw.Write("I'll create an army of clones and ");
            sw.WriteLine("unleash then upon the citzens of objectville.");

            string location = "the mall";

            for (int number = 0; number <= 6; number++)
            {
                sw.WriteLine("Clone #{0} attacks {1}", number, location);
                if (location == "the mall")
                    location = "downtown";
                else
                    location = "the mall";
            }

            sw.Close();
        }

        public static void ReadFile()
        {
            StreamReader sr = new StreamReader(@"C:\Projetos\Projetos\Cursos\Curso-de-CSharp-Avancado-Arquivos\secret_plan.txt");

            string texto = sr.ReadToEnd();
            Console.WriteLine(texto);
        }
    }
}
