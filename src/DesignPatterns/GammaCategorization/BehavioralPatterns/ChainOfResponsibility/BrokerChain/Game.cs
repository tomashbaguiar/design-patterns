namespace DesignPatterns.GammaCategorization.BehavioralPatterns.ChainOfResponsibility.BrokerChain;

public class Game
{
    public event EventHandler<Query>? Queries;

    public void PerformQuery(object sender, Query query)
    {
        Queries?.Invoke(sender, query);
    }
}