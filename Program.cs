using projeto.Models;

Console.WriteLine("Smartphone Samsung");
Smartphone samsung = new Samsung(numero: "123456", modelo: "Galaxy S22 Ultra", imei: "22222", memoria: 256);
samsung.Ligar();
samsung.InstalarAplicativo("Whatsapp");
samsung.FazerChamada("555-1234");
samsung.EnviarMensagem("555-1234", "Olá, como você está?");
samsung.ReceberLigacao();
samsung.ReproduzirMusica("NomeDaMusica.mp3");
samsung.ConfigurarBrilhoTela(50);
samsung.AjustarVolume(75);
samsung.DesinstalarAplicativo("Whatsapp");

Console.WriteLine("\nSmartphone iPhone");
Smartphone iphone = new Iphone(numero: "24680", modelo: "Iphone 15", imei: "55555", memoria: 512);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.FazerChamada("555-5678");
iphone.EnviarMensagem("555-5678", "Oi, estou usando o Telegram!");
iphone.ReceberLigacao();
iphone.ReproduzirMusica("OutraMusica.mp3");
iphone.ConfigurarBrilhoTela(60);
iphone.AjustarVolume(80);
iphone.DesinstalarAplicativo("Telegram");
