using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Celular Nokia:");
Smartphone nokia = new Nokia(numero:"123456", modelo:"Nokia Juunj", imei:"1111", memoria:256);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Celular Iphone:");
Smartphone iphone = new Iphone(numero:"123456", modelo:"Iphone Sirigueijo Juunj", imei:"1111", memoria:256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Discord");