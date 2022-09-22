using DesignPatterns.GammaCategorization.CreationalPatterns.Prototype.Serialization;
using CopyConstructor = DesignPatterns.GammaCategorization.CreationalPatterns.Prototype.Wrong.CopyConstructor;
using Wrong = DesignPatterns.GammaCategorization.CreationalPatterns.Prototype.Wrong;
using ShallowCopy = DesignPatterns.GammaCategorization.CreationalPatterns.Prototype.Wrong.ShallowCopy;
using DeepCopy = DesignPatterns.GammaCategorization.CreationalPatterns.Prototype.Wrong.DeepCopy;
using DeepCopyInterface = DesignPatterns.GammaCategorization.CreationalPatterns.Prototype.Wrong.DeepCopyInterface;
using PrototypeInheritance = DesignPatterns.GammaCategorization.CreationalPatterns.Prototype.PrototypeInheritance;

namespace DesignPatterns.Tests.GammaCategorization.CreationalPatterns.Prototype;

public class PersonTest
{
    [Fact]
    public void WrongCopy_FromPerson()
    {
        const string firstName1 = "John";
        const string streetName = "London Road";
        const int houseNumber = 123;
        var names = new[] { "John", "Smith" };
        var address = new Wrong.Address(streetName, houseNumber);
        var person1 = new Wrong.Person(names, address);
        const string firstName2 = "Jane";

        var person2 = person1;
        person2.Names[0] = firstName2;
        
        Assert.DoesNotMatch(firstName1, person1.Names.First());
        Assert.Matches(firstName2, person2.Names.First());
    }
    
    [Fact]
    public void WrongShallowCopy_FromPerson()
    {
        const string firstName1 = "John";
        const string streetName = "London Road";
        const int houseNumber = 123;
        var names = new[] { "John", "Smith" };
        var address = new ShallowCopy.Address(streetName, houseNumber);
        var person1 = new ShallowCopy.Person(names, address);
        const string firstName2 = "Jane";
        const int newHouseNumber = 321;

        var person2 = (ShallowCopy.Person) person1.Clone();
        person2.Names[0] = firstName2;
        person2.Address.HouseNumber = newHouseNumber;
        
        Assert.DoesNotMatch(firstName1, person1.Names.First());
        Assert.Matches(firstName2, person2.Names.First());
        Assert.NotEqual(houseNumber, person1.Address.HouseNumber);
        Assert.Equal(newHouseNumber, person2.Address.HouseNumber);
    }
    
    [Fact]
    public void WrongDeepCopy_FromPerson()
    {
        const string firstName1 = "John";
        const string streetName = "London Road";
        const int houseNumber = 123;
        var names = new[] { "John", "Smith" };
        var address = new DeepCopy.Address(streetName, houseNumber);
        var person1 = new DeepCopy.Person(names, address);
        const string firstName2 = "Jane";
        const int newHouseNumber = 321;

        var person2 = (DeepCopy.Person) person1.Clone();
        person2.Names[0] = firstName2;
        person2.Address.HouseNumber = newHouseNumber;
        
        Assert.Matches(firstName1, person1.Names.First());
        Assert.Matches(firstName2, person2.Names.First());
        Assert.Equal(houseNumber, person1.Address.HouseNumber);
        Assert.Equal(newHouseNumber, person2.Address.HouseNumber);
    }
    
    [Fact]
    public void WrongCopyConstructor_FromPerson()
    {
        const string firstName1 = "John";
        const string streetName = "London Road";
        const int houseNumber = 123;
        var names = new[] { "John", "Smith" };
        var address = new CopyConstructor.Address(streetName, houseNumber);
        var person1 = new CopyConstructor.Person(names, address);
        const string firstName2 = "Jane";
        const int newHouseNumber = 321;

        var person2 = new CopyConstructor.Person(person1);
        person2.Names[0] = firstName2;
        person2.Address.HouseNumber = newHouseNumber;
        
        Assert.DoesNotMatch(firstName1, person1.Names.First());
        Assert.Matches(firstName2, person2.Names.First());
        Assert.Equal(houseNumber, person1.Address.HouseNumber);
        Assert.Equal(newHouseNumber, person2.Address.HouseNumber);
    }
    
    [Fact]
    public void WrongDeepCopyInterface_ForPerson()
    {
        const string firstName1 = "John";
        const string streetName = "London Road";
        const int houseNumber = 123;
        var names = new[] { "John", "Smith" };
        var address = new DeepCopyInterface.Address(streetName, houseNumber);
        var person1 = new DeepCopyInterface.Person(names, address);
        const string firstName2 = "Jane";
        const int newHouseNumber = 321;

        var person2 = person1.DeepCopy();
        person2.Names[0] = firstName2;
        person2.Address.HouseNumber = newHouseNumber;
        
        Assert.DoesNotMatch(firstName1, person1.Names.First());
        Assert.Matches(firstName2, person2.Names.First());
        Assert.Equal(houseNumber, person1.Address.HouseNumber);
        Assert.Equal(newHouseNumber, person2.Address.HouseNumber);
    }
    
    [Fact]
    public void PrototypeInheritance_ForPerson()
    {
        const string firstName1 = "John";
        const string streetName = "London Road";
        const int houseNumber = 123;
        var names = new[] { "John", "Smith" };
        var address = new PrototypeInheritance.Address(streetName, houseNumber);
        var person1 = new PrototypeInheritance.Person(names, address);
        const string firstName2 = "Jane";
        const int newHouseNumber = 321;

        var person2 = PrototypeInheritance.ExtensionMethods.DeepCopy(person1);
        person2.Names[0] = firstName2;
        person2.Address.HouseNumber = newHouseNumber;
        
        Assert.Matches(firstName1, person1.Names.First());
        Assert.Matches(firstName2, person2.Names.First());
        Assert.Equal(houseNumber, person1.Address.HouseNumber);
        Assert.Equal(newHouseNumber, person2.Address.HouseNumber);
    }
    
    [Fact]
    public void Serialization_ForPerson()
    {
        const string firstName1 = "John";
        const string streetName = "London Road";
        const int houseNumber = 123;
        var names = new[] { "John", "Smith" };
        var address = new Address(streetName, houseNumber);
        var person1 = new Person(names, address);
        const string firstName2 = "Jane";
        const int newHouseNumber = 321;

        var person2 = person1.DeepCopy();
        person2.Names[0] = firstName2;
        person2.Address.HouseNumber = newHouseNumber;
        
        Assert.Matches(firstName1, person1.Names.First());
        Assert.Matches(firstName2, person2.Names.First());
        Assert.Equal(houseNumber, person1.Address.HouseNumber);
        Assert.Equal(newHouseNumber, person2.Address.HouseNumber);
    }
}