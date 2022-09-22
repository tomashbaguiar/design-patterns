namespace DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.DynamicComposition;

public abstract class ShapeDecorator : Shape
{
    protected internal readonly List<Type> Types = new();
    protected internal Shape Shape;

    protected ShapeDecorator(Shape shape)
    {
        Shape = shape;
        if (Shape is ShapeDecorator sd)
            Types.AddRange(sd.Types);
    }
}

public abstract class ShapeDecorator<TSelf, TCyclePolicy> : ShapeDecorator 
    where TCyclePolicy : ShapeDecoratorCyclePolicy, new()
{
    protected internal readonly TCyclePolicy Policy = new();

    protected ShapeDecorator(Shape shape) : base(shape)
    {
        if (Policy.TypeAdditionAllowed(typeof(TSelf), Types))
            Types.Add(typeof(TSelf));
    }
}