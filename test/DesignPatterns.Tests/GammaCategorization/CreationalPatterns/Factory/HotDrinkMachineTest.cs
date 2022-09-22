using DesignPatterns.GammaCategorization.CreationalPatterns.Factory.AbstractFactory;

namespace DesignPatterns.Tests.GammaCategorization.CreationalPatterns.Factory;

public class HotDrinkMachineTest
{
    [Fact]
    public void Test()
    {
        var machine = new HotDrinkMachine();
        var drink = machine.MakeDrink(0, 100);
        drink.Consume();
    }
}