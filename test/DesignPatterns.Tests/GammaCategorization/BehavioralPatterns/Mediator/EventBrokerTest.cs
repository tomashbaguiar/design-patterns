using Autofac;
using DesignPatterns.GammaCategorization.BehavioralPatterns.Mediator.EventBroker;

namespace DesignPatterns.Tests.GammaCategorization.BehavioralPatterns.Mediator;

public class EventBrokerTest
{
    [Fact]
    public void Test()
    {
        var cb = new ContainerBuilder();
        cb.RegisterType<EventBroker>().SingleInstance();
        cb.RegisterType<FootballCoach>();
        cb.Register((c, p) =>
            new FootballPlayer(
                c.Resolve<EventBroker>(),
                p.Named<string>("name"))
        );

        using var c = cb.Build();
        var coach = c.Resolve<FootballCoach>();
        var player1 = c.Resolve<FootballPlayer>(new NamedParameter("name", "John"));
        var player2 = c.Resolve<FootballPlayer>(new NamedParameter("name", "Chris"));

        player1.Score();
        player1.Score();
        player1.Score();
        player1.AssaultReferee();
        
        player2.Score();
        player2.Score();
    }
}