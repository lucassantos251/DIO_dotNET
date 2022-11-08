using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine($"Smartphone iPhone:");
Smartphone iphone = new Iphone("+55 11 9 1111-1111", "6", "0578974", 16);
Console.WriteLine($"Número do Celular: {iphone.Numero}");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("YouTube");

Console.WriteLine("\n");

Console.WriteLine($"Smartphone Nokia:");
Smartphone nokia = new Nokia("+55 11 9 2222-2222", "Tijolão", "0000001", 1);
Console.WriteLine($"Número do Celular: {nokia.Numero}");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("MMS");

Console.WriteLine("\n");

Console.WriteLine($"Smartphone Samsung:");
Smartphone samsung = new Samsung("+55 11 9 3333-3333", "J5 Pro", "0578975", 32);
Console.WriteLine($"Número do Celular: {samsung.Numero}");
samsung.Ligar();
samsung.ReceberLigacao();
samsung.InstalarAplicativo("WhatsApp");