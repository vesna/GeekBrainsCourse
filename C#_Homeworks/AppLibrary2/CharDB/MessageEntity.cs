using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatDB
{
    public class MessageEntity
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Received { get; set; }
        public int? ToUserId { get; set; }
        public int? FromUserId { get; set; }
        public virtual UserEntity? ToUser { get; set; }
        public virtual UserEntity? FromUser { get; set; }
    }
}
