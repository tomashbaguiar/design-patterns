namespace DesignPatterns.GammaCategorization.CreationalPatterns.Prototype.PrototypeInheritance;

public class Person : IDeepCopyable<Person>
{
    public string[] Names;
    public Address Address;

    public Person(string[] names, Address address)
    {
        Names = names;
        Address = address;
    }

    public Person()
    {
        
    }

    public void CopyTo(Person target)
    {
        target.Names = (string[]) Names.Clone();
        target.Address = Address.DeepCopy();
    }

    public override string ToString()
    {
        return $"{nameof(Names)}: {string.Join(" ", Names)}, {nameof(Address)}: {Address}";
    }
}