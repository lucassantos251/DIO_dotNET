using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _21_classe_abstrata.Models
{
  public class Pessoa
  {
    // CONSTRUTOR POR HERANÇA

    public Pessoa()
    {

    }

    public Pessoa(string nome)
    {
      Nome = nome;
    }

    public string Nome { get; set; }
    public int Idade { get; set; }

    public virtual void Apresentar()
    {
      Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos.");
    }
  }
}