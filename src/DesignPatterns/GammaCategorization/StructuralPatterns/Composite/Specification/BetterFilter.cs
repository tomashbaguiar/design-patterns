namespace DesignPatterns.GammaCategorization.StructuralPatterns.Composite.Specification;

public class BetterFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> products, Specification<Product> specification)
    {
        return products.Where(specification.IsSatisfied);
    }
}