namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Acyclic;

public class AdditionExpression : Expression
{
    public readonly Expression Left;
    public readonly Expression Right;

    public AdditionExpression(Expression left, Expression right)
    {
        Left = left;
        Right = right;
    }
    
    public override void Accept(IVisitor visitor)
    {
        if (visitor is IVisitor<AdditionExpression> typed)
        {
            typed.Visit(this);
        }
    }
}