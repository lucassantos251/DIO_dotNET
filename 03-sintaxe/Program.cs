using _03_sintaxe.Models;

/* Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Lucas";
pessoa1.Idade = 25;
pessoa1.Apresentar(); */

//dados

/* string apresentacao = "Olá, seja bem vindo";

int quantidade = 1;

double altura = 1.80;

decimal preco = 1.80M;

bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.000"));
Console.WriteLine("Valor da variável preço: " + preco);
Console.WriteLine("Valor da variável condição: " + condicao); */

/* int quantidade = 1;
Console.WriteLine("Valor da variável quantidade: " + quantidade);

quantidade = 10;
Console.WriteLine("Valor da variável quantidade: " + quantidade); */

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

DateTime dataNova = DateTime.Now.AddDays(5);
Console.WriteLine(dataNova.ToString("dd/MM/yyyy HH:mm"));