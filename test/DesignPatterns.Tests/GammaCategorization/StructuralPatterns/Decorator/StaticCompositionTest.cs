using DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.StaticComposition;

namespace DesignPatterns.Tests.GammaCategorization.StructuralPatterns.Decorator;

public class StaticCompositionTest
{
    [Fact]
    public void Color()
    {
        const string expected = "A square with side 0 has the color Black";
        
        var redSquare = new ColoredShape<Square>();
        
        Assert.Matches(expected, redSquare.AsString());
    }
    
    [Fact]
    public void Transparency()
    {
        const float transparency = 0.4f;
        var expected = $"A circle with radius 0 has the color Black has transparency {transparency * 100.0}%";

        var transparentColoredCircle = new TransparentShape<ColoredShape<Circle>>(transparency);
        
        Assert.Matches(expected, transparentColoredCircle.AsString());
    }
}