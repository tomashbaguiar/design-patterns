namespace DesignPatterns.GammaCategorization.CreationalPatterns.Builder.Functional.General;

public sealed class PersonBuilder 
    : FunctionalBuilder<Person, PersonBuilder>
{
    public PersonBuilder Called(string name) => Do(p => p.Name = name);
}