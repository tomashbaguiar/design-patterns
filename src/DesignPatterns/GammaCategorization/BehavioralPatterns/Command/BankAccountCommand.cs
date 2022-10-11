namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Command;

public class BankAccountCommand : ICommand
{
    private readonly BankAccount _account;
    private readonly Action _action;
    private readonly int _amount;
    public bool Success { get; set; }

    public BankAccountCommand(BankAccount account, Action action, int amount)
    {
        _account = account;
        _action = action;
        _amount = amount;
    }

    public enum Action
    {
        Deposit, Withdraw
    }
    
    public void Call()
    {
        switch (_action)
        {
            case Action.Deposit:
                _account.Deposit(_amount);
                Success = true;
                break;
            case Action.Withdraw:
                Success = _account.Withdraw(_amount);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public void Undo()
    {
        if (!Success) return;
        switch (_action)
        {
            case Action.Deposit:
                _account.Withdraw(_amount);
                break;
            case Action.Withdraw:
                _account.Deposit(_amount);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}