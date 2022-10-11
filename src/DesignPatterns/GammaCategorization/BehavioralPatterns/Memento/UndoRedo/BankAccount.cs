namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Memento.UndoRedo;

public class BankAccount
{
    private int _balance;
    private readonly List<Memento> _changes = new();
    private int _currentMemento;

    public BankAccount(int balance)
    {
        _balance = balance;
        _changes.Add(new Memento(balance));
    }

    public Memento Deposit(int amount)
    {
        _balance += amount;
        var m = new Memento(_balance);
        _changes.Add(m);
        ++_currentMemento;
        return m;
    }

    public Memento? Restore(Memento? memento)
    {
        if (memento == null) return null;
        _balance = memento.Balance;
        _changes.Add(memento);
        return memento;
    }

    public Memento? Undo()
    {
        if (_currentMemento <= 0) return null;
        var m = _changes[--_currentMemento];
        _balance = m.Balance;
        return m;
    }

    public Memento? Redo()
    {
        if (_currentMemento + 1 >= _changes.Count) return null;
        var m = _changes[++_currentMemento];
        _balance = m.Balance;
        return m;
    }

    public override string ToString()
    {
        return $"{nameof(_balance)}: {_balance}";
    }
}