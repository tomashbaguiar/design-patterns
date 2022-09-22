namespace DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.DynamicComposition;

public class CycleAllowedPolicy : ShapeDecoratorCyclePolicy
{
    public override bool TypeAdditionAllowed(Type type, IList<Type> allTypes)
    {
        return true;
    }

    public override bool ApplicationAllowed(Type type, IList<Type> allTypes)
    {
        return true;
    }
}