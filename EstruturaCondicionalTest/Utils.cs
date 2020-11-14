using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstruturaCondicionalTest
{
    public static class Utils
    {
        public static string VerificaNegativoOuNaoNegativo(int numero)
        {
            if (numero < 0)
                return "Negativo";
            else
                return "Nao Negativo";
        }

        public static string VerificaParOuImpar(int numero)
        {
            if (numero % 2 == 0)
                return "Par";
            else
                return "Impar";
        }

        public static string VerificaSeSaoMultiplos(int numero1, int numero2)
        {
            if (numero1 % numero2 == 0 || numero2 % numero1 == 0)
                return "Sao Multiplos";
            else
                return "Nao Sao Multiplos";
        }

        public static int CalculaDiferencaHoraInicialEFinal(int horaInicial, int horaFinal)
        {
            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            return duracao;
        }


        public static string VerificaIntervalo(double numero)
        {
            string resultado = "";

            if (numero < 0.0 || numero > 100.0)
            {
                resultado = "Fora de intervalo";
            }
            else if (numero <= 25.0)
            {
                resultado = "Intervalo [0,25]";
            }
            else if (numero <= 50.0)
            {
                resultado = "Intervalo [25,50]";
            }
            else if (numero <= 75.0)
            {
                resultado = "Intervalo [50,75]";
            }
            else
            {
                resultado = "Intervalo [75,100]";
            }

            return resultado;
        }

        public static string VerificaCoordenadas(double x, double y)
        {
            string resultado = "";

            if (x == 0 && y == 0)
                resultado = "Origem";
            else if (x > 0 && y > 0)
                resultado = "Q1";
            else if(x < 0 && y > 0)
                resultado = "Q2";
            else if(x < 0 && y < 0)
                resultado = "Q3";
            else if(x > 0 && y < 0)
                resultado = "Q4";            

            return resultado;
        }

        public static double CalcularTotal(int codigo, int quantidade)
        {
            var produtos = ObterProdutos();

            return produtos.Where(x => x.Codigo == codigo).Select(x => x.Preco * quantidade).FirstOrDefault();
        }

        private static List<Produto> ObterProdutos()
        {
            var produtos = new List<Produto>();

            produtos.Add(new Produto { Codigo = 1, Nome = "Cachorro Quente", Preco = 4.00 });
            produtos.Add(new Produto { Codigo = 2, Nome = "X-Salada", Preco = 4.50 });
            produtos.Add(new Produto { Codigo = 3, Nome = "X-Bacon", Preco = 5.00 });
            produtos.Add(new Produto { Codigo = 4, Nome = "Torrada Simples", Preco = 2.00 });
            produtos.Add(new Produto { Codigo = 5, Nome = "Refrigerante", Preco = 1.50 });

            return produtos;
        }
    }
}
