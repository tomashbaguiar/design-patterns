namespace DesignPatterns.GammaCategorization.StructuralPatterns.Flyweight;

public class FlyweightUser
{
    private static readonly List<string> List = new();
    private readonly int[] _names;

    public FlyweightUser(string fullName)
    {
        int GetOrAdd(string str)
        {
            var idx = List.IndexOf(str);
            if (idx != -1) return idx;
            List.Add(str);
            return List.Count - 1;
        }

        _names = fullName.Split(' ').Select(GetOrAdd).ToArray();
    }
}