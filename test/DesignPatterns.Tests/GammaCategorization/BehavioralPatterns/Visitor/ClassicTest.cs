using DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Classic;

namespace DesignPatterns.Tests.GammaCategorization.BehavioralPatterns.Visitor;

public class ClassicTest
{
    [Fact]
    public void Test()
    {
        var doubleExpression = new DoubleExpression(2.2);
        var additionExpression = new AdditionExpression(doubleExpression, doubleExpression);
        var expression = new AdditionExpression(doubleExpression, additionExpression);
        var expressionPrinter = new ExpressionPrinter();
        const string expected = "(2.2+(2.2+2.2))";
        
        expressionPrinter.Visit(expression);
        
        Assert.Equal(expected, expressionPrinter.ToString());
    }

    [Fact]
    public void Test_Calculator()
    {
        var doubleExpression = new DoubleExpression(2.2);
        var additionExpression = new AdditionExpression(doubleExpression, doubleExpression);
        var expression = new AdditionExpression(doubleExpression, additionExpression);
        var expressionCalculator = new ExpressionCalculator();
        const double expected = 2.2 + 2.2 + 2.2;

        expressionCalculator.Visit(expression);
        
        Assert.Equal(expected, expressionCalculator.Result);
    }
}