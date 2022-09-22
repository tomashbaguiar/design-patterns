namespace DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.DynamicComposition;

public class Circle : Shape
{
    private float _radius;

    public Circle(float radius)
    {
        _radius = radius;
    }

    public void Resize(float factor)
    {
        _radius *= factor;
    }

    public override string AsString() => $"A circle with radius {_radius}";
}