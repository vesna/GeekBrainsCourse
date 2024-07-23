using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatDB
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<MessageEntity> ToMessages { get; set; } = new List<MessageEntity>();
        public virtual ICollection<MessageEntity> FromMessages { get; set; } = new List<MessageEntity>();

    }
}
