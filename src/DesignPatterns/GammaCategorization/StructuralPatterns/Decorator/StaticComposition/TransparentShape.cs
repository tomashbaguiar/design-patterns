namespace DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.StaticComposition;

public class TransparentShape : Shape
{
    private readonly Shape _shape;
    private readonly float _transparency;

    public TransparentShape(Shape shape, float transparency)
    {
        _shape = shape;
        _transparency = transparency;
    }

    public override string AsString() => $"{_shape.AsString()} has transparency {_transparency * 100.0}%";
}

public class TransparentShape<T> : Shape where T : Shape, new()
{
    private readonly T _shape = new();
    private readonly float _transparency;

    public TransparentShape() : this(0)
    {
    }

    public TransparentShape(float transparency)
    {
        _transparency = transparency;
    }
    
    public override string AsString() => $"{_shape.AsString()} has transparency {_transparency * 100.0}%";
}