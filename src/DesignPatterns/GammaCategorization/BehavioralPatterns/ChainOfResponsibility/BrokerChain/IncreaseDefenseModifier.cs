namespace DesignPatterns.GammaCategorization.BehavioralPatterns.ChainOfResponsibility.BrokerChain;

public class IncreaseDefenseModifier : CreatureModifier
{
    public IncreaseDefenseModifier(Game game, Creature creature) : base(game, creature)
    {
    }

    protected override void Handle(object sender, Query query)
    {
        if (query.CreatureName == Creature.Name && query.WhatToQuery == Query.Argument.Defense)
        {
            query.Value += 2;
        }
    }
}