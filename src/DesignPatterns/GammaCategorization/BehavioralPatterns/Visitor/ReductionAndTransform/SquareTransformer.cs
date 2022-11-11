namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.ReductionAndTransform;

public class SquareTransformer : ITransformer<Expression>
{
    public Expression Transform(DoubleExpression doubleExpression)
    {
        return new DoubleExpression(doubleExpression.Value * doubleExpression.Value);
    }

    public Expression Transform(AdditionExpression additionExpression)
    {
        return new AdditionExpression(
            additionExpression.Left.Reduce(this), 
            additionExpression.Right.Reduce(this));
    }
}