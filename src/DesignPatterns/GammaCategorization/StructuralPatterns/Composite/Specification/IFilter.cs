namespace DesignPatterns.GammaCategorization.StructuralPatterns.Composite.Specification;

public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, Specification<T> specification);
}