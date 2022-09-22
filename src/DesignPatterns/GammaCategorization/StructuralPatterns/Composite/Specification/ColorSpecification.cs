using DesignPatterns.SolidPrinciples.OpenClosed.Wrong;

namespace DesignPatterns.SolidPrinciples.OpenClosed.Correct;

public class ColorSpecification : ISpecification<Product>
{
    private readonly Color _color;

    public ColorSpecification(Color color)
    {
        _color = color;
    }
    
    public bool IsSatisfied(Product product)
    {
        return product.Color == _color;
    }
}