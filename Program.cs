using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Usando um Nokia");
Nokia celNokia = new(numero:"13111",modelo:"aaaaa",imei:"898899",memoria:64);
celNokia.Ligar();
celNokia.ReceberLigacao();
celNokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Usando um Iphone");
Iphone celIphone = new(numero:"14222",modelo:"bbbb",imei:"566789",memoria:32);
celIphone.Ligar();
celIphone.ReceberLigacao();
celIphone.InstalarAplicativo("Vibe");