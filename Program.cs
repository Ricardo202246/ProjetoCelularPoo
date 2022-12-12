using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone(numero: "1", modelo: "XR", imei: "12345",memoria: 20);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("-------------------------------");

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "2", modelo: "Oneplus", imei: "54321",memoria: 10);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("---------------------------------");

// TODO: Realizar os testes com as classes Nokia e Iphone