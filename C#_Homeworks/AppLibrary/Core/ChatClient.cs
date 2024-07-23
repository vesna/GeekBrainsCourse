using App.Contracts;
using Infrastructure.Provider;
using System.Net;

namespace Core
{
    public class ChatClient : ChartBase
    {
        private readonly Users _user;
        private readonly IPEndPoint _endPoint;
        private readonly IMessageSource _messageSource;
        private IEnumerable<Users> _users = [];

        public ChatClient(string username, IPEndPoint endPoint, IMessageSource messageSource)
        {
            _user = new Users { Name = username };
            _endPoint = endPoint;
            _messageSource = messageSource;
        }

        public override async Task Start()
        {
            var join = new Messages { Text = _user.Name, Command = Command.Join };
            await _messageSource.Send(join, _endPoint, CancellationToken);

            await Task.Run(Lissener);

            while (!CancellationToken.IsCancellationRequested)
            {
                Console.WriteLine("Введите сообщение");
                string input = (await Console.In.ReadLineAsync()) ??  string.Empty;
                Messages messages;
                if (input.Trim().ToLower() == "exit")
                {
                    messages = new() { FromUserId = _user.Id, Command = Command.Exit };
                }
                else
                {
                    messages = new() { Text = input, FromUserId = _user.Id, Command = Command.None };
                }

                await _messageSource.Send(messages, _endPoint, CancellationToken);
            }
        }

        public override async Task Lissener()
        {
            while (!CancellationToken.IsCancellationRequested)
            {
                try
                {
                    var result = await _messageSource.Receive(CancellationToken);
                    if (result.Message == null) { 
                        throw new Exception("Message is null"); 
                    }

                    if (result.Message!.Command == Command.Join)
                    {
                        JoinHandler(result.Message);
                    }
                    else if (result.Message.Command == Command.Users)
                    {
                        UsersHandler(result.Message);
                    }
                    else if (result.Message.Command == Command.None)
                    {
                        MessageHandler(result.Message);
                    }
                }
                catch (Exception ex)
                {
                    await Console.Out.WriteAsync(ex.Message);
                }

            }
        }

        private void MessageHandler(Messages message)
        {
            Console.WriteLine($"{_users.First(u => u.Id == message.FromUserId)}: {message.Text}");
        }

        private void UsersHandler(Messages message)
        {
            _users = message.Users;
        }

        private void JoinHandler(Messages message)
        {
            _user.Id = message.FromUserId;
            Console.WriteLine("Join Success");
        }
    }
}
