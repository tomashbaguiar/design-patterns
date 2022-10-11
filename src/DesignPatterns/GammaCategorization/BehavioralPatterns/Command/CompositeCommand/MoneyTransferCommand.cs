namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Command.CompositeCommand;

public class MoneyTransferCommand : CompositeBankAccountCommand
{
    public MoneyTransferCommand(BankAccount from, BankAccount to, int amount)
    {
        AddRange(new []
        {
            new BankAccountCommand(from, BankAccountCommand.Action.Withdraw, amount),
            new BankAccountCommand(to, BankAccountCommand.Action.Deposit, amount),
        });
    }

    public override void Call()
    {
        BankAccountCommand? last = null;
        foreach (var c in this)
        {
            if (last == null || last.Success)
            {
                c.Call();
                last = c;
            }
            else
            {
                c.Undo();
                break;
            }
        }
    }
}