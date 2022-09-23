using DesignPatterns.GammaCategorization.StructuralPatterns.Proxy.DynamicProxy;

namespace DesignPatterns.Tests.GammaCategorization.StructuralPatterns.Proxy;

public class DynamicProxyTest
{
    [Fact]
    public void Test()
    {
        var account = new BankAccount();
        
        account.Deposit(100);
        account.Withdraw(50);
        
        Assert.Matches("_balance: 50", account.ToString());
    }
    
    [Fact]
    public void Test_WithLog()
    {
        var account = Log<BankAccount>.As<IBankAccount>();
        
        account.Deposit(100);
        account.Withdraw(50);

        Assert.Contains("Deposit called 1 time(s)", account.ToString());
        Assert.Contains("Withdraw called 1 time(s)", account.ToString());
        Assert.Contains("_balance: 50", account.ToString());
    }
}