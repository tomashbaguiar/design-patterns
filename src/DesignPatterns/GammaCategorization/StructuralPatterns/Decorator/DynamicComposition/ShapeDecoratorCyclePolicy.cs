namespace DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.DynamicComposition;

public abstract class ShapeDecoratorCyclePolicy
{
    public abstract bool TypeAdditionAllowed(Type type, IList<Type> allTypes);
    public abstract bool ApplicationAllowed(Type type, IList<Type> allTypes);
}