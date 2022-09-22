namespace DesignPatterns.GammaCategorization.CreationalPatterns.Builder.Correct;

public class HtmlBuilder
{
    private readonly string _rootName;
    private HtmlElement _root = new();

    public HtmlBuilder(string rootName)
    {
        _rootName = rootName;
        _root.Name = rootName;
    }

    public void AddChild(string childName, string childText)
    {
        var element = new HtmlElement(childName, childText);
        _root.Elements.Add(element);
    }

    public override string ToString()
    {
        return _root.ToString();
    }

    public void Clear()
    {
        _root = new HtmlElement{ Name = _rootName };
    }
}