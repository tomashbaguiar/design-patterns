using System.Text;

namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Acyclic;

public class ExpressionPrinter : IVisitor, 
    IVisitor<Expression>, IVisitor<DoubleExpression>, IVisitor<AdditionExpression>
{
    private readonly StringBuilder _stringBuilder = new();
    
    public void Visit(Expression obj) { }
    
    public void Visit(DoubleExpression obj)
    {
        _stringBuilder.Append(obj.Value);
    }

    public void Visit(AdditionExpression obj)
    {
        _stringBuilder.Append('(');
        obj.Left.Accept(this);
        _stringBuilder.Append('+');
        obj.Right.Accept(this);
        _stringBuilder.Append(')');
    }

    public override string ToString()
    {
        return _stringBuilder.ToString();
    }
}