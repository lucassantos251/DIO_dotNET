using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _21_classe_abstrata.Models
{


  // CLASSE SELADA NA PRÁTICA


  // public sealed class Professor : Pessoa
  // {
  //   // METODO SELADO NA PRATICA
  //   public Professor()
  //   {

  //   }

  //   public Professor(string nome) : base(nome)
  //   {

  //   }

  //   public decimal Salario { get; set; }

  //   public override void Apresentar()
  //   {
  //     Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou professor e tenho salário de {Salario}");
  //   }
  // }

  //------------------------------------------------------------------------------------------

  // MÉTODO SELADO NA PRÁTICA

  public class Professor : Pessoa
  {
    // METODO SELADO NA PRATICA
    public Professor()
    {

    }

    public Professor(string nome) : base(nome)
    {

    }

    public decimal Salario { get; set; }

    public sealed override void Apresentar()
    {
      Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou professor e tenho salário de {Salario}");
    }
  }
}