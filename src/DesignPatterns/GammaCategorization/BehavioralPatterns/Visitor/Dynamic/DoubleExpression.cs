namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Dynamic;

public class DoubleExpression : Expression
{
    public readonly double Value;

    public DoubleExpression(double value)
    {
        Value = value;
    }
}