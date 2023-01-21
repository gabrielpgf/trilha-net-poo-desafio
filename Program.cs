using DesafioPOO.Models;

Console.WriteLine("Smarphone Nokia:");
Smartphone nokia = new Nokia(numero: "7785485631", modelo: "Lumia 750", imei: "dgs58798/waf480", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smarphone Iphone:");
Smartphone iphone = new Iphone(numero: "2157844772", modelo: "Iphone 13 Pro Max", imei: "s874fry545safrv18%&%", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

