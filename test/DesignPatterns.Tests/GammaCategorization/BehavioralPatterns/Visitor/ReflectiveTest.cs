using System.Text;
using DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Reflective;

namespace DesignPatterns.Tests.GammaCategorization.BehavioralPatterns.Visitor;

public class ReflectiveTest
{
    [Fact]
    public void Test()
    {
        var doubleExpression = new DoubleExpression(2.2);
        var additionExpression = new AdditionExpression(doubleExpression, doubleExpression);
        var expression = new AdditionExpression(doubleExpression, additionExpression);
        var stringBuilder = new StringBuilder();
        const string expected = "(2.2+(2.2+2.2))";
        
        ExpressionPrinter.Print(expression, stringBuilder);
        
        Assert.Equal(expected, stringBuilder.ToString());
    }
}