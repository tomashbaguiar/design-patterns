namespace DesignPatterns.SolidPrinciples.OpenClosed.Correct;

public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specification);
}