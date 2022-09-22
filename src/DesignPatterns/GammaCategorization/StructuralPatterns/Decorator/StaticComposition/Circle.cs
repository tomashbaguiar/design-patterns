namespace DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.StaticComposition;

public class Circle : Shape
{
    private readonly float _radius;

    public Circle() : this(0)
    {
    }

    public Circle(float radius)
    {
        _radius = radius;
    }

    public override string AsString() => $"A circle with radius {_radius}";
}