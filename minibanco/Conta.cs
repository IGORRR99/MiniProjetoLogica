using System;
using System.Collections.Generic;

namespace minibanco
{
    public abstract class Conta
    {
        public string Titular { get; }
        public decimal Saldo { get; protected set; }
        public List<Transacao> Transacoes { get; } = new List<Transacao>();
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
            Transacoes.Add(new Transacao(TipoTransacao.Deposito, valor));
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