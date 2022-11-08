using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _19_abstracao_encapsulamento.Models
{
  // ABSTRAÇÃO NA PRÁTICA
  public class Pessoa
  {
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void Apresentar()
    {
      Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
  }
}