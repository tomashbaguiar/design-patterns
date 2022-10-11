namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Interpreter;

public class BinaryOperation : IElement
{
    public enum Type
    {
        Addition, Subtraction,
    }

    public int Value
    {
        get
        {
            return MyType switch
            {
                Type.Addition => Left.Value + Right.Value,
                Type.Subtraction => Left.Value - Right.Value,
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }

    public Type MyType;
    public IElement Left;
    public IElement Right;
}