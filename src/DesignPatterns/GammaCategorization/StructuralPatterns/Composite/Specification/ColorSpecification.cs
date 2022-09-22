namespace DesignPatterns.GammaCategorization.StructuralPatterns.Composite.Specification;

public class ColorSpecification : Specification<Product>
{
    private readonly Color _color;

    public ColorSpecification(Color color)
    {
        _color = color;
    }
    
    public override bool IsSatisfied(Product product)
    {
        return product.Color == _color;
    }
}