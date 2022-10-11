namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Mediator.EventBroker;

public class PlayerSentOffEvent : PlayerEvent
{
    public string Reason { get; set; }
}