using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Implementado!
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "9999-9999", modelo: "Modelo A", imei: "11111111", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "8888-9999", modelo: "Modelo C", imei: "33333333", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Candy Crush");