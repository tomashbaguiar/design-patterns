using DesignPatterns.GammaCategorization.BehavioralPatterns.ChainOfResponsibility.Exercise;

namespace DesignPatterns.Tests.GammaCategorization.BehavioralPatterns.ChainOfResponsibility;

public class ExerciseTest
{
    [Fact]
    public void FirstGoblin_HasAttackOneAndDefenseOne()
    {
        var game = new Game();
        var goblin = new Goblin(game);
        
        game.Creatures.Add(goblin);
        
        Assert.Equal(1, goblin.Attack);
        Assert.Equal(1, goblin.Defense);
    }

    [Fact]
    public void SecondGoblin_HasAttackOneAndDefenseTwo()
    {
        var game = new Game();
        var firstGoblin = new Goblin(game);
        var secondGoblin = new Goblin(game);
        
        game.Creatures.Add(firstGoblin);
        game.Creatures.Add(secondGoblin);
        
        Assert.Equal(1, firstGoblin.Attack);
        Assert.Equal(2, firstGoblin.Defense);
        Assert.Equal(1, secondGoblin.Attack);
        Assert.Equal(2, secondGoblin.Defense);
    }
    
    [Fact]
    public void WithGoblinKing_OneGoblin_HasAttackTwoAndDefenseTwo()
    {
        var game = new Game();
        var goblin = new Goblin(game);
        var goblinKing = new GoblinKing(game);
        
        game.Creatures.Add(goblin);
        game.Creatures.Add(goblinKing);
        
        Assert.Equal(2, goblin.Attack);
        Assert.Equal(2, goblin.Defense);
        Assert.Equal(2, goblinKing.Attack);
        Assert.Equal(2, goblinKing.Defense);
    }
}