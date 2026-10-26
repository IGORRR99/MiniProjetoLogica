using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minibanco
{
    public class ContaPoupanca : Conta
    {
        public double TaxaRendimentoMensal { get; }
        public int DiaAniversario { get; }

        public ContaPoupanca(string titular, decimal saldoInicial, double taxa, int diaAniversario)
            : base(titular, saldoInicial)
        {
            TaxaRendimentoMensal = taxa;
            DiaAniversario = diaAniversario;
        }
    }
}