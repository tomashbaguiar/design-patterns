using DesignPatterns.GammaCategorization.CreationalPatterns.Singleton.Wrong;

namespace DesignPatterns.GammaCategorization.CreationalPatterns.Singleton.Testable;

public class ConfigurableRecordFinder
{
    private readonly IDatabase _database;

    public ConfigurableRecordFinder(IDatabase database)
    {
        _database = database;
    }

    public int GetTotalPopulation(IEnumerable<string> names)
    {
        return names.Sum(name => _database.GetPopulation(name));
    }
}