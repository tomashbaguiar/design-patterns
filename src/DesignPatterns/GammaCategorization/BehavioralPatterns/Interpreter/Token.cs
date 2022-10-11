namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Interpreter;

public class Token
{
    public enum Type
    {
        Integer, Plus, Minus, LParen, RParen,
    }

    public Type MyType;
    public string Text;

    public Token(Type myType, string text)
    {
        MyType = myType;
        Text = text;
    }

    public override string ToString()
    {
        return $"`{Text}`";
    }
}