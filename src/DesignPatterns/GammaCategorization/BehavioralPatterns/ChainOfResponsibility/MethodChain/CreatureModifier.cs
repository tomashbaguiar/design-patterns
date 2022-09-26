namespace DesignPatterns.GammaCategorization.BehavioralPatterns.ChainOfResponsibility.MethodChain;

public class CreatureModifier
{
    protected Creature Creature;
    protected CreatureModifier? Next;

    public CreatureModifier(Creature creature)
    {
        Creature = creature;
    }

    public void Add(CreatureModifier creatureModifier)
    {
        if (Next != null)
        {
            Next.Add(creatureModifier);
        }
        else
        {
            Next = creatureModifier;
        }
    }

    public virtual void Handle() => Next?.Handle();
}