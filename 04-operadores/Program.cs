// int a = 10;
// int b = 20;
// int c = a + b;

// c = c + 5;
// c = c - 5;
// c += 5;
// c -= 5;

// Console.WriteLine(c);





//Cast - Casting
// int a = Convert.ToInt32("5");
// int a = int.Parse("25");

// int a = Convert.ToInt32(null);
// // int a = int.Parse(null);

// Console.WriteLine(a);

// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);




//Casting implícito
// int a = 5;
// double b = a;

// long a = long.MaxValue;
// int b = Convert.ToInt32(a);

// int a = int.MaxValue;
// long b = a;

// Console.WriteLine(b);

// double a = 4 / 2 + 2;
// double a = 4 / (2 + 2);

// Console.WriteLine(a);

// string a = "15a";
// int b = 0;

// int.TryParse(a, out b);
// //int.TryParse(a, out int b);

// Console.WriteLine(b);





// etapa 08 - operador condicional

// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//   Console.WriteLine("Venda inválida.");
// }
// else if (possivelVenda)
// {
//   Console.WriteLine("Venda realizada.");
// }
// else
// {
//   Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
// }



// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//   case "a":
//   case "e":
//   case "i":
//   case "o":
//   case "u":
//     Console.WriteLine("Vogal");
//     break;

//   default:
//     Console.WriteLine("Consoante");
//     break;
// }



// etapa 09 - logicos

// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//   Console.WriteLine("Entrada liberada");
// }
// else
// {
//   Console.WriteLine("Entrada negada.");
// }




// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//   Console.WriteLine("Aprovado");
// }
// else
// {
//   Console.WriteLine("Reprovado");
// }



bool choveu = true;
bool estaTarde = true;

if (!choveu && !estaTarde)
{
  Console.WriteLine("Vou pedalar");
}
else
{
  Console.WriteLine("Vou pedalar outro dia");
}