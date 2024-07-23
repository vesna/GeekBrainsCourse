using Core;
using Infrastructure.Provider;
using Infrastructure.Persistence.Contexts;
using System.Net;
using System.Net.Sockets;

IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);

IMessageSource source;

if (args.Length == 0)
{
    source = new MessageSource(new UdpClient(serverEndPoint));
    var chat = new ChatServer(source, new ChatContext());
    await chat.Start();
}
else
{
    source = new MessageSource(new UdpClient());
    var chat = new ChatClient(args[0], serverEndPoint, source);
    await chat.Start();
}