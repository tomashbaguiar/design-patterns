namespace DesignPatterns.GammaCategorization.CreationalPatterns.Builder.FluentInheritance;

public class Person
{
    public string Name;
    public string Position;

    public static Builder New => new();

    public class Builder : PersonJobBuilder<Builder>
    {
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
    }
}