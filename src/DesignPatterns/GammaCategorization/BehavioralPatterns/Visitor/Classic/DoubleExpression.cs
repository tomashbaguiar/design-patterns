namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Classic;

public class DoubleExpression : Expression
{
    public readonly double Value;

    public DoubleExpression(double value)
    {
        Value = value;
    }

    public override void Accept(IExpressionVisitor visitor)
    {
        // double dispatch
        visitor.Visit(this);
    }
}