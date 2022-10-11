namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Mediator.Exercise;

public class Mediator
{
    private readonly List<Participant> _participants = new();
    
    public void Broadcast(Participant source, int value)
    {
        foreach (var participant in _participants.Where(p => p != source))
        {
            participant.Receive(value);
        }
    }

    public void Add(Participant participant) => _participants.Add(participant);
}