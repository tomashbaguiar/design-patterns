namespace DesignPatterns.GammaCategorization.StructuralPatterns.Proxy.ValueProxy;

public struct Percentage
{
    private readonly float _value;

    internal Percentage(float value)
    {
        _value = value;
    }

    public static float operator *(float f, Percentage p)
    {
        return f * p._value;
    }

    public static Percentage operator +(Percentage a, Percentage b)
    {
        return new Percentage(a._value + b._value);
    }

    public override string ToString()
    {
        return $"{_value * 100.0f}%";
    }

    public bool Equals(Percentage other)
    {
        return _value.Equals(other._value);
    }

    public override bool Equals(object? obj)
    {
        return obj is Percentage other && Equals(other);
    }

    public override int GetHashCode()
    {
        return _value.GetHashCode();
    }
}