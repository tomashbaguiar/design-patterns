namespace DesignPatterns.GammaCategorization.StructuralPatterns.Proxy.CompositeProxy.WithArrayBackedProperties;

public class MasonrySettings
{
    // public bool Pillars;
    // public bool Walls;
    // public bool Floors;
    //
    // public bool? All
    // {
    //     get
    //     {
    //         if (Pillars == Walls && Walls == Floors)
    //             return Pillars;
    //         return null;
    //     }
    //     set
    //     {
    //         if (!value.HasValue) return;
    //         Pillars = value.Value;
    //         Walls = value.Value;
    //         Floors = value.Value;
    //     }
    // }

    private readonly bool[] _flags = new bool[3];

    public bool Pillars
    {
        set => _flags[0] = value;
        get => _flags[0];
    }
    public bool Walls
    {
        set => _flags[0] = value;
        get => _flags[0];
    }
    public bool Floors
    {
        set => _flags[0] = value;
        get => _flags[0];
    }

    public bool? All
    {
        get
        {
            if (_flags.Skip(1).All(f => f == _flags[0]))
                return _flags[0];
            return null;
        }
        set
        {
            if (!value.HasValue) return;
            for (var i = 0; i < _flags.Length; i++)
                _flags[i] = value.Value;
        }
    }
}