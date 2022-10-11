namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Command;

public interface ICommand
{
    void Call();
    void Undo();
    bool Success { get; set; }
}