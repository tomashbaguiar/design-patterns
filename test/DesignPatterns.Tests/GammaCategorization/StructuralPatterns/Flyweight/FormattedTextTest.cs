using DesignPatterns.GammaCategorization.StructuralPatterns.Flyweight.TextEditing;

namespace DesignPatterns.Tests.GammaCategorization.StructuralPatterns.Flyweight;

public class FormattedTextTest
{
    [Fact]
    public void Test_WithoutFlyWeight()
    {
        var ft = new FormattedText("This is a brave new world");
        
        ft.Capitalize(10, 15);
        
        Assert.Matches("This is a BRAVE new world", ft.ToString());
    }
    
    [Fact]
    public void Test_WithFlyWeight()
    {
        var bft = new BetterFormattedText("This is a brave new world");

        bft.GetRange(10, 15).Capitalize = true;
        
        Assert.Matches("This is a BRAVE new world", bft.ToString());
    }
}