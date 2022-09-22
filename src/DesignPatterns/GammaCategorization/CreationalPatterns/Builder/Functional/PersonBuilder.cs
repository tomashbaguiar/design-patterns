namespace DesignPatterns.GammaCategorization.CreationalPatterns.Builder.Functional;

public sealed class PersonBuilder
{
    private readonly List<Func<Person, Person>> _actions = new();

    public PersonBuilder Do(Action<Person> action) => AddAction(action);

    public Person Build() => _actions.Aggregate(new Person(), (p, f) => f(p));

    public PersonBuilder Called(string name) => Do(p => p.Name = name);
    
    private PersonBuilder AddAction(Action<Person> action)
    {
        _actions.Add(p => { 
            action(p);
            return p;
        });

        return this;
    }
}