using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> usuarios = new List<Usuario>();

            usuarios.Add(new Usuario() { Nome = "Flávio", Email = "flavio@gmail.com"});
            usuarios.Add(new Usuario() { Nome = "Heloisa", Email = "heloisa@gmail.com" });
            usuarios.Add(new Usuario() { Nome = "Fernanda", Email = "fernanda@hotmail.com" });
            usuarios.Add(new Usuario() { Nome = "Geovana", Email = "geovana@gmail.com" });
            usuarios.Add(new Usuario() { Nome = "Jade", Email = "jade@hotmail.com" });

            var usuariosFiltrados = usuarios.Where(u => u.Email.Contains("@gmail.com")).OrderByDescending(u => u.Nome).Select(u => u);

            foreach (var usuario in usuariosFiltrados)
            {
                Console.WriteLine(usuario.Nome + " - " + usuario.Email);
            }

            Console.ReadKey();
        }
    }
}
