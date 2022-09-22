using Autofac;
using DesignPatterns.GammaCategorization.CreationalPatterns.Singleton.Testable;
using NSubstitute;
using Wrong = DesignPatterns.GammaCategorization.CreationalPatterns.Singleton.Wrong;

namespace DesignPatterns.Tests.GammaCategorization.CreationalPatterns.Singleton;

public class DatabaseTest
{
    [Fact]
    public void Test()
    {
        var db = Wrong.SingletonDatabase.Instance;
        const string capital = "Belo Horizonte";
        
        var population = db.GetPopulation(capital);
        
        Assert.Equal(10, population);
    }

    [Fact]
    public void IsSingleton_Test()
    {
        var firstInstance = Wrong.SingletonDatabase.Instance;
        var secondInstance = Wrong.SingletonDatabase.Instance;
        
        Assert.Same(firstInstance, secondInstance);
    }

    [Fact]
    public void SingletonTotalPopulation_Test()
    {
        var rf = new Wrong.SingletonRecordFinder();
        var names = new[] { "Rio", "Belo Horizonte" };

        var tp = rf.GetTotalPopulation(names);
        
        Assert.Equal(10, tp);
    }
    
    [Fact]
    public void SingletonTotalPopulation_WithDummyData()
    {
        var database = Substitute.For<Wrong.IDatabase>();
        var rf = new ConfigurableRecordFinder(database);
        var names = new[] { "Rio", "Belo Horizonte" };
        database.GetPopulation(names.First()).Returns(100);
        database.GetPopulation(names.Last()).Returns(0);

        var tp = rf.GetTotalPopulation(names);
        
        Assert.Equal(100, tp);
    }
    
    [Fact]
    public void SingletonTotalPopulation_WithSingletonRegistered()
    {
        var cb = new ContainerBuilder();
        cb.RegisterType<OrdinaryDatabase>()
            .As<Wrong.IDatabase>()
            .SingleInstance();
        cb.RegisterType<ConfigurableRecordFinder>();
        using var c = cb.Build();
        var rf = c.Resolve<ConfigurableRecordFinder>();
        var names = new[] { "Rio", "Belo Horizonte" };

        var tp = rf.GetTotalPopulation(names);
        
        Assert.Equal(10, tp);
    }
}