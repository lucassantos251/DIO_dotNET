using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_sintaxe.Models
{
  public class Pessoa
  {
    public string Nome { get; set; } = "";
    public int Idade { get; set; } = 0;

    public void Apresentar()
    {
      //Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
      Console.WriteLine($"Olá, meu nome é {Nome}\ne tenho {Idade} anos.");
    }
  }
}