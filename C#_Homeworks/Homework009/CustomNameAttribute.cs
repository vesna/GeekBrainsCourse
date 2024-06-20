using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework009
{
    internal class CustomNameAttribute : Attribute
    {
        public int CustomFieldName { get; set; }
        public CustomNameAttribute(int val) => CustomFieldName = val;
    }
}
