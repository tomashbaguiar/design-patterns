namespace DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.MultipleInheritance.DefaultMembers;

public interface ILizard : ICreature
{
    void Crawl()
    {
        if (Age < 10)
            Console.WriteLine("I am crawling");
    }
}