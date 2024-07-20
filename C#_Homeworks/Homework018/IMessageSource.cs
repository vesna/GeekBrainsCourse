using System.Net;

namespace Homework018
{
    public interface IMessageSource
    {
        public async Task<MessageUDP> ReceiveAsync() {  return new MessageUDP(); }

        public async Task SendAsync(MessageUDP massage, IPEndPoint iPEndPoint) { }
    }
}
