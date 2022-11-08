using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20_heranca_polimorfismo.Models
{
  public class Pessoa
  {
    public string Nome { get; set; }
    public int Idade { get; set; }

    public virtual void Apresentar()
    {
      Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos.");
    }
  }
}