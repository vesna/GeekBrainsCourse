using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework003
{
    internal class FamilyMember
    {
        public string Name { get; set; }
        public FamilyMemberType MemberType { get; set; }
        public FamilyMember? Mother { get; set; }
        public FamilyMember? Father { get; set; }
        public FamilyMember? Partner { get; set; }
        public FamilyMember[]? Children { get; set; }        
        public FamilyMember(string name, FamilyMemberType familyMemberType) {
            this.Name = name;
            this.MemberType = familyMemberType;
        }

        public string CloseRelevants()
        {
            string result = string.Empty;
            
            if (Partner == null && Children == null)
                result = "Нет близких родственников";
            else
            {
                StringBuilder sb = new StringBuilder("Близкие родственники ");
                sb.Append(Name);
                sb.Append('\n');
                if (Partner != null)
                {
                    if (MemberType == FamilyMemberType.Man)
                        sb.Append("Муж: ");
                    else
                        sb.Append("Жена: ");
                    sb.Append(Partner.Name);
                    sb.Append('\n');
                }
                if (Children != null)
                {
                    sb.Append("Дети: ");
                    foreach (var child in Children)
                    {
                        sb.Append(child.Name);
                        sb.Append(' ');
                    }
                }
                result = sb.ToString();
            }
            
            return result;
        }
    }

    public enum FamilyMemberType { Man, Woman }
}
