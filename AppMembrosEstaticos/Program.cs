using System;

namespace AppMembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = 3.00;

            double circunferencia = Calculadora.CalcularCircunferencia(raio);
            Console.WriteLine("Circunferência: " + circunferencia);

            double volume = Calculadora.CalcularVolume(raio);
            Console.WriteLine("Volume: " + volume.ToString("F2"));

            Console.WriteLine("Valor de Pi: " + Calculadora.Pi);

            Console.ReadKey();
        }        
    }
}
