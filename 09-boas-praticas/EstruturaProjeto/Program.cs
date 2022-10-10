using EstruturaComum.Models;

// Instância da classe pessoa
Pessoa pessoa1 = new Pessoa();

/*
  Atribui o nome e idade para pessoa
  passando o nome Lucas
  e passando a idade 20
*/
pessoa1.Nome = "Lucas";
pessoa1.Idade = 25;

// Faz a pessoa se apresentar
pessoa1.Apresentar();


Calculadora calc = new Calculadora();

calc.Somar(1, 2);