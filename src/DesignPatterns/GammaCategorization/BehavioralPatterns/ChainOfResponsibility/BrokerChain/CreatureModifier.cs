namespace DesignPatterns.GammaCategorization.BehavioralPatterns.ChainOfResponsibility.BrokerChain;

public abstract class CreatureModifier : IDisposable
{
    protected readonly Game Game;
    protected readonly Creature Creature;

    protected CreatureModifier(Game game, Creature creature)
    {
        Game = game;
        Creature = creature;
        Game.Queries += Handle;
    }

    protected abstract void Handle(object sender, Query query);

    public void Dispose()
    {
        Game.Queries -= Handle;
    }
}