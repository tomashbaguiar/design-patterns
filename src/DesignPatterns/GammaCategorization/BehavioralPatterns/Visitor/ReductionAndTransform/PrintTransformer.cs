using System.Globalization;

namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.ReductionAndTransform;

public class PrintTransformer : ITransformer<string>
{
    public string Transform(DoubleExpression doubleExpression)
    {
        return doubleExpression.Value.ToString(CultureInfo.InvariantCulture);
    }

    public string Transform(AdditionExpression additionExpression)
    {
        return $"({additionExpression.Left.Reduce(this)} + {additionExpression.Right.Reduce(this)})";
    }
}