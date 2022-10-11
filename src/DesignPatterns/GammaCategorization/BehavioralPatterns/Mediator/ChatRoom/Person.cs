namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Mediator.ChatRoom;

public class Person
{
    public readonly string Name;
    public ChatRoom Room;
    private readonly List<string> _chatLog = new();

    public Person(string name)
    {
        Name = name;
    }

    public void Say(string message)
    {
        Room.Broadcast(Name, message);
    }

    public void PrivateMessage(string who, string message)
    {
        Room.Message(Name, who, message);
    }

    public void Receive(string sender, string message)
    {
        var str = $"{sender}: '{message}'";
        _chatLog.Add(str);
    }
}