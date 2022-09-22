namespace DesignPatterns.SolidPrinciples.SingleResponsibility.Correct;

public class Journal
{
    private readonly List<string> _entries = new();
    private static int _count = 0;

    public int AddEntry(string entry)
    {
        _entries.Add($"{++_count}: {entry}");
        return _count;
    }
    
    public void RemoveEntry(int index)
    {
        _entries.RemoveAt(index);
    }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, _entries);
    }
}