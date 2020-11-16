using System;
using System.Collections.Generic;
using System.Text;

namespace AppBanco
{
    public class Conta
    {
        public Conta(int numeroConta, string nomeTitular)
        {
            _numeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }

        public Conta(int numeroConta, string nomeTitular, double depositoInicial)
            : this (numeroConta, nomeTitular)
        {
            Depositar(depositoInicial);
        }

        private int _numeroConta;
        public int NumeroConta
        {
            get { return _numeroConta; }
        }

        private string _nomeTitular;
        public string NomeTitular
        {
            get { return _nomeTitular; }
            set { _nomeTitular = value; }
        }

        private double _saldo;
        private double Saldo
        {
            get { return _saldo; }            
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (_saldo >= valor)
            {
                _saldo -= valor + 5.00;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque!");
                Console.WriteLine("Valor Disponível: " + Saldo.ToString("F2") + SituacaoSaldo(Saldo));
            }
        }

        public string SituacaoSaldo(double valor)
        {
            if (valor < 0)
                return " (saldo negativo)";
            else
                return " (saldo positivo)";
        }

        public override string ToString()
        {
            return "Dados do Conta: " + NumeroConta + ", Titular " + NomeTitular + ", Saldo: R$ " + Saldo.ToString("F2") + SituacaoSaldo(Saldo);
        }
    }
}
