using DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.MultipleInheritance;
using DefaultMembers = DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.MultipleInheritance.DefaultMembers;

namespace DesignPatterns.Tests.GammaCategorization.StructuralPatterns.Decorator;

public class MultipleInheritanceTest
{
    [Fact]
    public void Test()
    {
        var dragon = new Dragon();
        dragon.Fly();
        dragon.Crawl();
        dragon.Weight = 123;
    }
    
    [Fact]
    public void WithDefaultInterfaceMembers()
    {
        var dragon = new DefaultMembers.Dragon { Age = 5 };
        // (dragon as DefaultMembers.IBird).Fly();
        // (dragon as DefaultMembers.ILizard).Crawl();
        if (dragon is DefaultMembers.IBird bird)
            bird.Fly();
        
        if (dragon is DefaultMembers.ILizard lizard)
            lizard.Crawl();
    }
}