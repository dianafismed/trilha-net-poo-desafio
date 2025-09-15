using DesafioPOO.Models;

Console.WriteLine("Nokia");
Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nIphone");

Iphone iphone = new Iphone("987654321", "iPhone 13", "987654321098765", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
