namespace Homework018.Models
{
    public class Messages
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Received { get; set; }
        public int? ToUserId { get; set; }
        public int? FromUserId { get; set; }
        public virtual Users? ToUser { get; set; }
        public virtual Users? FromUser { get; set; }
    }
}
