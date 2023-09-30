using projeto.Models;

Console.WriteLine("Smartphone Samsung");
Smartphone samsung = new Samsung(numero: "123456", modelo: "Galaxy S22 Ultra", imei: "22222", memoria: 256);
samsung.Ligar();
samsung.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Samsung");
Smartphone iphone = new Iphone(numero: "24680", modelo: "Iphone 15", imei: "55555", memoria: 512);
samsung.Ligar();
samsung.InstalarAplicativo("Telegram");