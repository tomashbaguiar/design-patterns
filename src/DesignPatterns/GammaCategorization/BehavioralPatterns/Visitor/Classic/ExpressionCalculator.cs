namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Classic;

public class ExpressionCalculator : IExpressionVisitor
{
    public double Result;
    
    public void Visit(DoubleExpression doubleExpression)
    {
        Result = doubleExpression.Value;
    }

    public void Visit(AdditionExpression additionExpression)
    {
        additionExpression.Left.Accept(this);
        var left = Result;
        additionExpression.Right.Accept(this);
        var right = Result;
        Result = left + right;
    }
}