namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.ReductionAndTransform;

public class EvaluationTransformer : ITransformer<double>
{
    public double Transform(DoubleExpression doubleExpression)
    {
        return doubleExpression.Value;
    }

    public double Transform(AdditionExpression additionExpression)
    {
        return additionExpression.Left.Reduce(this) + additionExpression.Right.Reduce(this);
    }
}