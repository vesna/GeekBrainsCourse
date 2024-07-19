using DBTest.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DBTest
{
    public static class MessageSource 
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
