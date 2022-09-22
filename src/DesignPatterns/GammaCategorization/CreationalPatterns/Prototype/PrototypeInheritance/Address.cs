namespace DesignPatterns.GammaCategorization.CreationalPatterns.Prototype.PrototypeInheritance;

public class Address : IDeepCopyable<Address>
{
    public string StreetName;
    public int HouseNumber;

    public Address(string streetName, int houseNumber)
    {
        StreetName = streetName;
        HouseNumber = houseNumber;
    }

    public Address()
    {
        
    }

    public void CopyTo(Address target)
    {
        target.HouseNumber = HouseNumber;
        target.StreetName = StreetName;
    }

    public override string ToString()
    {
        return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
    }
}