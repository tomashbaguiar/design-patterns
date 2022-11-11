using DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Acyclic;

namespace DesignPatterns.Tests.GammaCategorization.BehavioralPatterns.Visitor;

public class AcyclicTest
{
    [Fact]
    public void Test()
    {
        var e = new AdditionExpression(
            new DoubleExpression(1), 
            new AdditionExpression(new DoubleExpression(2), new DoubleExpression(3)));
        var ep = new ExpressionPrinter();
        
        ep.Visit(e);
        
        Assert.Equal("(1+(2+3))", ep.ToString());
    }
}