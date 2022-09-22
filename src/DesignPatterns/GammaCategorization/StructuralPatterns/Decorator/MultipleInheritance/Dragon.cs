namespace DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.MultipleInheritance;

public class Dragon : IBird, ILizard
{
    private readonly Bird _bird = new();
    private readonly Lizard _lizard = new();

    public int Weight
    {
        get => Weight;
        set
        {
            _bird.Weight = value;
            _lizard.Weight = value;
        }
    }

    public void Fly()
    {
        _bird.Fly();
    }

    public void Crawl()
    {
        _lizard.Crawl();
    }
}