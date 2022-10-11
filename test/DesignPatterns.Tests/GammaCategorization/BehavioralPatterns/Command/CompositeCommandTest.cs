using DesignPatterns.GammaCategorization.BehavioralPatterns.Command;
using DesignPatterns.GammaCategorization.BehavioralPatterns.Command.CompositeCommand;

namespace DesignPatterns.Tests.GammaCategorization.BehavioralPatterns.Command;

public class CompositeCommandTest
{
    [Fact]
    public void CompositeDo()
    {
        const string expected = "_balance: 50";
        var ba = new BankAccount();
        var deposit = new BankAccountCommand(ba, BankAccountCommand.Action.Deposit, 100);
        var withdraw = new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 50);
        var composite = new CompositeBankAccountCommand(new[] { deposit, withdraw });
        
        composite.Call();
        
        Assert.Matches(expected, ba.ToString());
    }
    
    [Fact]
    public void CompositeUndo()
    {
        const string expected = "_balance: 0";
        var ba = new BankAccount();
        var deposit = new BankAccountCommand(ba, BankAccountCommand.Action.Deposit, 100);
        var withdraw = new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 50);
        var composite = new CompositeBankAccountCommand(new[] { deposit, withdraw });
        composite.Call();
        
        composite.Undo();
        
        Assert.Matches(expected, ba.ToString());
    }
    
    [Fact]
    public void CompositeMoneyTransferDo()
    {
        const string expectedFrom = "_balance: 0";
        const string expectedTo = "_balance: 100";
        var from = new BankAccount();
        from.Deposit(100);
        var to = new BankAccount();

        var mtc = new MoneyTransferCommand(from, to, 100);
        mtc.Call();
        
        Assert.Matches(expectedFrom, from.ToString());
        Assert.Matches(expectedTo, to.ToString());
    }
    
    [Fact]
    public void CompositeMoneyTransferUndo()
    {
        const string expectedFrom = "_balance: 100";
        const string expectedTo = "_balance: 0";
        var from = new BankAccount();
        from.Deposit(100);
        var to = new BankAccount();
        var mtc = new MoneyTransferCommand(from, to, 100);
        mtc.Call();
        
        mtc.Undo();
        
        Assert.Matches(expectedFrom, from.ToString());
        Assert.Matches(expectedTo, to.ToString());
    }
    
    [Fact]
    public void CompositeMoneyTransferDoFailed_BecauseTransferBiggerThanShould_AndUndoDoesNothing()
    {
        const string expectedFrom = "_balance: 100";
        const string expectedTo = "_balance: 0";
        var from = new BankAccount();
        from.Deposit(100);
        var to = new BankAccount();
        var mtc = new MoneyTransferCommand(from, to, 1000);
        mtc.Call();
        
        mtc.Undo();
        
        Assert.Matches(expectedFrom, from.ToString());
        Assert.Matches(expectedTo, to.ToString());
    }
}