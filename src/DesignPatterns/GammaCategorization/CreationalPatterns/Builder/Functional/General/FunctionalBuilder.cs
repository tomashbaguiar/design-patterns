namespace DesignPatterns.GammaCategorization.CreationalPatterns.Builder.Functional.General;

public abstract class FunctionalBuilder<TSubject, TSelf> 
    where TSelf : FunctionalBuilder<TSubject, TSelf>
    where TSubject : new()
{
    private readonly List<Func<TSubject, TSubject>> _actions = new();

    public TSelf Do(Action<TSubject> action) => AddAction(action);

    public TSubject Build() => _actions.Aggregate(new TSubject(), (s, f) => f(s));

    private TSelf AddAction(Action<TSubject> action)
    {
        _actions.Add(s =>
        {
            action(s);
            return s;
        });
        return (TSelf) this;
    }
}