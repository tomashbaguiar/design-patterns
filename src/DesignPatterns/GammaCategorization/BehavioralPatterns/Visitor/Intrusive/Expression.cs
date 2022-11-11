using System.Text;

namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Intrusive;

public abstract class Expression
{
    public abstract void Print(StringBuilder stringBuilder);
}