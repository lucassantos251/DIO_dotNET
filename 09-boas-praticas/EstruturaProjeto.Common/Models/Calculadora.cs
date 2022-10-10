using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaComum.Models
{
  public class Calculadora
  {
    /// <summary>
    /// Realiza uma soma de dois valores
    /// </summary>
    /// <param name="x">Primeiro valor</param>
    /// <param name="y">Segundo valor</param>
    public void Somar(int x, int y)
    {
      Console.WriteLine($"{x} + {y} = {x + y}");
    }

    public void Subtrair(int x, int y)
    {
      Console.WriteLine($"{x} - {y} = {x - y}");
    }

    public void Multiplicar(int x, int y)
    {
      Console.WriteLine($"{x} * {y} = {x * y}");
    }

    public void Dividir(int x, int y)
    {
      Console.WriteLine($"{x} / {y} = {x / y}");
    }

    public void Potencia(int x, int y)
    {
      double potencia = Math.Pow(x, y);
      Console.WriteLine($"{x}^{y} = {potencia}");
    }

    public void Seno(double angulo)
    {
      double radiano = angulo * Math.PI / 180;
      double seno = Math.Sin(radiano);
      Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");
    }

    public void Cosseno(double angulo)
    {
      double radiano = angulo * Math.PI / 180;
      double cosseno = Math.Cos(radiano);
      Console.WriteLine($"Cosseno de {angulo}° = {Math.Round(cosseno, 4)}");
    }

    public void Tangente(double angulo)
    {
      double radiano = angulo * Math.PI / 180;
      double tangente = Math.Tan(radiano);
      Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 4)}");
    }

    public void Incrementar(int x)
    {
      Console.WriteLine($"Incrementando o {x}");
      // x = x + 1;
      x++;
      Console.WriteLine($"Numero incrementado: {x}");
    }

    public void Decrementar(int x)
    {
      Console.WriteLine($"Decrementando o {x}");
      x--;
      Console.WriteLine($"Numero decrementado: {x}");
    }

    public void RaizQuadrada(double x)
    {
      double raiz = Math.Sqrt(x);
      Console.WriteLine($"Raiz quadrada de {x} = {Math.Round(raiz, 4)}");
    }
  }
}