using DesignPatterns.GammaCategorization.BehavioralPatterns.ChainOfResponsibility.BrokerChain;

namespace DesignPatterns.Tests.GammaCategorization.BehavioralPatterns.ChainOfResponsibility;

public class BrokerChainTest
{
    [Fact]
    public void DoublesAttackValue()
    {
        const string name = "Goblin";
        const int attack = 3;
        const int defense = 3;
        var game = new Game();
        var goblin = new Creature(game, name, attack, defense);

        using (new DoubleAttackModifier(game, goblin))
        {
            Assert.Equal(attack * 2, goblin.Attack);   
        }
        
        Assert.Equal(attack, goblin.Attack);
    }
    
    [Fact]
    public void IncreasesDefenseValue()
    {
        const string name = "Goblin";
        const int attack = 3;
        const int defense = 3;
        var game = new Game();
        var goblin = new Creature(game, name, attack, defense);

        using (new IncreaseDefenseModifier(game, goblin))
        {
            Assert.Equal(defense + 2, goblin.Defense);   
        }
        
        Assert.Equal(defense, goblin.Defense);
    }
}