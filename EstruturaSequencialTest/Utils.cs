using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EstruturaSequencialTest
{
    public static class Utils
    {

        public static int SomaValores(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static string CalcularAreaCirculo(double valor)
        {
            double resultado;

            resultado = 3.14159 * (valor * valor);

            return resultado.ToString("F4", CultureInfo.InvariantCulture);
        }

        public static double CalcularDiferencaDosProdutos(int a, int b, int c, int d)
        {
            return (a * b) - (c * d);
        }

        public static Funcionario InfoFuncionario(int codigo, int horasTrabalhadas, double valorPorHora)
        {
            return new Funcionario(codigo, horasTrabalhadas, valorPorHora);
        }
    }
}
