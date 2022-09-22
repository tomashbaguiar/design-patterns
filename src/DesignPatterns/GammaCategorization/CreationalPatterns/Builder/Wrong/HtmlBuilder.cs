using System.Text;

namespace DesignPatterns.GammaCategorization.CreationalPatterns.Builder.Wrong;

public static class HtmlBuilder
{
    public static string BuildHtmlString(IEnumerable<string> words)
    {
        var sb = new StringBuilder();
        sb.Append("<ul>");
        foreach (var word in words)
        {
            sb.Append($"<li>{word}</li>");
        }

        sb.Append("</ul>");
        return sb.ToString();
    }
}