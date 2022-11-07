using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _12_propriedades.Models
{
  public class Curso
  {
    public string Nome { get; set; }
    public List<Pessoa> Alunos { get; set; }

    public void AdicionarAluno(Pessoa aluno)
    {
      Alunos.Add(aluno);
    }

    public bool RemoverAluno(Pessoa aluno)
    {
      return Alunos.Remove(aluno);
    }

    public void ListarAlunos()
    {
      Console.WriteLine($"Alunos do curso de: {Nome}");

      // foreach (Pessoa aluno in Alunos)
      // {
      //   Console.WriteLine(aluno.NomeCompleto);
      // }

      for (int i = 0; i < Alunos.Count; i++)
      {
        //string texto = "N° " + (i + 1) + " - " + Alunos[i].NomeCompleto;
        string texto = $"N° {i + 1} - {Alunos[i].NomeCompleto}";

        Console.WriteLine(texto);
      }
    }

    public int ObterAlunosMatriculados()
    {
      int quantidade = Alunos.Count;
      return quantidade;
    }
  }
}