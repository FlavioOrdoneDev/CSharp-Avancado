using System.IO;

namespace Files_Example2
{
    public class Flobbo
    {
        private string Zap;
        public Flobbo(string zap)
        {
            this.Zap = zap;
        }

        public StreamWriter Snobbo()
        {
            return new StreamWriter(@"C:\Projetos\Projetos\Cursos\Curso-de-CSharp-Avancado-Arquivos\macaw.txt");
        }

        public bool Blobbo(StreamWriter sw)
        {
            sw.WriteLine(Zap);
            Zap = "green purple";
            return false;
        }

        public bool Blobbo(bool Already, StreamWriter sw)
        {

            if (Already)
            {
                sw.WriteLine(Zap);
                sw.Close();
                return false;
            }
            else
            {
                sw.WriteLine(Zap);
                Zap = "red orange";
                return true;
            }
        }

        

        

    }
}