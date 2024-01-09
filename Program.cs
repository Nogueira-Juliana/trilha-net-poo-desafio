using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia1 = new Nokia(numero: "55972637463", modelo: "a52", imei: "abcde12345", memoria: 16);
nokia1.Ligar();
nokia1.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone1 = new Iphone(numero: "33972637462", modelo: "i39", imei: "abcde78910", memoria: 16);
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Telegram");


