using Autofac;
using DesignPatterns.GammaCategorization.BehavioralPatterns.NullObject;
using NSubstitute;

namespace DesignPatterns.Tests.GammaCategorization.BehavioralPatterns.NullObject;

public class NullObjectTest
{
    [Fact]
    public void Test()
    {
        var log = Substitute.For<ILog>();
        var ba = new BankAccount(log);
        ba.Deposit(100);
    }
    
    [Fact]
    public void TestNullCb()
    {
        var cb = new ContainerBuilder();
        cb.RegisterType<BankAccount>();
        cb.RegisterType<NullLog>().As<ILog>();
        using var c = cb.Build();
        var ba = c.Resolve<BankAccount>();
        ba.Deposit(100);
    }
}