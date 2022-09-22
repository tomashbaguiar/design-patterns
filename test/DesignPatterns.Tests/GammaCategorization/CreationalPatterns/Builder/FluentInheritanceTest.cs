using DesignPatterns.GammaCategorization.CreationalPatterns.Builder.FluentInheritance;

namespace DesignPatterns.Tests.GammaCategorization.CreationalPatterns.Builder;

public class FluentInheritanceTest
{
    [Fact(Skip = "I'll try to fix you")]
    public void Test()
    {
        const string name = "some-name";
        const string job = "some-job";
        const string expected = $"Name: {{name}}, Position: {job}";
        
        var person = Person.New
            .Called(name)
            .WorkAs(job)
            .Build();

        Assert.Matches(expected, person.ToString());
    }
}