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

        public static double CalcularDiferencaDosProdutos(int a, int b, int c, int d)
        {
            return (a * b) - (c * d);
        }

        public static Funcionario InfoFuncionario(int codigo, int horasTrabalhadas, double valorPorHora)
        {
            return new Funcionario(codigo, horasTrabalhadas, valorPorHora);
        }

        public static double SomaTotalDeItens(int qtde1, int qtde2, double preco1, double preco2)
        {
            return qtde1 * preco1 + qtde2 * preco2;
        }

        public static double CalcularAreaTriangulo(double a, double b)
        {
            return (a * b) / 2;            
        }

        public static double CalcularAreaTrapezio(double a, double b, double h)
        {
            return ((a + b) / 2) * h;
        }

        public static double CalcularAreaCirculo(double valor)
        {
            return 3.14159 * (valor * valor);
        }

        public static double CalcularAreaQuadrado(double valor)
        {
            return valor * valor;
        }

        public static double CalcularAreaRetangulo(double a, double b)
        {
            return a * b;
        }


    }
}
