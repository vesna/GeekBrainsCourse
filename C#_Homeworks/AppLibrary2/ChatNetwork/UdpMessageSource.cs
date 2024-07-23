using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ChatCommon;

namespace ChatNetwork
{
    public class UdpMessageSource : IMessageSource<IPEndPoint>
    {
        private UdpClient udpClient;

        public UdpMessageSource()
        {
            udpClient = new UdpClient(12345);
          
        }

        public IPEndPoint CopyT(IPEndPoint t)
        {
            return new IPEndPoint(t.Address, t.Port);
        }

        public IPEndPoint CreateNewT()
        {
            return new IPEndPoint(IPAddress.Any, 0);
        }

        public Message Receive(ref IPEndPoint ep)
        {
            byte[] receiveBytes = udpClient.Receive(ref ep);
            string receivedData = Encoding.ASCII.GetString(receiveBytes);

            return Message.FromJson(receivedData);
        }

        public void Send(Message message, IPEndPoint ep)
        {
            byte[] forwardBytes = Encoding.ASCII.GetBytes(message.ToJson());

            udpClient.Send(forwardBytes, forwardBytes.Length, ep);
        }
    }


}
