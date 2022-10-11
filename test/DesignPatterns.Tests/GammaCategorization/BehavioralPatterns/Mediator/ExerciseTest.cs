using DesignPatterns.GammaCategorization.BehavioralPatterns.Mediator.Exercise;

namespace DesignPatterns.Tests.GammaCategorization.BehavioralPatterns.Mediator;

public class ExerciseTest
{
    [Fact]
    public void Test()
    {
        var mediator = new DesignPatterns.GammaCategorization.BehavioralPatterns.Mediator.Exercise.Mediator();
        var p1 = new Participant(mediator);
        var p2 = new Participant(mediator);
        const int p1Value = 3;
        const int p2Value = 2;
        
        p1.Say(p1Value);
        p2.Say(p2Value);

        Assert.Equal(p2Value, p1.Value);
        Assert.Equal(p1Value, p2.Value);
    }
}