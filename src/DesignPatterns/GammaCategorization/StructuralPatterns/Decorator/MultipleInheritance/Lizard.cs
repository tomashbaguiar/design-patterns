namespace DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.MultipleInheritance;

public class Lizard : ILizard
{
    public int Weight { get; set; }

    public void Crawl()
    {
        Console.WriteLine("Crawling in the dirty");
    }
}