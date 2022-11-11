using System.Text;

namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Intrusive;

public class DoubleExpression : Expression
{
    private readonly double _value;

    public DoubleExpression(double value)
    {
        _value = value;
    }

    public override void Print(StringBuilder stringBuilder)
    {
        stringBuilder.Append(_value);
    }
}