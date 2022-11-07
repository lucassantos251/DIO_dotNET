//TIPOS NULOS NA PRATICA

// bool? desejaReceberEmail = null;

// //if(desejaReceberEmail != null && desejaReceberEmail.Value)

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//   Console.WriteLine($"O usuário optou por receber e-mail.");
// }
// else
// {
//   Console.WriteLine($"O usuário não respondeu ou optou por não receber e-mail");
// }



//-----------------------------------------------------------------------------------------

//TIPOS NULOS EM PROPRIEDADES

// using _16_tipos_especiais.Models;
// using Newtonsoft.Json;

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//   Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
//                     $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyy HH:mm")}, " +
//                     $"{(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
// }



//--------------------------------------------------------------------------------------------

//TIPOS ANONIMOS

// var tipoAnonimo = new { Nome = "Lucas", Sobrenome = "Cirilo", Altura = 1.80 };

// Console.WriteLine($"Nome: {tipoAnonimo.Nome}");
// Console.WriteLine($"Sobrenome: {tipoAnonimo.Sobrenome}");
// Console.WriteLine($"Altura: {tipoAnonimo.Altura}");


//-----------------------------------------------------------------------------------------------

//TIPOS ANONIMOS EM COLECAO

// using _16_tipos_especiais.Models;
// using Newtonsoft.Json;

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach (var venda in listaAnonimo)
// {
//   Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }




//--------------------------------------------------------------------------------------------------

// TIPO DINAMICO

// dynamic variavelDinamica = 4;
// Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = "Texto";
// Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = true;
// Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");



// -----------------------------------------------------------------------------------------------------

//CRIANDO UMA CLASSE GENERICA

//TESTANDO NOSSA CLASSE GENERICA

// using _16_tipos_especiais.Models;

// MeuArray<int> arrayInteiro = new MeuArray<int>();
// arrayInteiro.AdicionarElementoArray(30);
// Console.WriteLine(arrayInteiro[0]);

// MeuArray<string> arrayString = new MeuArray<string>();
// arrayString.AdicionarElementoArray("Teste");
// Console.WriteLine(arrayString[0]);



//------------------------------------------------------------------------------------------

// METODOS DE EXTENSAO

using _16_tipos_especiais.Models;

int numero = 20;
bool par = false;

par = numero.EhPar();

string mensagem = "O número " + numero + " " + "é " + (par ? "par" : "ímpar");
Console.WriteLine($"{mensagem}");