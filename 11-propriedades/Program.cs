using _11_propriedades.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Lucas";
p1.Sobrenome = "Cirilo";

Pessoa p2 = new Pessoa();
p2.Nome = "Gabrielli";
p2.Sobrenome = "Yoshio";

Pessoa p3 = new Pessoa("Ingrid", "Yoshio");
Pessoa p4 = new Pessoa(nome: "Vinicius", sobrenome: "Yoshio");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.AdicionarAluno(p4);
cursoDeIngles.ListarAlunos();