namespace DesignPatterns.GammaCategorization.CreationalPatterns.Builder.Faceted;

public class PersonBuilder // facade
{
    protected Person Person = new();

    public PersonJobBuilder Works => new(Person);

    public PersonAddressBuilder Lives => new(Person);

    public static implicit operator Person(PersonBuilder personBuilder) => personBuilder.Person;
}