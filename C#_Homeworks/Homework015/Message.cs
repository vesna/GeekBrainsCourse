using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Homework015
{
    internal class Message
    {
        public string FromName { get; set; }
        public string ToName { get; set; }
        public string Text { get; set; }
        public DateTime STime { get; set; }

        public Message()
        {
            FromName = string.Empty;
            Text = string.Empty;
            STime = DateTime.Now;
        }

        public Message(string name, string text)
        {
            FromName = name;
            Text = text;
            STime = DateTime.Now;
        }

        public string ToJson()
        {
           return JsonSerializer.Serialize(this);
        }

        public static Message? FromJson(string text)
        {
            return JsonSerializer.Deserialize<Message>(text);
        }

        public override string ToString()
        {
            return $"Получено сообщение от {FromName} ({STime}): \n {Text}";
        }
    }
}
