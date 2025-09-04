using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456789", "Nokia 3310", "IMEI123456789", 16);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\nSmartphone iPhone:");
Smartphone iphone = new Iphone("987654321", "iPhone 13", "IMEI987654321", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");