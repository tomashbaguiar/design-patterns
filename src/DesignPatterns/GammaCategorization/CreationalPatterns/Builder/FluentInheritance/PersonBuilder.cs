namespace DesignPatterns.GammaCategorization.CreationalPatterns.Builder.FluentInheritance;

public abstract class PersonBuilder
{
    protected Person Person = new();

    public Person Build()
    {
        return Person;
    }
}