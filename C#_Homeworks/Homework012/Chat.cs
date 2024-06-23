using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Homework012
{
    internal class Chat
    {
        public static void Server()
        {
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 0);
            var client = new UdpClient(12345);
            Console.WriteLine("Сервер ожидает сообщения отклиента");

            while (true)
            {
                try
                {
                    byte[] buffer = client.Receive(ref iPEndPoint);
                    var str1 = Encoding.UTF8.GetString(buffer);
                    var somemessage = Message.FromJson(str1);
                    if (somemessage != null)
                    {
                        Console.WriteLine(somemessage.ToString());

                        var newMsg = new Message("Server", "Сообщение получено");
                        var json = newMsg.ToJson();
                        var bytes = Encoding.UTF8.GetBytes(json);
                        client?.Send(bytes, iPEndPoint);
                    }
                    else { Console.WriteLine("Сообщение не корректно"); }

                }
                catch (Exception e)
                {
                    Console.WriteLine($"Что-то пошло не так: {e.Message}");
                }
            }
        }

        public static void Client(string nikname)
        {
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
            var client = new UdpClient();

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите сообщение");
                    var text = Console.ReadLine();
                    if (String.IsNullOrEmpty(text))
                    {
                        break;
                    }
                    var newMsg = new Message(nikname, text);
                    var json = newMsg.ToJson();
                    var bytes = Encoding.UTF8.GetBytes(json);
                    client?.Send(bytes, iPEndPoint);

                    byte[] buffer = client.Receive(ref iPEndPoint);
                    var str1 = Encoding.UTF8.GetString(buffer);
                    var somemessage = Message.FromJson(str1);
                    Console.WriteLine(somemessage.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Что-то пошло не так: {e.Message}");
                }
            }
        }
    }
}
