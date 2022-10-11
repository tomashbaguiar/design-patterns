using System.Reactive.Linq;

namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Mediator.EventBroker;

public class FootballPlayer : Actor
{
    public string Name { get; set; }
    public int GoalScored { get; set; } = 0;
    
    public FootballPlayer(EventBroker broker, string name) : base(broker)
    {
        Name = name;

        Broker.OfType<PlayerScoredEvent>()
            .Where(ps => !ps.Name.Equals(name))
            .Subscribe(ps => 
                Console.WriteLine($"{name}: Nicely done, {ps.Name}! It's your {ps.GoalsScored} goal."));

        Broker.OfType<PlayerSentOffEvent>()
            .Where(ps => !ps.Name.Equals(name))
            .Subscribe(ps => 
                Console.WriteLine($"{name}: See you in the lockers, {ps.Name}"));
    }

    public void Score()
    {
        GoalScored++;
        Broker.Publish(new PlayerScoredEvent { Name = Name, GoalsScored = GoalScored });
    }

    public void AssaultReferee()
    {
        Broker.Publish(new PlayerSentOffEvent { Name = Name, Reason = PlayerSentOffReason.Violence });
    }
}