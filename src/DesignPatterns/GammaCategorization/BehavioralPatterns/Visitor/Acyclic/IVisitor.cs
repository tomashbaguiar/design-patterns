namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Acyclic;

public interface IVisitor<TVisitable>
{
    void Visit(TVisitable obj);
}

public interface IVisitor { }