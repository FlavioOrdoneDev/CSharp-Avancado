
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace Serializacao_XML
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Usuario usuario = new Usuario() { Nome = "José Costa Silva", CPF = "222.222.222-22", Email = "josesilva@gmail.com" };


            Serializar(usuario);

            usuario = Deserializar();

            Console.WriteLine("Nome: {0}, CPF: {1}, Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);
            Console.ReadKey();
            
        }

        

        public static void Serializar(Usuario usuario)
        {
            StreamWriter stream = new StreamWriter(@"C:\Projetos\Projetos\Cursos\Curso-de-CSharp-Avancado-Arquivos\SerializarXML.xml");

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

            serializador.Serialize(stream, usuario);

            stream.Close();
        }

        public static Usuario Deserializar()
        {
            StreamReader stream = new StreamReader(@"C:\Projetos\Projetos\Cursos\Curso-de-CSharp-Avancado-Arquivos\SerializarXML.xml");

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

           return (Usuario)serializador.Deserialize(stream); 
        }


    }
}
