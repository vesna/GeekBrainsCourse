using Homework018;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TestChat
{
    public class MockMessageSource : IMessageSource
    { 
        private static Queue<MessageUDP> messages = new();

        public MockMessageSource()
        {
            messages.Enqueue(new MessageUDP { Command = Command.Register, FromName = "Вася" });
            messages.Enqueue(new MessageUDP { Command = Command.Register, FromName = "Юля" });
            messages.Enqueue(new MessageUDP { Command = Command.Message, FromName = "Юля", ToName = "Вася", Text = "От Юли" });
            messages.Enqueue(new MessageUDP { Command = Command.Message, FromName = "Вася", ToName = "Юля", Text = "От Васи" });
        }

        public static async Task<MessageUDP> ReceiveAsync()
        {
            return messages.Peek();
        }

        public async Task SendAsync(MessageUDP massage, IPEndPoint iPEndPoint)
        {
            messages.Enqueue((MessageUDP)massage);
        }
    }

    public class Tests
    {
        IMessageSource _messageSource = new MockMessageSource();
        IPEndPoint _endPoint;
        MessageUDP _message;
        [SetUp]
        public void Setup()
        {
            //_messageSource = new MockMessageSource();
            _endPoint = new IPEndPoint(IPAddress.Any, 0);
            _message = new MessageUDP();
        }

        [Test]
        public void TestRecieveMessage()
        {
            var result = _messageSource.ReceiveAsync();
            Assert.IsNotNull(result);
            Assert.IsNull(result.Result.Text);
            Assert.IsNotNull(result.Result.Id);
        }

        [Test]
        public void TestSendMessage()
        {
            var result = _messageSource.SendAsync(_message, _endPoint);
            Assert.IsNotNull(result);

        }
    }
}