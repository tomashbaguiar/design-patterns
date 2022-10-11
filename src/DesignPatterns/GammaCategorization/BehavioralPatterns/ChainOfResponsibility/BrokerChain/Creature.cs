namespace DesignPatterns.GammaCategorization.BehavioralPatterns.ChainOfResponsibility.BrokerChain;

public class Creature
{
    private readonly Game _game;
    public string Name;
    private readonly int _attack;
    private readonly int _defense;

    public Creature(Game game, string name, int attack, int defense)
    {
        _game = game;
        Name = name;
        _attack = attack;
        _defense = defense;
    }

    public int Attack
    {
        get
        {
            var query = new Query(Name, Query.Argument.Attack, _attack);
            _game.PerformQuery(this, query);
            return query.Value;
        }
    }
    
    public int Defense
    {
        get
        {
            var query = new Query(Name, Query.Argument.Defense, _defense);
            _game.PerformQuery(this, query);
            return query.Value;
        }
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Attack)}: {Attack}, {nameof(Defense)}: {Defense}";
    }
}