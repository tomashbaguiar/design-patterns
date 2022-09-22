namespace DesignPatterns.GammaCategorization.CreationalPatterns.Prototype.Wrong.ShallowCopy;

public class Person : ICloneable
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

    public object Clone()
    {
        return new Person(Names, Address);
    }
}