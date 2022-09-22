using DesignPatterns.GammaCategorization.CreationalPatterns.Builder.Functional;

namespace DesignPatterns.Tests.GammaCategorization.CreationalPatterns.Builder;

public class FunctionalBuilderTest
{
    [Fact]
    public void Test()
    {
        const string name = "some-name";
        const string position = "some-position";
        
        var person = new PersonBuilder()
            .Called(name)
            .WorksAs(position)
            .Build();
        
        Assert.Matches(name, person.Name);
        Assert.Matches(position, person.Position);
    }
}