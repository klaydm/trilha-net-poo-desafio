using DesafioPOO.Models;

// Feat: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "NK095", imei: "1234567890", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.InstalarAplicativo("Deezer");
nokia.InstalarAplicativo("Netflix");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "654321", modelo: "14 Pro Max", imei: "0987654321", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.InstalarAplicativo("Instagram");
iphone.InstalarAplicativo("Spotify");
iphone.ReceberLigacao();