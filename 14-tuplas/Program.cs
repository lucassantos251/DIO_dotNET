using _14_tuplas.Models;

//id, nome, sobrenome
// (int, string, string, decimal) tupla = (1, "Lucas", "Cirilo dos Santos", 1.64M);

// Console.WriteLine($"ID: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");

// Console.WriteLine($"{tupla.ToString()}");


// -----------------------------------------------------------------------

// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (2, "Gabrielli", "Yoshio Lima", 1.70M);

// ValueTuple<int, string, string, decimal> tupla2 = (1, "Lucas", "Cirilo dos Santos", 1.64M);

// var tupla3 = Tuple.Create(3, "Ingrid", "Yoshio Cirilo", 1.00M);

// Console.WriteLine($"ID: {tupla.Id}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
// Console.WriteLine($"Altura: {tupla.Altura}");


// -------------------------------------------------------------------------

// LeituraArquivo arquivo = new LeituraArquivo();

// string caminhoCorreto = "Arquivo/ArquivoTexto.txt";
// string caminhoErrado = "";

// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo(caminhoCorreto);

// if (sucesso)
// {
//   Console.WriteLine($"Quantidade de linhas do arquivo {quantidadeLinhas}");

//   foreach (string linha in linhasArquivo)
//   {
//     Console.WriteLine(linha);
//   }
// }
// else
// {
//   Console.WriteLine($"Não foi possível ler o arquivo.");
// }




// LeituraArquivo arquivo = new LeituraArquivo();

// string caminhoCorreto = "Arquivo/ArquivoTexto.txt";
// string caminhoErrado = "";

// // descartando o retorno com _
// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo(caminhoCorreto);

// if (sucesso)
// {
//   //Console.WriteLine($"Quantidade de linhas do arquivo {quantidadeLinhas}");

//   foreach (string linha in linhasArquivo)
//   {
//     Console.WriteLine(linha);
//   }
// }
// else
// {
//   Console.WriteLine($"Não foi possível ler o arquivo.");
// }


// ---------------------------------------------------------------------------------------------

// Pessoa p1 = new Pessoa("Lucas", "Cirilo");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");



//-----------------------------------------------------------------------------------------------

int numero = 10;

// if (numero % 2 == 0)
// {
//   Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//   Console.WriteLine($"O número {numero} é impar");
// }

bool ehPar = false;

ehPar = numero % 2 == 0;
Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));

