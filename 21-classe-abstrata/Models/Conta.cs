using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _21_classe_abstrata.Models
{
  // CLASSE ABSTRATA NA PRÁTICA
  public abstract class Conta
  {
    protected decimal saldo;

    public abstract void Creditar(decimal valor);

    public void ExibirSaldo()
    {
      Console.WriteLine($"O seu saldo é: {saldo}");
    }
  }
}