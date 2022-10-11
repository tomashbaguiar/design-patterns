namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Memento;

public class BankAccount
{
    private int _balance;

    public BankAccount(int balance)
    {
        _balance = balance;
    }

    public Memento Deposit(int amount)
    {
        _balance += amount;
        return new Memento(_balance);
    }

    public void Restore(Memento memento)
    {
        _balance = memento.Balance;
    }

    public override string ToString()
    {
        return $"{nameof(_balance)}: {_balance}";
    }
}