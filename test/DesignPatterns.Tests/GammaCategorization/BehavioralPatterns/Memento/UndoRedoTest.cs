using DesignPatterns.GammaCategorization.BehavioralPatterns.Memento.UndoRedo;

namespace DesignPatterns.Tests.GammaCategorization.BehavioralPatterns.Memento;

public class UndoRedoTest
{
    [Fact]
    public void Test_Undo()
    {
        var ba = new BankAccount(100);
        ba.Deposit(50);
        ba.Deposit(25);
        const string expected = "_balance: 150";

        ba.Undo();
        
        Assert.Matches(expected, ba.ToString());
    }
    
    [Fact]
    public void Test_Redo()
    {
        var ba = new BankAccount(100);
        ba.Deposit(50);
        ba.Deposit(25);
        const string expected = "_balance: 175";
        ba.Undo();

        ba.Redo();
        
        Assert.Matches(expected, ba.ToString());
    }
}