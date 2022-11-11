namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Acyclic;

public abstract class Expression
{
    public virtual void Accept(IVisitor visitor)
    {
        if (visitor is IVisitor<Expression> typed)
        {
            typed.Visit(this);
        }
    }
}