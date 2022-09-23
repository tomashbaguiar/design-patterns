namespace DesignPatterns.GammaCategorization.StructuralPatterns.Proxy.PropertyProxy;

public class Property<T> where T : new()
{
    private T _value;

    public T Value
    {
        get => _value;
        set
        {
            if (Equals(_value, value)) return;
            _value = value;
        }
    }

    public Property() : this(Activator.CreateInstance<T>())
    {
    }

    public Property(T value)
    {
        _value = value;
    }

    public static implicit operator T(Property<T> property)
    {
        return property._value;
    }

    public static implicit operator Property<T>(T value)
    {
        return new Property<T>(value);
    }

    protected bool Equals(Property<T> other)
    {
        return EqualityComparer<T>.Default.Equals(_value, other._value);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == this.GetType() && Equals((Property<T>)obj);
    }

    public override int GetHashCode()
    {
        return EqualityComparer<T>.Default.GetHashCode(_value);
    }
}