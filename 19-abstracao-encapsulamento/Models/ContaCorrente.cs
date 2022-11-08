using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _19_abstracao_encapsulamento.Models
{
  public class ContaCorrente
  {
    public ContaCorrente(int numeroConta, decimal saldoInicial)
    {
      NumeroConta = numeroConta;
      saldo = saldoInicial;
    }

    public int NumeroConta { get; set; }
    private decimal saldo;

    public void Sacar(decimal valor)
    {
      if (saldo >= valor)
      {
        saldo -= valor;
        Console.WriteLine($"Sacou {valor}.");
      }
      else
      {
        Console.WriteLine($"Valor acima do limite disponível para saque");
      }
    }

    public void ExibirSaldo()
    {
      Console.WriteLine($"Seu saldo disponível é: {saldo}");
    }
  }
}