using ChatCommon;
using System.Net;

namespace ChatNetwork
{
    public interface IMessageSource<T>
    {
        public void Send(Message message, T toAddr);
        public Message Receive(ref T fromAddr);
        public T CreateNewT();
        public T CopyT(T t);
    }

}
