using Core;
using Infrastructure.Provider;
using Infrastructure.Persistence.Contexts;
using System.Net;
using System.Net.Sockets;

IPEndPoint serverEndPoint = new (IPAddress.Parse("127.0.0.1"), 12345);

IMessageSource source;

if (args.Length != 0)
{
    UdpClient udpClient = new UdpClient(12345);
    IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
    source = new MessageSource(udpClient);
    var chat = new ChatServer(source, new ChatContext());
    await chat.Start();
}
else
{
    source = new MessageSource(new UdpClient());
    var chat = new ChatClient("ggggg", serverEndPoint, source);
    await chat.Start();
}