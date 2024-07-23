using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace App.Contracts.Extentions
{
    public static class MessagesExtension
    {

        public static Messages? BytesToMessage(this byte[] data)
        {
            var options = new JsonSerializerOptions()
            {
                NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString
            };
            return JsonSerializer.Deserialize<Messages>(Encoding.UTF8.GetString(data), options);
            
        }

        public static byte[] MessageToBytes(this Messages message)
        {
            var options = new JsonSerializerOptions()
            {
                NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString
            };
            return Encoding.UTF8.GetBytes(JsonSerializer.Serialize(message, options));
        }
    }
}
