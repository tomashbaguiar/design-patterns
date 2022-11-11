using DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.ReductionAndTransform;

namespace DesignPatterns.Tests.GammaCategorization.BehavioralPatterns.Visitor;

public class ReductionAndTransformTest
{
    [Fact]
    public void Test()
    {
        // 1 + 2
        var expression = new AdditionExpression(new DoubleExpression(1), new DoubleExpression(2));
        var evaluationTransformer = new EvaluationTransformer();
        var printTransformer = new PrintTransformer();
        var squareTransformer = new SquareTransformer();

        var result = expression.Reduce(evaluationTransformer);
        var text = expression.Reduce(printTransformer);
        var square = expression.Reduce(squareTransformer);
        
        Assert.Equal("(1 + 2)", text);
        Assert.Equal(3, result);
        
        Assert.Equal("(1 + 4)", square.Reduce(printTransformer));
        Assert.Equal(5, square.Reduce(evaluationTransformer));
    }
}