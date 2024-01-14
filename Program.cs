using DesafioPOO.Models;

// Implementado!!!!

Console.WriteLine("Smartphone Nokia:");
Smartiphone nokia = new Nokia(numero: "1234", modelo: "Modelo 1", imei: "1111", memoria: 64 );
nokia.Ligar();
nokia.InstalarAplicativo("Watsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "1234", modelo: "Modelo 2", imei: "2222", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");




