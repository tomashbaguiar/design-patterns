using Wrong = DesignPatterns.SolidPrinciples.LiskovSubstitution.Wrong;
using Correct = DesignPatterns.SolidPrinciples.LiskovSubstitution.Correct;

namespace DesignPatterns.Tests.SolidPrinciples.LiskovSubstitution;

public class RectangleTest
{
    [Fact]
    public void RectangleAndSquare_Wrong()
    {
        Wrong.Rectangle rectangle = new Wrong.Square();
        rectangle.Width = 4;
        var square = new Wrong.Square { Width = 4 };

        Assert.DoesNotMatch($"{rectangle} area = 9", $"{rectangle} area = {Area(rectangle)}");
        Assert.Matches($"{square} area = 16", $"{square} area = {Area(square)}");
    }
    
    [Fact]
    public void RectangleAndSquare_Correct()
    {
        Correct.Rectangle rectangle = new Correct.Square();
        rectangle.Width = 3;
        var square = new Correct.Square { Width = 4 };

        Assert.Matches($"{rectangle} area = 9", $"{rectangle} area = {Area(rectangle)}");
        Assert.Matches($"{square} area = 16", $"{square} area = {Area(square)}");
    }

    private static int Area(Wrong.Rectangle rectangle) => rectangle.Height * rectangle.Width;
    
    private static int Area(Correct.Rectangle rectangle) => rectangle.Height * rectangle.Width;
}