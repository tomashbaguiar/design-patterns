namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.ReductionAndTransform;

public class DoubleExpression : Expression
{
    public readonly double Value;

    public DoubleExpression(double value)
    {
        Value = value;
    }

    public override T Reduce<T>(ITransformer<T> transformer)
    {
        return transformer.Transform(this);
    }
}