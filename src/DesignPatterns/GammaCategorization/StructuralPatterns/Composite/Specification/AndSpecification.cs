namespace DesignPatterns.SolidPrinciples.OpenClosed.Correct;

public class AndSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> _first;
    private readonly ISpecification<T> _second;

    public AndSpecification(ISpecification<T> first, ISpecification<T> second)
    {
        _first = first ?? throw new ArgumentNullException(nameof(first));
        _second = second ?? throw new ArgumentNullException(nameof(second));
    }

    public bool IsSatisfied(T type)
    {
        return _first.IsSatisfied(type) && _second.IsSatisfied(type);
    }
}