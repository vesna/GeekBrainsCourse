using System.Text.Json;

namespace ChatCommon
{
    public class Message
    {
        public Command Command { get; set; }
        public int? Id { get; set; }
        public string FromName { get; set; }
        public string ToName { get; set; }
        public string Text { get; set; }

        // Метод для сериализации в JSON
        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        // Статический метод для десериализации JSON в объект MyMessage
        public static Message FromJson(string json)
        {
            return JsonSerializer.Deserialize<Message>(json);
        }

        public override string ToString()
        {
            return $"{DateTime.Now} \n Получено сообщение {Text} \n от {FromName} ";
        }

    }
}
