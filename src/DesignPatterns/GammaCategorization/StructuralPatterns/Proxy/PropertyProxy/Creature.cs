namespace DesignPatterns.GammaCategorization.StructuralPatterns.Proxy.PropertyProxy;

public class Creature
{
    private Property<int> _agility = new();

    public int Agility
    {
        get => _agility.Value;
        set => _agility.Value = value;
    }
}