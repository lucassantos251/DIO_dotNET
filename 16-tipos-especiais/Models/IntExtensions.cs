using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _16_tipos_especiais.Models
{
  //METODOS DE EXTENSAO
  public static class IntExtensions
  {
    public static bool EhPar(this int numero)
    {
      return numero % 2 == 0;
    }
  }
}