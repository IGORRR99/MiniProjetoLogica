using System;

namespace minibanco
{
    public abstract class Conta
    {
        public string Titular { get; }
        public decimal Saldo { get; protected set; }

        public Conta(string titular, decimal saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor inválido.");
                return;
            }
            Saldo += valor;
        }

        public virtual bool Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor inválido.");
                return false;
            }

            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
                return false;
            }

            Saldo -= valor;
            return true;
        }
    }
}