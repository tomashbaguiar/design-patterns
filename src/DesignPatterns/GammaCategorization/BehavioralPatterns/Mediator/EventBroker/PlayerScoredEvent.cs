namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Mediator.EventBroker;

public class PlayerScoredEvent : PlayerEvent
{
    public int GoalsScored { get; set; }
}