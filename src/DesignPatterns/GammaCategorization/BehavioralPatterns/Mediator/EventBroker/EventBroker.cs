using System.Reactive.Subjects;

namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Mediator.EventBroker;

public class EventBroker : IObservable<PlayerEvent>
{
    private readonly Subject<PlayerEvent> _subscriptions = new();
    
    public IDisposable Subscribe(IObserver<PlayerEvent> observer)
    {
        return _subscriptions.Subscribe(observer);
    }

    public void Publish(PlayerEvent playerEvent)
    {
        _subscriptions.OnNext(playerEvent);
    }
}