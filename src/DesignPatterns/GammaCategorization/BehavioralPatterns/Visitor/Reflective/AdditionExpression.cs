using System.Text;

namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Reflective;

public class AdditionExpression : Expression
{
    public readonly Expression Left;
    public readonly Expression Right;

    public AdditionExpression(Expression left, Expression right)
    {
        Left = left;
        Right = right;
    }

    public override void Print(StringBuilder stringBuilder)
    {
        stringBuilder.Append('(');
        Left.Print(stringBuilder);
        stringBuilder.Append('+');
        Right.Print(stringBuilder);
        stringBuilder.Append(')');
    }
}