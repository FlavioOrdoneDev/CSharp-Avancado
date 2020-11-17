using System;
using System.Collections.Generic;
using System.Text;

namespace AppParams
{
    class Calculadora
    {

        public static double Somar(params double[] numeros)
        {
            double total = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                total += numeros[i];
            }

            return total;
        }

        public static void Triplicar(ref int x)
        {
            x = x * 3;
        }

        public static void Triplicar(int x, out int resultado)
        {
            resultado = x * 3;
        }

        public static double Triplicar(int x,int z, out int resultado)
        {
            resultado = x * 3;
            return x * z;
        }
    }
}
