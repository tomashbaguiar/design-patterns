using DesignPatterns.GammaCategorization.CreationalPatterns.Builder.Correct;

namespace DesignPatterns.GammaCategorization.CreationalPatterns.Builder.Fluent;

public class HtmlBuilder
{
    private readonly string _rootName;
    private HtmlElement _root = new();

    public HtmlBuilder(string rootName)
    {
        _rootName = rootName;
        _root.Name = rootName;
    }

    public HtmlBuilder AddChild(string childName, string childText)
    {
        var element = new HtmlElement(childName, childText);
        _root.Elements.Add(element);
        return this;
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