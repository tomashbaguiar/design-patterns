using System.Text;

namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Reflective;

public abstract class Expression
{
    public abstract void Print(StringBuilder stringBuilder);
}