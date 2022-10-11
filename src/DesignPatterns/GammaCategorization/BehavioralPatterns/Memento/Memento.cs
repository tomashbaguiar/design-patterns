namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Memento;

public class Memento
{
    public int Balance { get; }

    public Memento(int balance)
    {
        Balance = balance;
    }
}