namespace DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.DynamicComposition;

public class TransparentShape : ShapeDecorator<TransparentShape, ThrowOnCyclePolicy> 
{
    private readonly float _transparency;

    public TransparentShape(Shape shape, float transparency) : base(shape)
    {
        Shape = shape;
        _transparency = transparency;
    }

    public new string AsString()
    {
        return $"{Shape.AsString()} has {_transparency * 100.0}% transparency";
    }
}