namespace DesignPatterns.GammaCategorization.CreationalPatterns.Prototype.Wrong.CopyConstructor;

public class Person
{
    public string[] Names;
    public Address Address;

    public Person(string[] names, Address address)
    {
        Names = names;
        Address = address;
    }

    public override string ToString()
    {
        return $"{nameof(Names)}: {string.Join(" ", Names)}, {nameof(Address)}: {Address}";
    }

    public Person(Person other)
    {
        Names = other.Names;
        Address = new Address(other.Address);
    }
}