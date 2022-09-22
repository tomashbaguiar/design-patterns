using System.Xml.Serialization;

namespace DesignPatterns.GammaCategorization.CreationalPatterns.Prototype.Serialization;

public static class ExtensionMethods
{
    public static T DeepCopy<T>(this T self)
    {
        using var stream = new MemoryStream();
        var xmlSerializer = new XmlSerializer(typeof(T));
        xmlSerializer.Serialize(stream, self);
        stream.Seek(0, SeekOrigin.Begin);
        var copy = xmlSerializer.Deserialize(stream);
        return (T) copy;
    }
}