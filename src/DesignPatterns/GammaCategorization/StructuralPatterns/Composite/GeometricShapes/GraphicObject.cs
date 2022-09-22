using System.Text;

namespace DesignPatterns.GammaCategorization.StructuralPatterns.Composite;

public class GraphicObject
{
    public virtual string Name { get; set; } = "Group";
    public string Color;

    private readonly Lazy<List<GraphicObject>> _children = new();
    public List<GraphicObject> Children => _children.Value;

    private void Print(StringBuilder stringBuilder, int depth)
    {
        stringBuilder.Append('-', depth)
            .Append(string.IsNullOrWhiteSpace(Color) ? string.Empty : $"{Color} ")
            .Append(Name);
        foreach (var child in Children)
        {
            child.Print(stringBuilder, depth + 1);
        }
    }
    
    public override string ToString()
    {
        var sb = new StringBuilder();
        Print(sb, 0);
        return sb.ToString();
    }
}