// ABSTRAÇÃO NA PRÁTICA

using _19_abstracao_encapsulamento.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Lucas";
// p1.Idade = 25;

// p1.Apresentar();


//----------------------------------------------------------------------------------

// ENCAPSULAMENTO NA PRATICA

ContaCorrente c1 = new ContaCorrente(1, 1000);

c1.ExibirSaldo();
c1.Sacar(5000);
c1.ExibirSaldo();