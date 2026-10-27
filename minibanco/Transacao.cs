using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minibanco
{
    public enum TipoTransacao
    {
        Deposito,
        Saque,
        Tarifa
    }

    public class Transacao
    {
        public TipoTransacao Tipo { get; }
        public decimal Valor { get; }
        public DateTime Data { get; }

        public Transacao(TipoTransacao tipo, decimal valor)
        {
            Tipo = tipo;
            Valor = valor;
            Data = DateTime.Now;
        }
    }
}