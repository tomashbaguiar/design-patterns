namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Dynamic;

public class AdditionExpression : Expression
{
    public readonly Expression Right;
    public readonly Expression Left;

    public AdditionExpression(Expression left, Expression right)
    {
        Left = left;
        Right = right;
    }
}