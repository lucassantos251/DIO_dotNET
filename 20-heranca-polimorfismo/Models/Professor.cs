using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20_heranca_polimorfismo.Models
{
  public class Professor : Pessoa
  {
    public decimal Salario { get; set; }

    public override void Apresentar()
    {
      Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou professor e tenho salário de {Salario}");
    }
  }
}