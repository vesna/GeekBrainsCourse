using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Homework018
{
    public class MessageSource : IMessageSource
    {
        private static readonly UdpClient udpClient = new UdpClient();

        public static async Task<MessageUDP> ReceiveAsync()
        {
            var buffer = await udpClient.ReceiveAsync();
            string str1 = Encoding.UTF8.GetString(buffer.Buffer);
            return MessageUDP.FromJson(str1);
        }

        public static async Task SendAsync(MessageUDP massage, IPEndPoint iPEndPoint)
        {
            var json = massage.ToJson();
            var data = Encoding.UTF8.GetBytes(json);
            await udpClient.SendAsync(data, iPEndPoint);
        }
    }
}
