using DesignPatterns.GammaCategorization.StructuralPatterns.Proxy.PropertyProxy;

namespace DesignPatterns.Tests.GammaCategorization.StructuralPatterns.Proxy;

public class PropertyProxyTest
{
    [Fact]
    public void Test()
    {
        var creature = new Creature
        {
            Agility = 10,
        };
        creature.Agility = 10;
        // only calls once
    }
}