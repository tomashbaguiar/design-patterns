namespace DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.DynamicComposition;

public class Square : Shape
{
    private readonly float _side;

    public Square(float side)
    {
        _side = side;
    }

    public override string AsString()
    {
        return $"A square with side {_side}";
    }
}