namespace DesignPatterns.GammaCategorization.CreationalPatterns.Singleton.Monostate;

public class Ceo
{
    private static string _name;
    private static int _age;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public int Age
    {
        get => _age;
        set => _age = value;
    }
}