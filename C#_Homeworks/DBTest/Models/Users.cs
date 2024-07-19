using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTest.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Messages> ToMessages { get; set; } = new List<Messages>();
        public virtual ICollection<Messages> FromMessages { get; set; } = new List<Messages>();

    }
}
