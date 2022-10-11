using System.Collections;

namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Iterator.ArrayBackedProperties;

public class Creature : IEnumerable<int>
{
    private readonly int[] _stats = new int[3];
    private const int _strength = 0;

    public int Strength
    {
        get => _stats[_strength];
        set => _stats[_strength] = value;
    }
    public int Agility { get; set; }
    public int Intelligence { get; set; }

    public double AverageStat => _stats.Average();
    public IEnumerator<int> GetEnumerator()
    {
        return _stats.AsEnumerable().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int this[int index]
    {
        get => _stats[index];
        set => _stats[index] = value;
    }
}