using ChatCommon;
using ChatNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Client<T>
    {
        string _name;
        string _address;

        public Client(string n, IMessageSourceClient<T> cl)
        {
            this._name = n;
            client = cl;
        }

        IMessageSourceClient<T> client;
        void ClientListener()
        {
            T remoteEndPoint = client.CreateNewT();

            while (true)
            {
                try
                {
                    var messageReceived = client.Receive(ref remoteEndPoint);

                    Console.WriteLine($"Получено сообщение от {messageReceived.FromName}:");
                    Console.WriteLine(messageReceived.Text);

                    Confirm(messageReceived, remoteEndPoint);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка при получении сообщения: " + ex.Message);
                }
            }
        }

        void Confirm(Message m, T remoteEndPoint)
        {
            var message = new Message() { FromName = _name, ToName = null, Text = null, Id = m.Id, Command = Command.Confirmation };
            client.Send(message, remoteEndPoint);
        }


        void Register(string name, T remoteEndPoint)
        {
            var chatMessage = new Message() { FromName = name, ToName = null, Text = null, Command = Command.Register };

            client.Send(chatMessage, remoteEndPoint);
        }

        void ClientSender()
        {

            Register(_name, client.GetServer());

            while (true)
            {
                try
                {
                    Console.WriteLine("UDP Клиент ожидает ввода сообщения");

                    Console.Write("Введите  имя получателя и сообщение и нажмите Enter: ");
                    var messages = Console.ReadLine().Split(' ');

                    Register(messages[0], client.GetServer());

                    var message = new Message() { Command = Command.Message, FromName = _name, ToName = messages[0], Text = messages[1] };

                    client.Send(message, client.GetServer());
                    Console.WriteLine("Сообщение отправлено.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка при обработке сообщения: " + ex.Message);
                }
            }
        }

        public void Start()
        {
            new Thread(() => ClientListener()).Start();

            ClientSender();

        }
    }

}
