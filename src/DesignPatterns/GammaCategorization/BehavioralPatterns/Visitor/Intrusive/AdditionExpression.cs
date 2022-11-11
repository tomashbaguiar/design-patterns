using System.Text;

namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Intrusive;

public class AdditionExpression : Expression
{
    private readonly Expression _left;
    private readonly Expression _right;

    public AdditionExpression(Expression left, Expression right)
    {
        _left = left;
        _right = right;
    }

    public override void Print(StringBuilder stringBuilder)
    {
        stringBuilder.Append('(');
        _left.Print(stringBuilder);
        stringBuilder.Append('+');
        _right.Print(stringBuilder);
        stringBuilder.Append(')');
    }
}