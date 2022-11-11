using System.Text;

namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Reflective;

public class DoubleExpression : Expression
{
    public readonly double Value;

    public DoubleExpression(double value)
    {
        Value = value;
    }

    public override void Print(StringBuilder stringBuilder)
    {
        stringBuilder.Append(Value);
    }
}