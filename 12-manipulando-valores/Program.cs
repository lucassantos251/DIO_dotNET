using _12_propriedades.Models;
using System.Globalization;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Lucas";
// p1.Sobrenome = "Cirilo dos Santos";

// Pessoa p2 = new Pessoa();
// p2.Nome = "Gabrielli";
// p2.Sobrenome = "Yoshio Lima Cirilo";

// Pessoa p3 = new Pessoa("Ingrid", "Yoshio Cirilo");
// Pessoa p4 = new Pessoa(nome: "Vinicius", sobrenome: "Yoshio Cirilo");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.AdicionarAluno(p3);
// cursoDeIngles.AdicionarAluno(p4);
// cursoDeIngles.ListarAlunos();


// ----------------------------------------------------------

// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);



// int numero1 = 10;
// int numero2 = 20;

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);



// int numero1 = 10;
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);


// ----------------------------------------------------------

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 9482.40M;

// Console.WriteLine($"{valorMonetario:C}");



// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 9482.40M;

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));



// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 9482.40M;

// Console.WriteLine(valorMonetario.ToString("C1"));
// Console.WriteLine(valorMonetario.ToString("C2"));
// Console.WriteLine(valorMonetario.ToString("C8"));
// Console.WriteLine(valorMonetario.ToString("N2"));



// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));


// -----------------------------------------------------------------

// DateTime data = DateTime.Now;

// Console.WriteLine(data);
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());



// DateTime data = DateTime.Parse("17/04/2022 18:00");
// //DateTime data = DateTime.Parse("32/04/22 18:00");

// Console.WriteLine(data);

string dataString = "22-04-17 23:00";

bool sucesso = DateTime.TryParseExact(dataString,
                      "yy-MM-dd HH:mm",
                      CultureInfo.InvariantCulture,
                      DateTimeStyles.None, out DateTime data);

if (sucesso)
{
  Console.WriteLine($"Conversão com sucesso! Data: {data}");
}
else
{
  Console.WriteLine($"{dataString} não é uma data válida");
}