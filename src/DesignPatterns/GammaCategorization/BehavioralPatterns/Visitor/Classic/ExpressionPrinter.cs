using System.Text;

namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Classic;

public class ExpressionPrinter : IExpressionVisitor
{
    private readonly StringBuilder _stringBuilder = new();

    public void Visit(DoubleExpression doubleExpression)
    {
        _stringBuilder.Append(doubleExpression.Value);
    }

    public void Visit(AdditionExpression additionExpression)
    {
        _stringBuilder.Append('(');
        additionExpression.Left.Accept(this);
        _stringBuilder.Append('+');
        additionExpression.Right.Accept(this);
        _stringBuilder.Append(')');
    }

    public override string ToString()
    {
        return _stringBuilder.ToString();
    }
}