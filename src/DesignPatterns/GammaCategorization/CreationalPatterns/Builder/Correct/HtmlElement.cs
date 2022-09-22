using System.Text;

namespace DesignPatterns.GammaCategorization.CreationalPatterns.Builder.Correct;

public class HtmlElement
{
    public string Name;
    public string Text;
    public List<HtmlElement> Elements = new();
    private const int IndentSize = 2;

    public HtmlElement() { }

    public HtmlElement(string name, string text)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Text = text ?? throw new ArgumentNullException(nameof(text));
    }

    private string ToStringImpl(int indent)
    {
        var sb = new StringBuilder();
        var iLevel = new string(' ', IndentSize * indent);
        sb.Append($"{iLevel}<{Name}>\n");

        if (!string.IsNullOrWhiteSpace(Text))
        {
            sb.Append(new string(' ', IndentSize * (indent + 1)) + Text + "\n");
        }

        foreach (var element in Elements)
        {
            sb.Append(element.ToStringImpl(indent + 1));
        }
        sb.Append($"{iLevel}</{Name}>\n");
        
        return sb.ToString();
    }

    public override string ToString()
    {
        return ToStringImpl(0);
    }
}