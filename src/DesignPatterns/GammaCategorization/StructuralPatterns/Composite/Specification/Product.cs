using DesignPatterns.SolidPrinciples.OpenClosed.Wrong;

namespace DesignPatterns.GammaCategorization.StructuralPatterns.Composite.Specification;

public class Product
{
    public string Name;
    public Color Color;
    public Size Size;

    public Product(string name, Color color, Size size)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentNullException(paramName: nameof(name));

        Name = name;
        Color = color;
        Size = size;
    }
}