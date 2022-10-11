namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Interpreter;

public class Integer : IElement
{
    public int Value { get; }

    public Integer(int value)
    {
        Value = value;
    }
}