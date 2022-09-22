namespace DesignPatterns.GammaCategorization.CreationalPatterns.Builder.FluentInheritance;

public class PersonInfoBuilder<TSelf> : PersonBuilder where TSelf : PersonInfoBuilder<TSelf>
{
    protected Person Person = new();

    public TSelf Called(string name)
    {
        Person.Name = name;
        return (TSelf) this;
    }
}