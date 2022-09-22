using DesignPatterns.SolidPrinciples.OpenClosed.Correct;
using DesignPatterns.SolidPrinciples.OpenClosed.Wrong;

namespace DesignPatterns.Tests.SolidPrinciples.OpenClosed;

public class ProductTest
{
    #region NotCompliantWithOpenClosed
    
    [Fact]
    public void FilterByColor_Wrong()
    {
        var apple = new Product("Apple", Color.Green, Size.Small);
        var tree = new Product("Tree", Color.Green, Size.Large);
        var house = new Product("House", Color.Blue, Size.Large);
        var products = new List<Product> { apple, tree, house };

        var greenProducts = products.FilterByColor(Color.Green).ToList();

        Assert.Contains(apple, greenProducts);
        Assert.Contains(tree, greenProducts);
        Assert.DoesNotContain(house, greenProducts);
    }
    
    [Fact]
    public void FilterBySize_Wrong()
    {
        var apple = new Product("Apple", Color.Green, Size.Small);
        var tree = new Product("Tree", Color.Green, Size.Large);
        var house = new Product("House", Color.Blue, Size.Large);
        var products = new List<Product> { apple, tree, house };

        var greenProducts = products.FilterBySize(Size.Large).ToList();

        Assert.Contains(house, greenProducts);
        Assert.Contains(tree, greenProducts);
        Assert.DoesNotContain(apple, greenProducts);
    }
    
    [Fact]
    public void FilterBySizeAndColor_Wrong()
    {
        var apple = new Product("Apple", Color.Green, Size.Small);
        var tree = new Product("Tree", Color.Green, Size.Large);
        var house = new Product("House", Color.Blue, Size.Large);
        var products = new List<Product> { apple, tree, house };

        var largeGreenProducts = products.FilterBySizeAndColor(Size.Large, Color.Green).ToList();

        Assert.DoesNotContain(house, largeGreenProducts);
        Assert.Contains(tree, largeGreenProducts);
        Assert.DoesNotContain(apple, largeGreenProducts);
    }
    
    #endregion
    
    #region CompliantWithOpenClosed
    
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
    
    #endregion
}