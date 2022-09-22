namespace DesignPatterns.GammaCategorization.StructuralPatterns.Composite.Specification;

public class SizeSpecification : Specification<Product>
{
    private readonly Size _size;

    public SizeSpecification(Size size)
    {
        _size = size;
    }
    
    public override bool IsSatisfied(Product product)
    {
        return product.Size == _size;
    }
}