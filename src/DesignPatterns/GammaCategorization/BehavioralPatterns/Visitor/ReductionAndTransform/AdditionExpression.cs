namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.ReductionAndTransform;

public class AdditionExpression : Expression
{
    public readonly Expression Left;
    public readonly Expression Right;

    public AdditionExpression(Expression left, Expression right)
    {
        Left = left;
        Right = right;
    }

    public override T Reduce<T>(ITransformer<T> transformer)
    {
        return transformer.Transform(this);
    }
}