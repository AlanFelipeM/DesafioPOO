using DesafioPOO.Models;

Console.WriteLine("Celular Nokia:");
var nokia = new Nokia(numero: "123456", modelo: "Nokia 110", imei: "00001111", memoria: 64);

nokia.Ligar("16982320577");
nokia.InstalarAplicativo("ZapZap");
nokia.ListarAplicativos();
nokia.DesinstalarAplicativo("ZapZap");
nokia.ListarAplicativos();


Console.Write("\n");

Console.WriteLine("Celular Iphone:");
var iphone = new Iphone(numero: "78854632", modelo: "Iphone 15", imei: "22223333", memoria: 32);
iphone.ReceberLigacao();
iphone.ListarAplicativos();
iphone.InstalarAplicativo("YouTube");
iphone.InstalarAplicativo("Tiktok");
iphone.ListarAplicativos();