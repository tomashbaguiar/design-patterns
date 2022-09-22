using DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.AdapterDecorator;

namespace DesignPatterns.Tests.GammaCategorization.StructuralPatterns.Decorator;

public class AdapterDecoratorTest
{
    [Fact]
    public void Test()
    {
        MyStringBuilder hello = "Hello ";
        hello += "World";
        
        Assert.Matches("Hello World", hello.ToString());
    }
}