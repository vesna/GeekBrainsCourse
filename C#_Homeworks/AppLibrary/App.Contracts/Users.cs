using App.Contracts.Converters;
using Domain;
using System.Net;
using System.Text.Json.Serialization;

namespace App.Contracts
{
    public record Users
    {
        //[JsonConverter(typeof(IntToStringConverter))]
        public int Id { get; set; } = -1;
        public string Name { get; set; }
        public DateTime LastOnline { get; set; } = DateTime.Now;

        [JsonIgnore]
        public IPEndPoint? EndPoint { get; set; }

        public static Users FromDomain(UserEntity entity)
        {
            return new Users
            {
                Id = entity.Id,
                Name = entity.Name,
                LastOnline = entity.LastOnline
            };
        }

        public static UserEntity ToDomain(Users user)
        {
            return new UserEntity
            {
                Name = user.Name
            };
        }
    }
}
