using _20_heranca_polimorfismo.Models;

// HERANÇA NA PRÁTICA

// Aluno a1 = new Aluno();
// a1.Nome = "Gabrielli";
// a1.Idade = 15;
// a1.Nota = 7;
// a1.Apresentar();

// Professor pf1 = new Professor();
// pf1.Salario = 1000;

//------------------------------------------------------------------------------------------------

// POLIMORFISMO NA PRÁTICA

Pessoa p1 = new Pessoa();
p1.Nome = "Lucas";
p1.Idade = 25;
p1.Apresentar();

Aluno a1 = new Aluno();
a1.Nome = "Gabrielli";
a1.Idade = 15;
a1.Nota = 7;
a1.Apresentar();

Professor pf1 = new Professor();
pf1.Nome = "Batata";
pf1.Idade = 35;
pf1.Salario = 1000;
pf1.Apresentar();