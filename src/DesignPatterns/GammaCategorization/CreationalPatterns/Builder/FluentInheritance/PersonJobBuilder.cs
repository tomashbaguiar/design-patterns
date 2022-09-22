namespace DesignPatterns.GammaCategorization.CreationalPatterns.Builder.FluentInheritance;

public class PersonJobBuilder<TSelf> : PersonInfoBuilder<PersonJobBuilder<TSelf>> where TSelf : PersonJobBuilder<TSelf>
{
    public TSelf WorkAs(string position)
    {
        Person.Position = position;
        return (TSelf) this;
    }
}