using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Instalar o pacote: Install-Package System.Text.Json -Version 4.7.1
            */

            Carro carro = new Carro() { Marca = "Fiat", Modelo = "Uno"};
            Casa casa = new Casa() { Cidade = "Vespasiano", Endereco = "MG10" };
            Usuario usuario = new Usuario() { Nome = "Flávio", CPF = "222.222.222-22", Email = "flavio@gmail.com" };

            Serializador.Serializar(carro);
            Serializador.Serializar(casa);
            Serializador.Serializar(usuario);

            Carro carro2 = Serializador.Deserializar<Carro>();
            Casa casa2 = Serializador.Deserializar<Casa>();
            Usuario usuario2 = Serializador.Deserializar<Usuario>();

            Console.WriteLine("Carro2: " + carro2.Marca + " - " + carro2.Modelo);
            Console.WriteLine("Casa2: " + casa2.Cidade + " - " + casa2.Endereco);
            Console.WriteLine("Usuario2: " + usuario2.Nome + " - " + usuario2.CPF);

            Console.ReadKey();
        }
    }
}
