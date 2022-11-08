using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _21_classe_abstrata.Models
{
  // CLASSE ABSTRATA NA PRÁTICA
  public class Corrente : Conta
  {
    public override void Creditar(decimal valor)
    {
      saldo += valor;
    }
  }
}