namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Mediator.EventBroker;

public class Actor
{
    protected EventBroker Broker;

    public Actor(EventBroker broker)
    {
        Broker = broker;
    }
}