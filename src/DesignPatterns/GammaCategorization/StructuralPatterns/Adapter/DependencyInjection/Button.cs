namespace DesignPatterns.GammaCategorization.StructuralPatterns.Adapter.DependencyInjection;

public class Button
{
    private ICommand _command;

    public Button(ICommand command)
    {
        _command = command;
    }

    public void Click()
    {
        _command.Execute();
    }
}