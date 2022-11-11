namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Classic;

public interface IExpressionVisitor
{
    void Visit(DoubleExpression doubleExpression);
    void Visit(AdditionExpression additionExpression);
}