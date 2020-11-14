using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"C:\Projetos\Projetos\Cursos\Curso-de-CSharp-Avancado-Arquivos\secret_plan.txt");

            StreamWriter writer = new StreamWriter(@"C:\Projetos\Projetos\Cursos\Curso-de-CSharp-Avancado-Arquivos\emailToCaptainAmazing.txt");

            writer.WriteLine("To: CaptainAmazing@objectville.net");
            writer.WriteLine("From: Commissioner@objectville.net");
            writer.WriteLine("Subject: Can you save the day... again?");
            writer.WriteLine();
            writer.WriteLine("We've discovered the Swindler's plan:");
            while (!reader.EndOfStream)
            {
                string lineFromThePlan = reader.ReadLine();
                writer.WriteLine("The plan -> " + lineFromThePlan);
                Console.WriteLine("The plan -> " + lineFromThePlan);
            }

            writer.WriteLine();
            writer.WriteLine("Can you help us?");
            writer.Close();
            reader.Close();

            Console.ReadKey();
        }
    }
}
