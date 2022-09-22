using System.Text;

namespace DesignPatterns.GammaCategorization.StructuralPatterns.Flyweight.TextEditing;

public class FormattedText
{
    private readonly string _plainText;
    private bool[] _capitalize;

    public FormattedText(string plainText)
    {
        _plainText = plainText;
        _capitalize = new bool[plainText.Length];
    }

    public void Capitalize(int start, int end)
    {
        for (var i = start; i <= end; i++)
            _capitalize[i] = true;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        for (var i = 0; i < _plainText.Length; i++)
        {
            var c = _plainText[i];
            sb.Append(_capitalize[i] ? char.ToUpper(c) : c);
        }

        return sb.ToString();
    }
}