using ChatCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatNetwork
{
    public interface IMessageSourceClient<T>
    {
        public void Send(Message message, T toAddr);
        public Message Receive(ref T fromAddr);
        public T CreateNewT();
        public T GetServer();
    }

}
