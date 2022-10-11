using DesignPatterns.GammaCategorization.BehavioralPatterns.Command;

namespace DesignPatterns.Tests.GammaCategorization.BehavioralPatterns.Command;

public class CommandTest
{
    [Fact]
    public void DoCommands()
    {
        var ba = new BankAccount();
        const string expectedRegex = "_balance: 50";
        var commands = new List<BankAccountCommand>
        {
            new(ba, BankAccountCommand.Action.Deposit, 100),
            new(ba, BankAccountCommand.Action.Withdraw, 50),
        };
        
        commands.ForEach(c => c.Call());
        
        Assert.Matches(expectedRegex, ba.ToString());
    }
    
    [Fact]
    public void UndoCommands()
    {
        var ba = new BankAccount();
        const string expectedRegex = "_balance: 0";
        var commands = new List<BankAccountCommand>
        {
            new(ba, BankAccountCommand.Action.Deposit, 100),
            new(ba, BankAccountCommand.Action.Withdraw, 50),
        };
        commands.ForEach(c => c.Call());
        
        Enumerable.Reverse(commands).ToList().ForEach(c => c.Undo());
        
        Assert.Matches(expectedRegex, ba.ToString());
    }
    
    [Fact]
    public void UndoOnlySuccessfulCommands()
    {
        var ba = new BankAccount();
        const string expectedRegex = "_balance: 0";
        var commands = new List<BankAccountCommand>
        {
            new(ba, BankAccountCommand.Action.Deposit, 100),
            new(ba, BankAccountCommand.Action.Withdraw, 150),
        };
        commands.ForEach(c => c.Call());
        
        Enumerable.Reverse(commands).ToList().ForEach(c => c.Undo());
        
        Assert.Matches(expectedRegex, ba.ToString());
    }
}