namespace DesignPatterns.SolidPrinciples.OpenClosed.Wrong;

public static class ProductFilter
{
    public static IEnumerable<Product> FilterBySize(this IEnumerable<Product> products, Size size)
    {
        return products.Where(product => product.Size == size);
    }
    
    public static IEnumerable<Product> FilterByColor(this IEnumerable<Product> products, Color color)
    {
        return products.Where(product => product.Color == color);
    }
    
    public static IEnumerable<Product> FilterBySizeAndColor(this IEnumerable<Product> products, Size size, Color color)
    {
        return products.Where(product => product.Color == color && product.Size == size);
    }
}