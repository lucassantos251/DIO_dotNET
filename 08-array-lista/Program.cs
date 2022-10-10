// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// // arrayInteiros[3] = 1;

// Console.WriteLine("Percorrendo o array com o FOR:");
// for (int i = 0; i < arrayInteiros.Length; i++)
// {
//   Console.WriteLine($"Posição Nº {i} - {arrayInteiros[i]}");
// }

// Console.WriteLine("Percorrendo o array com o FOREACH:");
// foreach (int valor in arrayInteiros)
// {
//   Console.WriteLine(valor);
// }







// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// Console.WriteLine("Percorrendo o array com o FOR:");
// for (int i = 0; i < arrayInteiros.Length; i++)
// {
//   Console.WriteLine($"Posição Nº {i} - {arrayInteiros[i]}");
// }










// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");

// for (int i = 0; i < listaString.Count; i++)
// {
//   Console.WriteLine($"Posição Nº {i} = {listaString[i]}");
// }

// foreach (string item in listaString)
// {
//   Console.WriteLine($"{item}");
// }











// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");
// listaString.Add("RJ");

// Console.WriteLine($"Itens na minha lista:{listaString.Count} - Capacidade:{listaString.Capacity}");

// listaString.Add("SC");

// Console.WriteLine($"Itens na minha lista:{listaString.Count} - Capacidade:{listaString.Capacity}");

// listaString.Remove("MG");

// Console.WriteLine($"Itens na minha lista:{listaString.Count}- Capacidade:{listaString.Capacity}");








