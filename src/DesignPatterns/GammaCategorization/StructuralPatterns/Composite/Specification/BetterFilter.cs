using DesignPatterns.SolidPrinciples.OpenClosed.Wrong;

namespace DesignPatterns.SolidPrinciples.OpenClosed.Correct;

public class BetterFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> products, ISpecification<Product> specification)
    {
        return products.Where(specification.IsSatisfied);
    }
}