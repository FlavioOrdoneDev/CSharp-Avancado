

using System;
using System.IO;
using System.Text.Json;

namespace Serializacao_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Instalar o pacote: Install-Package System.Text.Json -Version 4.7.1
            */

            Usuario usuario = new Usuario() { Nome = "Joao Costa Silva", CPF = "333.333.333-33", Email = "joaosilva@gmail.com" };

            Serializar(usuario);
            Deserializar();

            Console.ReadKey();

        }

        public static void Serializar(Usuario usuario)
        {
            string UsuarioJson = JsonSerializer.Serialize(usuario);

            StreamWriter stream = new StreamWriter(@"C:\Projetos\Projetos\Cursos\Curso-de-CSharp-Avancado-Arquivos\SerializarJSON.json");

            stream.WriteLine(UsuarioJson);

            stream.Close();
        }

        public static void Deserializar()
        {
            StreamReader stream = new StreamReader(@"C:\Projetos\Projetos\Cursos\Curso-de-CSharp-Avancado-Arquivos\SerializarJSON.json");
            string usuarios = stream.ReadToEnd();

            Usuario usuario = JsonSerializer.Deserialize<Usuario>(usuarios);

            Console.WriteLine("JSON - Nome: {0}, CPF: {1}, Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);
        }
    }
}
