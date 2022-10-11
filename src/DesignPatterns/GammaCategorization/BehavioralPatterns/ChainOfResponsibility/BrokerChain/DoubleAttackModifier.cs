namespace DesignPatterns.GammaCategorization.BehavioralPatterns.ChainOfResponsibility.BrokerChain;

public class DoubleAttackModifier : CreatureModifier
{
    public DoubleAttackModifier(Game game, Creature creature) : base(game, creature)
    {
    }

    protected override void Handle(object sender, Query query)
    {
        if (query.CreatureName == Creature.Name && query.WhatToQuery == Query.Argument.Attack)
        {
            query.Value *= 2;
        }
    }
}