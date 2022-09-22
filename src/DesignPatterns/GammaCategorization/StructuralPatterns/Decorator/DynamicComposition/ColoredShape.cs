namespace DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.DynamicComposition;

public class ColoredShape : ShapeDecorator<ColoredShape, ThrowOnCyclePolicy> 
    // : ShapeDecoratorWithPolicy<ColoredShape>
{
    private string _color;

    public ColoredShape(Shape shape, string color) : base(shape)
    {
        Shape = shape;
        _color = color;
    }

    public override string AsString()
    {
        var stringBuilder = new System.Text.StringBuilder($"{Shape.AsString()}");

        if (Policy.ApplicationAllowed(Types.First(), Types.Skip(1).ToList()))
            stringBuilder.Append($" has the color {_color}");

        return stringBuilder.ToString();
    }
}