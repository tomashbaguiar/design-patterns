namespace DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.MultipleInheritance.DefaultMembers;

public class Dragon : Organism, IBird, ILizard
{
    public int Age { get; set; }
}