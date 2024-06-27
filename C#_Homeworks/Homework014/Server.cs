using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Homework014
{
    internal class Server
    {
        static private CancellationTokenSource cts = new CancellationTokenSource();

        public static async Task AcceptMsg()
        {
            IPEndPoint iPEndPoint = new IPEndPoint((IPAddress)IPAddress.Any, 0);
            UdpClient udpClient = new UdpClient(12345);
            Console.WriteLine("Сервер ожидает сообщения отклиента");

            Task cancelTask = Task.Run(() => {
                var temp = Console.ReadKey(true);

                Console.WriteLine($"\nнажата {temp.Key}: завершеие работы.\n");
                cts.Cancel();
            });


            while (true)
            {
                try
                {
                    byte[] buffer = udpClient.Receive(ref iPEndPoint); 
                    string data = Encoding.UTF8.GetString(buffer, 0, buffer.Length);

                    var serverTask = Task.Run(async () =>
                    {
                        if (cts.IsCancellationRequested)  // проверяем наличие сигнала отмены задачи
                        {
                            Console.WriteLine("Операция прервана");
                            return;     //  выходим из метода и тем самым завершаем задачу
                        }
                        Message? msg = Message.FromJson(data);
                        if (msg != null)
                        {
                            Console.WriteLine(msg?.ToString());
                            var newMsg = new Message("Server", "Сообщение получено");
                            var json = newMsg.ToJson();
                            var bytes = Encoding.UTF8.GetBytes(json);
                            await udpClient.SendAsync(bytes, iPEndPoint);
                        }
                        else { Console.WriteLine("Сообщение не корректно"); }

                    }, cts.Token);

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
