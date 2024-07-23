using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class MessageEntity
    {
        [Key]public int Id { get; set; }
        public required string Text { get; set; }
        public int ToUserId { get; set; }
        public int FromUserId { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
