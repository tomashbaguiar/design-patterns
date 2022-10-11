namespace DesignPatterns.GammaCategorization.BehavioralPatterns.ChainOfResponsibility.Exercise;

public class Creatures
{
    private readonly List<Creature> _creatures = new();

    public void Add(Creature creature)
    {
        _creatures.Add(creature);
        
        var numberOfGoblins = _creatures.Count(c => c is Goblin);
        var numberOfGoblinKing = _creatures.Count(c => c is GoblinKing);
        _creatures.ForEach(c =>
        {
            c.Defense = numberOfGoblins;
            c.Attack = numberOfGoblinKing + 1;
        });
    }
}