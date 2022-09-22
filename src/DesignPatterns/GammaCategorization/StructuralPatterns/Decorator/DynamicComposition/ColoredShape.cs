namespace DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.DynamicComposition;

public class ColorShape : IShape
{
    private IShape _shape;
    private string _color;

    public ColorShape(IShape shape, string color)
    {
        _shape = shape;
        _color = color;
    }

    public string AsString() => $"{_shape.AsString()} has the color {_color}";
}