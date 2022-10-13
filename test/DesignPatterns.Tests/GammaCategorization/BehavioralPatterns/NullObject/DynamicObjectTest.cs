using DesignPatterns.GammaCategorization.BehavioralPatterns.NullObject;
using DesignPatterns.GammaCategorization.BehavioralPatterns.NullObject.DynamicObject;

namespace DesignPatterns.Tests.GammaCategorization.BehavioralPatterns.NullObject;

public class DynamicObjectTest
{
    [Fact]
    public void Test()
    {
        var log = Null<ILog>.Instance;
        var ba = new BankAccount(log);
        ba.Deposit(100);
    }
}