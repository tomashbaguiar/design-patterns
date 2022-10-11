namespace DesignPatterns.GammaCategorization.BehavioralPatterns.ChainOfResponsibility.BrokerChain;

public class Query
{
    public readonly string CreatureName;
    public readonly Argument WhatToQuery;
    public int Value;
    
    public enum Argument
    {
        Attack, Defense,
    }

    public Query(string creatureName, Argument whatToQuery, int value)
    {
        CreatureName = creatureName;
        WhatToQuery = whatToQuery;
        Value = value;
    }
}