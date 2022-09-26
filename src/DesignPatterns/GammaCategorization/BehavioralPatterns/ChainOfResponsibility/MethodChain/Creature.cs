namespace DesignPatterns.GammaCategorization.BehavioralPatterns.ChainOfResponsibility.MethodChain;

public class Creature
{
    public string Name;
    public int Attack;
    public int Defense;

    public Creature(string name, int attack, int defense)
    {
        Name = name;
        Attack = attack;
        Defense = defense;
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Attack)}: {Attack}, {nameof(Defense)}: {Defense}";
    }
}