using DesignPatterns.GammaCategorization.StructuralPatterns.Proxy.CompositeProxy;

namespace DesignPatterns.Tests.GammaCategorization.StructuralPatterns.Proxy;

public class CompositeProxyTest
{
    [Fact]
    public void Test()
    {
        var creatures = new Creature[100];
        foreach (var c in creatures)
        {
            c.Position.X++;
        }
    }
    
    [Fact]
    public void Test2()
    {
        var creatures = new Creatures(100);
        foreach (var creature in creatures)
        {
            creature.Position.X++;
        }
    }
}