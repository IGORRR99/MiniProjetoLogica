using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minibanco
{
    
public class ContaSalario : Conta
{
    public string Empregador { get; }
    public int LimiteSaquesMensais { get; }

    public ContaSalario(
        string titular,
        decimal saldoInicial,
        string empregador,
        int limiteSaquesMensais)
        : base(titular, saldoInicial)
    {
        Empregador = empregador;
        LimiteSaquesMensais = limiteSaquesMensais;
    }
}
}