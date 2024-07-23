using App.Contracts.Converters;
using Domain;
using System.Text.Json.Serialization;

namespace App.Contracts
{
    public class Messages
    {
        //[JsonConverter(typeof(IntToStringConverter))]
        public int Id { get; set; } = -1;
        public string Text { get; set; }
        public bool Received { get; set; }
        //[JsonConverter(typeof(IntToStringConverter))]
        public int ToUserId { get; set; } = -1;
        //[JsonConverter(typeof(IntToStringConverter))]
        public int FromUserId { get; set; } = -1;
        public DateTime Created { get; set; } = DateTime.Now;
        public Command Command { get; set; } = Command.None;
        public IEnumerable<Users> Users { get; set; } = [];

        public static Messages FromDomain(MessageEntity message) => new Messages
        {
            Id = message.Id,
            ToUserId = message.ToUserId,
            FromUserId = message.FromUserId,
            Created = message.Created
        };
    }
}
