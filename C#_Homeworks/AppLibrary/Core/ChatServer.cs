using App.Contracts;
using Domain;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Provider;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Core
{
    public class ChatServer : ChartBase
    {
        private readonly IMessageSource _messageSource;
        private readonly ChatContext _chatContext;
        private HashSet<Users> _users = [];


        public ChatServer(IMessageSource messageSource, ChatContext context)
        {
            _messageSource = messageSource;
            _chatContext = context;
        }

        public override async Task Lissener()
        {
            Console.WriteLine("UDP Клиент ожидает сообщений...");
            while (!CancellationToken.IsCancellationRequested)
            {
                try
                {
                    var result = (await _messageSource.Receive(CancellationToken)) ?? throw new Exception("Message is null");

                    switch (result.Message!.Command)
                    {
                        case Command.None:
                            await MessageHandler(result);
                            break;
                        case Command.Join: 
                            await JoinHandler(result);
                            break;
                        case Command.Exit:
                            await ExitHendler(result);
                            break;
                        case Command.Users: break;
                        case Command.Confirm: break;
                    }
                    
                }
                catch (Exception ex)
                {
                    await Console.Out.WriteAsync(ex.Message);
                }

            }
        }

        private async Task ExitHendler(RecieveResult result)
        {
            var user  = Users.FromDomain(await _chatContext.Users.FirstAsync(x => x.Id == result.Message!.FromUserId));
            user.LastOnline = DateTime.Now;
            await _chatContext.SaveChangesAsync();

            _users.Remove(_users.First(x => x.Id == result.Message!.FromUserId));
        }

        private async Task MessageHandler(RecieveResult result)
        {
            if (result.Message!.ToUserId == null || result.Message!.ToUserId < 0) { 
                await SendAllAsync(result.Message);
            }
            else
            {
                await _messageSource.Send(result.Message, _users.First(u => u.Id == result.Message.FromUserId).EndPoint!, CancellationToken);
                var recipEndPoint = _users.FirstOrDefault(u => u.Id == result.Message.FromUserId)?.EndPoint;
                if (recipEndPoint != null)
                {
                    await _messageSource.Send(result.Message, recipEndPoint, CancellationToken);
                }
            }
        }

        public override async Task Start()
        {
            await Task.CompletedTask;
            await Task.Run(Lissener);
        }

        private async Task JoinHandler(RecieveResult result)
        {
            Users? user = _users.FirstOrDefault(u => u.Name == result.Message!.Text);
            if (user == null)
            {
                user = new Users { Name = result.Message!.Text };
                _users.Add(user);
            }
            user.EndPoint = result.EndPoint;

            if (_chatContext.Users.FirstOrDefault(x => x.Name == user.Name) == null)
            {
                await _chatContext.AddAsync(Users.ToDomain(user));
                await _chatContext.SaveChangesAsync();
                Console.WriteLine("Join Success");
            }

            await _messageSource.Send(new Messages() { Command = Command.Join, ToUserId = user.Id }, user.EndPoint, CancellationToken);

            await SendAllAsync(new Messages() { Command = Command.Confirm, Text = $"{user.Name} joine to chat" });
            await SendAllAsync(new Messages() { Command = Command.Users, ToUserId = user.Id, Users = _users });

            var unreaded = await _chatContext.Messages.Where(x => x.ToUserId == user.Id).ToListAsync();

            foreach (var message in unreaded)
            {
                await _messageSource.Send(Messages.FromDomain(message), user.EndPoint, CancellationToken);
            }
        }

        private async Task SendAllAsync(Messages message)
        {
            foreach (var user in _users)
            {
                await _messageSource.Send(message, user.EndPoint, CancellationToken);
            }
        }
    }
}
