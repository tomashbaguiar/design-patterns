using DesignPatterns.GammaCategorization.BehavioralPatterns.Mediator;
using DesignPatterns.GammaCategorization.BehavioralPatterns.Mediator.ChatRoom;

namespace DesignPatterns.Tests.GammaCategorization.BehavioralPatterns.Mediator;

public class ChatRoomTest
{
    [Fact]
    public void Test()
    {
        var room = new ChatRoom();
        var john = new Person("John");
        var jane = new Person("Jane");
        room.Join(jane);
        room.Join(john);
        john.Say("Hi");
        jane.Say("Hey, John");

        var simon = new Person("Simon");
        simon.Say("Hi everyone");
        jane.PrivateMessage("Simon", "glad you could join us");
    }
}