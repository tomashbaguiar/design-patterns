using System.Text;

namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Reflective;

using DicType = Dictionary<Type, Action<Expression, StringBuilder>>;

public static class ExpressionPrinter
{
    // public static void Print(Expression expression, StringBuilder stringBuilder)
    // {
    //     switch (expression)
    //     {
    //         case DoubleExpression doubleExpression:
    //             stringBuilder.Append(doubleExpression.Value);
    //             break;
    //         case AdditionExpression additionExpression:
    //             stringBuilder.Append('(');
    //             additionExpression.Left.Print(stringBuilder);
    //             stringBuilder.Append('+');
    //             additionExpression.Right.Print(stringBuilder);
    //             stringBuilder.Append(')');
    //             break;
    //     }
    // }

    private static readonly DicType Actions = new()
    {
        [typeof(DoubleExpression)] = (e, sb) =>
        {
            var de = (DoubleExpression)e;
            sb.Append(de.Value);
        },
        [typeof(AdditionExpression)] = (e, sb) =>
        {
            var additionExpression = (AdditionExpression)e;
            sb.Append('(');
            additionExpression.Left.Print(sb);
            sb.Append('+');
            additionExpression.Right.Print(sb);
            sb.Append(')');
        }
    };
    
    public static void Print(Expression expression, StringBuilder stringBuilder)
    {
        Actions[expression.GetType()](expression, stringBuilder);
    }
}