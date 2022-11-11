namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Acyclic;

public class DoubleExpression : Expression
{
    public readonly double Value;

    public DoubleExpression(double value)
    {
        Value = value;
    }

    public override void Accept(IVisitor visitor)
    {
        if (visitor is IVisitor<DoubleExpression> typed)
        {
            typed.Visit(this);
        }
    }
}