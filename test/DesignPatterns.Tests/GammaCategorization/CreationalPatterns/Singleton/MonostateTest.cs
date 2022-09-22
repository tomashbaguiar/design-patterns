using DesignPatterns.GammaCategorization.CreationalPatterns.Singleton.Monostate;

namespace DesignPatterns.Tests.GammaCategorization.CreationalPatterns.Singleton;

public class MonostateTest
{
    [Fact]
    public void Monostate_HasSameValues_ForDifferentInstance()
    {
        const string name = "some-name-1";
        const int age = 28;
        var unused = new Ceo
        {
            Name = name,
            Age = age,
        };
        var ceo2 = new Ceo();
        
        Assert.Matches(name, ceo2.Name);
        Assert.Equal(age, ceo2.Age);
    }
}