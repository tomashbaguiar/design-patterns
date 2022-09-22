using System.Text;

namespace DesignPatterns.GammaCategorization.StructuralPatterns.Flyweight.TextEditing;

public class BetterFormattedText
{
    private readonly string _plainText;
    private readonly List<TextRange> _formatting = new();

    public BetterFormattedText(string plainText)
    {
        _plainText = plainText;
    }

    public TextRange GetRange(int start, int end)
    {
        var range = new TextRange
        {
            Start = start,
            End = end,
        };
        _formatting.Add(range);
        return range;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        for (var i = 0; i < _plainText.Length; i++)
        {
            var c = _plainText[i];
            _formatting.ForEach(range =>
            {
                if (range.Covers(i) && range.Capitalize)
                    c = char.ToUpper(c);
                sb.Append(c);
            });
        }

        return sb.ToString();
    }

    public class TextRange
    {
        public int Start;
        public int End;
        public bool Capitalize;
        public bool Bold;
        public bool Italic;

        public bool Covers(int position)
        {
            return position >= Start && position <= End;
        }
    }
}