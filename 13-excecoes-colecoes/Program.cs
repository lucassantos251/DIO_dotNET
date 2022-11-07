using _13_excecoes_colecoes.Models;

// try
// {
//   string[] linhas = File.ReadAllLines("Arquivos/arquivaoLeitura.txt");

//   foreach (string linha in linhas)
//   {
//     Console.WriteLine(linha);
//   }
// }
// catch (FileNotFoundException e)
// {
//   Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {e.Message}");
// }
// catch (DirectoryNotFoundException e)
// {
//   Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {e.Message}");
// }
// catch (Exception e)
// {
//   Console.WriteLine($"Ocorreu uma exceção genérica. {e.Message}");
// }
// finally
// {
//   Console.WriteLine($"Chegou até aqui");
// }


// -------------------------------------------------------------------

// new ExemploExcecao().Metodo1();


// -----------------------------------------------------------------------------

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//   Console.WriteLine($"{item}");
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// fila.Enqueue(10);

// foreach (int item in fila)
// {
//   Console.WriteLine($"{item}");
// }


// ------------------------------------------------------------------------------------------

// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//   Console.WriteLine($"{item}");
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach (int item in pilha)
// {
//   Console.WriteLine($"{item}");
// }


//---------------------------------------------------------------------------------------------

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

//foreach (var item in estados)
foreach (KeyValuePair<string, string> item in estados)
{
  Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Add("BA2", "Bahia");
Console.WriteLine($"----------------");

estados.Remove("BA");
estados["SP"] = "São Paulo - valor alterado";

foreach (var item in estados)
{
  Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine($"----------------");
string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
  Console.WriteLine($"Valor existente: {chave}");
}
else
{
  Console.WriteLine($"Valor não existente. É seguro adicionar a chave: {chave}");
}

Console.WriteLine($"----------------");
Console.WriteLine(estados["MG"]);
