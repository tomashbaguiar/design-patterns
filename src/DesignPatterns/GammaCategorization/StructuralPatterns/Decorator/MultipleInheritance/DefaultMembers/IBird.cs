namespace DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.MultipleInheritance.DefaultMembers;

public interface IBird : ICreature
{
    void Fly()
    {
        if (Age >= 10)
            Console.WriteLine("I am flying");
    }
}