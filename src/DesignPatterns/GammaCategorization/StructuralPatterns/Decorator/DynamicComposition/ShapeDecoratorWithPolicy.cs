namespace DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.DynamicComposition;

public class ShapeDecoratorWithPolicy<T> : ShapeDecorator<Type, ThrowOnCyclePolicy>
{
    public ShapeDecoratorWithPolicy(Shape shape) : base(shape)
    {
    }
}