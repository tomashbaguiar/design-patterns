namespace DesignPatterns.GammaCategorization.CreationalPatterns.Singleton.Wrong;

public class SingletonDatabase : IDatabase
{
    private readonly Dictionary<string, int> _capitals = new();

    private const string Path = 
        @"../../../../../src/DesignPatterns/GammaCategorization/CreationalPatterns/Singleton/capitals.txt";

    private SingletonDatabase()
    {
        var allLines = File.ReadAllLines(Path);
        for (var i = 0; i < allLines.Length; i += 2)
        {
            _capitals.Add(allLines[i], int.Parse(allLines[i + 1]));
        }
    }

    public int GetPopulation(string name)
    {
        return !_capitals.ContainsKey(name) ? 0 : _capitals[name];
    }

    private static readonly Lazy<SingletonDatabase> _instance = new(() => new SingletonDatabase());
    public static SingletonDatabase Instance => _instance.Value;
}