namespace DesignPatterns.GammaCategorization.StructuralPatterns.Composite.Specification;

// Combinator
public class AndSpecification<T> : CompositeSpecification<T>
{
    public AndSpecification(params Specification<T>[] items) : base(items)
    {
    }
    
    public override bool IsSatisfied(T type)
    {
        return _items.All(i => i.IsSatisfied(type));
    }
}