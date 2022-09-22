using DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.DynamicComposition;

namespace DesignPatterns.Tests.GammaCategorization.StructuralPatterns.Decorator;

public class DynamicCompositionTest
{
    [Fact]
    public void Square()
    {
        const float side = 1.23f;
        const string color = "Red";
        const float transparency = 0.4f;
        var expected = $"A square with side {side} has the color {color} has {transparency * 100.0}% transparency";
        
        var square = new Square(side);
        var redSquare = new ColoredShape(square, color);
        var transparentRedSquare = new TransparentShape(redSquare, transparency);
        
        Assert.Matches(expected, transparentRedSquare.AsString());
    }
    
    [Fact]
    public void Square_DetectingDecoratorCircles()
    {
        const float side = 1.23f;
        const string color = "Red";
        
        var square = new Square(side);
        var redSquare = new ColoredShape(square, color);

        Assert.Throws<InvalidOperationException>(() => new ColoredShape(redSquare, string.Empty));
    }
}