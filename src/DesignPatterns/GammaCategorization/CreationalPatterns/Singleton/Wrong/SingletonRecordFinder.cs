namespace DesignPatterns.GammaCategorization.CreationalPatterns.Singleton.Wrong;

public class SingletonRecordFinder
{
    public int GetTotalPopulation(IEnumerable<string> names)
    {
        return names.Sum(name => SingletonDatabase.Instance.GetPopulation(name));
    }
}