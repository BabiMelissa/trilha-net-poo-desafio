using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia("123456", "Nokia X", "123456789", 500);
Console.WriteLine($"Smartphone Nokia número {nokia.Numero}, modelo {nokia.Modelo}, " +
                  $"IMEI {nokia.IMEI} e memória de {nokia.Memoria}");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n-------------------------------------\n");

Smartphone iphone = new Iphone("987654", "Iphone Y", "987654321", 600);
Console.WriteLine($"Smartphone Iphone número {iphone.Numero}, modelo {iphone.Modelo}, " +
                  $"IMEI {iphone.IMEI} e memória de {iphone.Memoria}");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");


