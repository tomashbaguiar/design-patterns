using DesignPatterns.GammaCategorization.BehavioralPatterns.NullObject.Singleton;

namespace DesignPatterns.Tests.GammaCategorization.BehavioralPatterns.NullObject;

public class SingletonTest
{
    [Fact]
    public void Test()
    {
        var ba = new BankAccount(ILog.Null);
        ba.Deposit(100);
    }
}