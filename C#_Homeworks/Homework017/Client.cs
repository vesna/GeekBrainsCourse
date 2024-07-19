using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DBTest
{
    public class Client
    {
        private static IPEndPoint _iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
        
        public static bool isWork = true;
        public static async Task ClientSendlerAsync(string name)
        {
            var msgFromName = new MessageUDP()
            {
                Command = Command.Register,
                FromName = name,
                Text = string.Empty
            };
            await MessageSource.SendAsync(msgFromName, _iPEndPoint);
            while (isWork)
            {
                try
                {
                    Console.WriteLine("Введите имя получателя");
                    var toName = Console.ReadLine();
                    if (String.IsNullOrEmpty(toName))
                    {
                        Console.WriteLine("Вы не ввели имя получателя");
                        continue;
                    }
                    var msgToName = new MessageUDP()
                    {
                        Command = Command.Register,
                        ToName = toName,
                        Text = string.Empty
                    };
                    await MessageSource.SendAsync(msgToName, _iPEndPoint);

                    Console.WriteLine("Введите сообщение");
                    var text = Console.ReadLine();
                    if (String.IsNullOrEmpty(text) || text.ToLower() == "exit")
                    {
                        isWork = false;
                        // break;
                    }
                    var msgWithText = new MessageUDP()
                    {
                        Command = Command.Message,
                        Text = text,
                        FromName = name,
                        ToName = toName
                    };
                    await MessageSource.SendAsync(msgWithText, _iPEndPoint);

                    var msg = await MessageSource.ReceiveAsync();
                    Console.WriteLine(msg?.ToString());

                    msg.Command = Command.Confirmation;
                    await MessageSource.SendAsync(msg, _iPEndPoint);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Что-то пошло не так: {e.Message}");
                }
            }
        } 
    }
}
