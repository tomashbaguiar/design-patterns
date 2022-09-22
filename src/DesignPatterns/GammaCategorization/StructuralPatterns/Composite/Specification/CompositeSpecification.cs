namespace DesignPatterns.GammaCategorization.StructuralPatterns.Composite.Specification;

public abstract class CompositeSpecification<T> : Specification<T>
{
    protected readonly Specification<T>[] _items;

    public CompositeSpecification(params Specification<T>[] items)
    {
        _items = items;
    }
}