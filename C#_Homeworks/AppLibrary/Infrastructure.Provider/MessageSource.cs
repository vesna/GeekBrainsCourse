using App.Contracts;
using App.Contracts.Extentions;
using System.Net;
using System.Net.Sockets;

namespace Infrastructure.Provider
{
    public interface IMessageSource
    {
        public Task<RecieveResult> Receive(CancellationToken cancellationToken);

        public Task Send(Messages massage, IPEndPoint iPEndPoint, CancellationToken cancellationToken);

     //   public IPEndPoint CreateNewEndPoint(string addres, string port);

     //   public IPEndPoint GetServerEndPoint();
    }

    public class MessageSource : IMessageSource
    {
        private readonly UdpClient _udpClient;

        public MessageSource(UdpClient udpClient)
        {
            _udpClient = udpClient;
        }

        public async Task<RecieveResult> Receive(CancellationToken cancellationToken)
        {
            var data =  await _udpClient.ReceiveAsync(cancellationToken);
            return new(data.RemoteEndPoint, data.Buffer.BytesToMessage());
        }

        public async Task Send(Messages massage, IPEndPoint iPEndPoint, CancellationToken cancellationToken)
        {
            await _udpClient.SendAsync(massage.MessageToBytes(), iPEndPoint, cancellationToken);
        }
    }
}
