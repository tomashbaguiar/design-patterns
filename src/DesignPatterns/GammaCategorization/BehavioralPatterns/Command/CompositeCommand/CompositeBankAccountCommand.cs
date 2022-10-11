namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Command.CompositeCommand;

public class CompositeBankAccountCommand : List<BankAccountCommand>, ICommand
{
    public CompositeBankAccountCommand()
    {
    }

    public CompositeBankAccountCommand(IEnumerable<BankAccountCommand> collection) : base(collection)
    {
    }
    
    public virtual void Call()
    {
        ForEach(c => c.Call());
    }

    public virtual void Undo()
    {
        ((IEnumerable<BankAccountCommand>) this).Reverse().ToList().ForEach(c =>
        {
            if (c.Success) c.Undo();
        });
    }

    public bool Success
    {
        get => this.All(c => c.Success);
        set
        {
            ForEach(c => c.Success = value);
        }
    }
}