using DesignPatterns.GammaCategorization.BehavioralPatterns.ChainOfResponsibility.MethodChain;

namespace DesignPatterns.Tests.GammaCategorization.BehavioralPatterns.ChainOfResponsibility;

public class MethodChainTest
{
    [Fact]
    public void DoublingTheAttack()
    {
        const int attack = 2;
        var goblin = new Creature("Goblin", attack, 2);
        var root = new CreatureModifier(goblin);
        root.Add(new DoubleAttackModifier(goblin));
        
        root.Handle();
        
        Assert.Equal(attack * 2, goblin.Attack);
    }
    
    [Fact]
    public void IncreasingDefence()
    {
        const int defense = 2;
        var goblin = new Creature("Goblin", 2, defense);
        var root = new CreatureModifier(goblin);
        root.Add(new IncreaseDefenseModifier(goblin));
        
        root.Handle();
        
        Assert.Equal(defense + 3, goblin.Defense);
    }
    
    [Fact]
    public void DoublingTheAttack_IncreasingDefense()
    {
        const int attack = 2;
        const int defense = 2;
        var goblin = new Creature("Goblin", attack, defense);
        var root = new CreatureModifier(goblin);
        root.Add(new DoubleAttackModifier(goblin));
        root.Add(new IncreaseDefenseModifier(goblin));

        root.Handle();
        
        Assert.Equal(attack * 2, goblin.Attack);
        Assert.Equal(defense + 3, goblin.Defense);
    }
    
    [Fact]
    public void NoBonusesAllowed()
    {
        const int attack = 2;
        const int defense = 2;
        var goblin = new Creature("Goblin", attack, defense);
        var root = new CreatureModifier(goblin);
        root.Add(new NoBonusesModifier(goblin));
        root.Add(new DoubleAttackModifier(goblin));
        root.Add(new IncreaseDefenseModifier(goblin));

        root.Handle();
        
        Assert.Equal(attack, goblin.Attack);
        Assert.Equal(defense, goblin.Defense);
    }
}