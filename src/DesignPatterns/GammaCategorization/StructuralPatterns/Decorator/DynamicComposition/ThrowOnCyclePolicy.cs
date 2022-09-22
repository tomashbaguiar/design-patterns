namespace DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.DynamicComposition;

public class ThrowOnCyclePolicy : ShapeDecoratorCyclePolicy
{
    private bool Handler(Type type, IList<Type> allTypes)
    {
        if (allTypes.Contains(type))
            throw new InvalidOperationException($"Cycle detected! Type is already a {type.FullName}!");
        return true;
    }
    
    public override bool TypeAdditionAllowed(Type type, IList<Type> allTypes)
    {
        return Handler(type, allTypes);
    }

    public override bool ApplicationAllowed(Type type, IList<Type> allTypes)
    {
        return Handler(type, allTypes);
    }
}