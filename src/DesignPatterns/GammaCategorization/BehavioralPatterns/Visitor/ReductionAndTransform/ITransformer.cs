namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.ReductionAndTransform;

public interface ITransformer<T>
{
    T Transform(DoubleExpression doubleExpression);
    T Transform(AdditionExpression additionExpression);
}