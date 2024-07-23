using App;
using ChatNetwork;
using System.Net;

if (args.Length == 0)
{
    var s = new Server<IPEndPoint>(new UdpMessageSource());
    s.Work();
}
else
    if (args.Length == 1)
{
    var c = new Client<IPEndPoint>(args[0], new UdpMessageSourceClient(int.Parse("12346"), "127.0.0.1", 12345));
    c.Start();
}
else
{

   // Console.WriteLine("Для запуска сервера введите ник-нейм как параметр запуска приложения");
    Console.WriteLine("Для запуска клиента введите ник-нейм");
}
