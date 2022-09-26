namespace DesignPatterns.GammaCategorization.BehavioralPatterns.ChainOfResponsibility.MethodChain;

public class IncreaseDefenseModifier : CreatureModifier
{
    public IncreaseDefenseModifier(Creature creature) : base(creature)
    {
    }

    public override void Handle()
    {
        Creature.Defense += 3;
        base.Handle();
    }
}