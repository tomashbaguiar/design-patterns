namespace DesignPatterns.SolidPrinciples.OpenClosed.Correct;

public interface ISpecification<T>
{
    bool IsSatisfied(T type);
}