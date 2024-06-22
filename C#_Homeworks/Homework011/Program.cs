
using System.Text.Json;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        string fileJson = "{\"Comment\":\"My comment\",\"Count\":10,\"DiskParam\":{\"DB\":10.000000,\"DBAngle\":1.234000},\"Range\":true,\"Blades\":[{\"Caption\":\"A\",\"Value\":65},{\"Caption\":\"B\",\"Value\":66},{\"Caption\":\"C\",\"Value\":67}],\"Slots\":[0,1,2]}";
        
        using (JsonDocument doc = JsonDocument.Parse(fileJson))
        {
            XmlElement root = CreateXmlElement(doc.RootElement);

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.AppendChild(xmlDocument.ImportNode(root,true));
            xmlDocument.Save("output.xml");
        }
    }

    private static XmlElement CreateXmlElement(JsonElement jsonElement)
    {
        XmlDocument xmlDocument = new XmlDocument();
        XmlElement elem = xmlDocument.CreateElement(jsonElement.ValueKind.ToString());

        switch (jsonElement.ValueKind)
        {
            case JsonValueKind.Object:
                foreach (var prop in jsonElement.EnumerateObject())
                {
                    XmlElement propElement = CreateXmlElement(prop.Value);
                    propElement.SetAttribute("name", prop.Name);
                    XmlNode importNode = elem.OwnerDocument.ImportNode(propElement, true);
                    elem.AppendChild(importNode);
                }
                break;
            case JsonValueKind.Array:
                foreach (var arr in jsonElement.EnumerateArray())
                {
                    XmlElement arrItemElement = CreateXmlElement(arr);
                    XmlNode importNode = elem.OwnerDocument.ImportNode(arrItemElement, true);
                    elem.AppendChild(importNode);
                }
                break;
            case JsonValueKind.String:
                elem.InnerText = jsonElement.GetString();
                break;
            case JsonValueKind.Number:
            case JsonValueKind.True:
            case JsonValueKind.False:
                elem.InnerText = jsonElement.GetRawText();
                break;
            case JsonValueKind.Null:
                elem.SetAttribute("null", "true");
                break;
        }
        return elem;
    }
}