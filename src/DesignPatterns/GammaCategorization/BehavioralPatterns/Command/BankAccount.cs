namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Command;

public class BankAccount
{
    private int _balance;
    private const int OverdraftLimit = -500;

    public void Deposit(int amount)
    {
        _balance += amount;
    }

    public bool Withdraw(int amount)
    {
        if (_balance - amount < OverdraftLimit) return false;
        _balance -= amount;
        return true;
    }

    public override string ToString()
    {
        return $"{nameof(_balance)}: {_balance}";
    }
}