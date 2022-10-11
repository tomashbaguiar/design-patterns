using System.Reactive.Linq;

namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Mediator.EventBroker;

public class FootballCoach : Actor
{
    public FootballCoach(EventBroker broker) : base(broker)
    {
        Broker.OfType<PlayerScoredEvent>()
            .Subscribe(pe =>
            {
                if (pe.GoalsScored < 3)
                {
                    Console.WriteLine($"Coach: Well done, {pe.Name}");
                }
            });

        Broker.OfType<PlayerSentOffEvent>()
            .Subscribe(pe =>
            {
                if (pe.Reason == PlayerSentOffReason.Violence)
                {
                    Console.WriteLine($"Coach: How could you, {pe.Name}?");
                }
            });
    }
}