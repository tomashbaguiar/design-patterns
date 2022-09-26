namespace DesignPatterns.GammaCategorization.BehavioralPatterns.ChainOfResponsibility.MethodChain;

public class NoBonusesModifier : CreatureModifier
{
    public NoBonusesModifier(Creature creature) : base(creature)
    {
    }

    public override void Handle()
    {
    }
}