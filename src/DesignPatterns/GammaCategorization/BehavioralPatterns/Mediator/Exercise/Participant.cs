namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Mediator.Exercise;

public class Participant
{
    public string Name { get; set; }
    public int Value { get; set; }
    public Mediator _mediator;

    public Participant(Mediator mediator)
    {
        _mediator = mediator;
        Value = 0;
        _mediator.Add(this);
    }

    public void Say(int n)
    {
        _mediator.Broadcast(this, n);
    }
  
    public void Receive(int value)
    {
        Value += value;
    }
}