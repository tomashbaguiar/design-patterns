using DesignPatterns.GammaCategorization.BehavioralPatterns.Memento;

namespace DesignPatterns.Tests.GammaCategorization.BehavioralPatterns.Memento;

public class MementoTest
{
    [Fact]
    public void Test()
    {
        const int balance = 100;
        var ba = new BankAccount(balance);
        var m1 = ba.Deposit(50);
        var unused = ba.Deposit(25);
        const string expected = "_balance: 150";

        ba.Restore(m1);

        Assert.Matches(expected, ba.ToString());
    }
}