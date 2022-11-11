namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.ReductionAndTransform;

public abstract class Expression
{
    public abstract T Reduce<T>(ITransformer<T> transformer);
}