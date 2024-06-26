using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Homework013
{
    internal class Server
    {
        public static void AcceptMsg()
        {
            IPEndPoint iPEndPoint = new IPEndPoint((IPAddress)IPAddress.Any, 0);
            UdpClient udpClient = new UdpClient(12345);
            Console.WriteLine("Сервер ожидает сообщения отклиента");

            while (true)
            {
                string text = "";
                try
                {
                    byte[]? buffer = udpClient?.Receive(ref iPEndPoint);
                    string data = Encoding.UTF8.GetString(buffer, 0, buffer.Length);

                    Thread tr = new Thread(() =>
                    {
                        Message? msg = Message.FromJson(data);
                        if (msg != null)
                        {
                            text = msg.Text;

                            Console.WriteLine(msg?.ToString());
                            var newMsg = new Message("Server", "Сообщение получено");
                            var json = newMsg.ToJson();
                            var bytes = Encoding.UTF8.GetBytes(json);
                            udpClient?.Send(bytes, iPEndPoint);
                        }
                        else { Console.WriteLine("Сообщение не корректно"); }
                    });
                    tr.Start();
                    tr.Join();
                    if (text == "Exit")
                    {
                        tr.Interrupt();
                        udpClient?.Close();
                        return;
                    }
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
