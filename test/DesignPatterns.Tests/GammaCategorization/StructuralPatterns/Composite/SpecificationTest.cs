using DesignPatterns.GammaCategorization.StructuralPatterns.Composite.Specification;

namespace DesignPatterns.Tests.GammaCategorization.StructuralPatterns.Composite;

public class SpecificationTest
{
    [Fact]
    public void FilterByColor_Right()
    {
        var apple = new Product("Apple", Color.Green, Size.Small);
        var tree = new Product("Tree", Color.Green, Size.Large);
        var house = new Product("House", Color.Blue, Size.Large);
        var products = new List<Product> { apple, tree, house };
        var filter = new BetterFilter();
        var specification = new ColorSpecification(Color.Green);

        var greenProducts = filter.Filter(products, specification).ToList();

        Assert.Contains(apple, greenProducts);
        Assert.Contains(tree, greenProducts);
        Assert.DoesNotContain(house, greenProducts);
    }
    
    [Fact]
    public void FilterBySize_Right()
    {
        var apple = new Product("Apple", Color.Green, Size.Small);
        var tree = new Product("Tree", Color.Green, Size.Large);
        var house = new Product("House", Color.Blue, Size.Large);
        var products = new List<Product> { apple, tree, house };
        var filter = new BetterFilter();
        var specification = new SizeSpecification(Size.Large);

        var greenProducts = filter.Filter(products, specification).ToList();

        Assert.DoesNotContain(apple, greenProducts);
        Assert.Contains(tree, greenProducts);
        Assert.Contains(house, greenProducts);
    }
    
    [Fact]
    public void FilterBySizeAndColor_Right()
    {
        var apple = new Product("Apple", Color.Green, Size.Small);
        var tree = new Product("Tree", Color.Green, Size.Large);
        var house = new Product("House", Color.Blue, Size.Large);
        var products = new List<Product> { apple, tree, house };
        var filter = new BetterFilter();
        var sizeSpecification = new SizeSpecification(Size.Large);
        var colorSpecification = new ColorSpecification(Color.Green);
        var specification = new AndSpecification<Product>(sizeSpecification, colorSpecification);

        var largeGreenProducts = filter.Filter(products, specification).ToList();
        
        Assert.DoesNotContain(house, largeGreenProducts);
        Assert.Contains(tree, largeGreenProducts);
        Assert.DoesNotContain(apple, largeGreenProducts);
    }
}