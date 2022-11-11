namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Classic;

public abstract class Expression
{
    public abstract void Accept(IExpressionVisitor visitor);
}