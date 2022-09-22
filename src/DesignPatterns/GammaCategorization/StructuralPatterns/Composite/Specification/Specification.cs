namespace DesignPatterns.GammaCategorization.StructuralPatterns.Composite.Specification;

public abstract class Specification<T>
{
    public abstract bool IsSatisfied(T type);

    public static Specification<T> operator &(Specification<T> first, Specification<T> second)
    {
        return new AndSpecification<T>(first, second);
    }
}