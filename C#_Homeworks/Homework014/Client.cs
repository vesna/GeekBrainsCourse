using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Homework014
{
    internal class Client
    {
        public static async Task SendMsg(string nikname)
        {
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
            UdpClient udpClient = new UdpClient();
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите сообщение");
                    var text = Console.ReadLine();
                    if (String.IsNullOrEmpty(text) || text.ToLower() == "exit")
                    {
                        break;
                    }

                    var msg = new Message(nikname, text);
                    var json = msg.ToJson();
                    var data = Encoding.UTF8.GetBytes(json);
                    var t = await udpClient.SendAsync(data, iPEndPoint);

                    var q = await udpClient.ReceiveAsync();
                    byte[] buffer = q.Buffer;//udpClient.Receive(ref iPEndPoint);
                    string str1 = Encoding.UTF8.GetString(buffer);
                    var somemessage = Message.FromJson(str1);
                    Console.WriteLine(somemessage?.ToString());
                }
                catch (Exception e)
                {
                    udpClient?.Close();
                    Console.WriteLine($"Что-то пошло не так: {e.Message}");
                }
            }
        }
    }
}
