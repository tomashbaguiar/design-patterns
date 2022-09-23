namespace DesignPatterns.GammaCategorization.StructuralPatterns.Proxy.DynamicProxy;

public class BankAccount : IBankAccount
{
    private int _balance;
    private const int OverdraftLimit = -500;

    public BankAccount(int balance)
    {
        _balance = balance;
    }

    public BankAccount()
    {
        
    }
    
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