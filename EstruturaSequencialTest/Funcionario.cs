using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaSequencialTest
{
    public class Funcionario
    {
        public Funcionario(int codigo, int horasTrabalhadas, double valorHora)
        {
            Codigo = codigo;
            Salario = CalcularSalario(horasTrabalhadas, valorHora);
        }
        public int Codigo { get; set; }
        public double Salario { get; set; }

        public double CalcularSalario(int horasTrabalhadas, double valorHora)
        {
            return horasTrabalhadas * valorHora;
        }
    }
}
