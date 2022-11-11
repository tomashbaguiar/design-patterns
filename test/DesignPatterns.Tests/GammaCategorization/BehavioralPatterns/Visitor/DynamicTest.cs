using System.Text;
using DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Dynamic;

namespace DesignPatterns.Tests.GammaCategorization.BehavioralPatterns.Visitor;

public class DynamicTest
{
    [Fact]
    public void Test()
    {
        var doubleExpression = new DoubleExpression(2.2);
        Expression additionExpression = new AdditionExpression(doubleExpression, doubleExpression);
        var expression = new AdditionExpression(doubleExpression, additionExpression);
        var ep = new ExpressionPrinter();
        var sb = new StringBuilder();
        const string expected = "(2.2+(2.2+2.2))";

        ep.Print(expression, sb);
        
        Assert.Equal(expected, sb.ToString());
    }
}