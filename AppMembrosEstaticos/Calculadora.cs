using System;
using System.Collections.Generic;
using System.Text;

namespace AppMembrosEstaticos
{
    public class Calculadora
    {
        public static double Pi = 3.14;

        public static double CalcularCircunferencia(double raio)
        {
            return 2 * Pi * raio;
        }

        public static double CalcularVolume(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3.0);
        }
    }
}
