namespace DesignPatterns.GammaCategorization.StructuralPatterns.Adapter.DependencyInjection;

public class Editor
{
    private IEnumerable<Button> _buttons;

    public Editor(IEnumerable<Button> buttons)
    {
        _buttons = buttons;
    }

    public void ClickAll()
    {
        foreach (var button in _buttons)
        {
            button.Click();
        }
    }
}