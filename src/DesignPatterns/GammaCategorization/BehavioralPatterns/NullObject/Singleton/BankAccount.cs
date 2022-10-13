namespace DesignPatterns.GammaCategorization.BehavioralPatterns.NullObject.Singleton;

public class BankAccount
{
    private readonly ILog _log;
    private int _balance;

    public BankAccount(ILog log)
    {
        _log = log;
    }

    public void Deposit(int amount)
    {
        _balance += amount;
        _log.Info($"Deposited {amount}, balance is now {_balance}");
    }
}