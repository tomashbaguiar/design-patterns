namespace DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.StaticComposition;

public class ColoredShape : Shape
{
    private readonly Shape _shape;
    private readonly string _color;

    public ColoredShape(Shape shape, string color)
    {
        _shape = shape;
        _color = color;
    }

    public override string AsString() => $"{_shape.AsString()} has the color {_color}";
}

public class ColoredShape<T> : Shape where T : Shape, new()
{
    private readonly string _color;
    private readonly T _shape = new();

    public ColoredShape() : this("Black")
    {
    }
    
    public ColoredShape(string color)
    {
        _color = color;
    }

    public override string AsString() => $"{_shape.AsString()} has the color {_color}";
}