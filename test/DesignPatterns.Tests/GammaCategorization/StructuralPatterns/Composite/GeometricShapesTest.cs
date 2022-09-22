using DesignPatterns.GammaCategorization.StructuralPatterns.Composite.GeometricShapes;

namespace DesignPatterns.Tests.GammaCategorization.StructuralPatterns.Composite;

public class GeometricShapesTest
{
    [Fact]
    public void Test()
    {
        const string expectedRegex = "My Drawing-Red Square-Yellow Circle-Group--Blue Circle--Blue Square";
        
        var drawing = new GraphicObject { Name = "My Drawing" };
        drawing.Children.Add(new Square { Color = "Red" });
        drawing.Children.Add(new Circle { Color = "Yellow" });

        var group = new GraphicObject();
        group.Children.Add(new Circle { Color = "Blue" });
        group.Children.Add(new Square { Color = "Blue" });
        drawing.Children.Add(group);
        
        Assert.Matches(expectedRegex, drawing.ToString());
    }
}