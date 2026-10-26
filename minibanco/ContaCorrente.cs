using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minibanco
{
    public class ContaCorrente
    {
        public decimal LimiteChequeEspecial { get; }

        public ContaCorrente(string titular, decimal saldoInicial, decimal limite)
            : base(titular, saldoInicial)
        {
            LimiteChequeEspecial = limite;
        }

        public override bool Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor inválido.");
                return false;
            }

            if (valor > Saldo + LimiteChequeEspecial)
            {
                Console.WriteLine("Saldo insuficiente.");
                return false;
            }

            Saldo -= valor;
            return true;
        }
    }
}