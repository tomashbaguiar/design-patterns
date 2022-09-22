using DesignPatterns.GammaCategorization.CreationalPatterns.Singleton.Wrong;

namespace DesignPatterns.GammaCategorization.CreationalPatterns.Singleton.Testable;

public class OrdinaryDatabase : IDatabase
{
    public int GetPopulation(string name)
    {
        return 5;
    }
}