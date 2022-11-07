using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_propriedades.Models
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
      foreach (Pessoa aluno in Alunos)
      {
        Console.WriteLine(aluno.NomeCompleto);
      }
    }

    public int ObterAlunosMatriculados()
    {
      int quantidade = Alunos.Count;
      return quantidade;
    }
  }
}