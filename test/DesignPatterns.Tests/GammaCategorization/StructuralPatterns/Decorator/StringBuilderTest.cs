using DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.StringBuilder;

namespace DesignPatterns.Tests.GammaCategorization.StructuralPatterns.Decorator;

public class StringBuilderTest
{
    [Fact]
    public void Test()
    {
        const string expected = "class Foo\r\n{\r\n}";
        
        var codeBuilder = new CodeBuilder();
        codeBuilder.AppendLine("class Foo")
            .AppendLine("{")
            .AppendLine("}");
        
        Assert.Matches(expected, codeBuilder.ToString());
    }
}