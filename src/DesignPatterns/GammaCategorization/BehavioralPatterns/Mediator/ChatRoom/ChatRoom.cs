namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Mediator.ChatRoom;

public class ChatRoom
{
    private readonly List<Person> _people = new();

    public void Join(Person person)
    {
        var joinMsg = $"{person.Name} joins the chat";
        Broadcast("room", joinMsg);
        person.Room = this;
        _people.Add(person);
    }

    public void Broadcast(string source, string message)
    {
        foreach (var person in _people.Where(person => person.Name != source))
        {
            person.Receive(source, message);
        }
    }

    public void Message(string source, string destination, string message)
    {
        _people.FirstOrDefault(p => p.Name == destination)?.Receive(source, message);
    }
}